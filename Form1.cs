using Cyphers;
using LB1_codes.CypherSettingsForms;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Forms;

namespace LB1_codes
{
    public partial class Form1 : Form
    {

        private string _selectedCypherName;
        private bool _doesOverwrite = false;

        private Dictionary<string, ICypher> _cyphersDictionary;
        private ObservableCollection<string> _cyphersNames;

        private ObservableCollection<string> _chartTypesNames;
        private Dictionary<string, ChartType> _chartTypesDictionary;

        enum ChartType { InitialAndEncrypted, InitialAndDecrypted }

        private string InitialMessage;
        private string EncryptedMessage;
        private string DecryptedMessage;

        public Form1()
        {
            InitializeComponent();
            _cyphersDictionary = new Dictionary<string, ICypher>()
            {
                {"Шифр Цезаря", new CeaserCypher(3) },
                {"Инверсный шифр",new InverseCypher()},
                {"Шифр перестановкой", ReplacementCypher.Instantiate(1,3,2)},
                {"Шифр Виженера",new RepeatingkeyVigenereCypher("key") },
                {"Шифр Гаммированием",new StreamCypher("key") },
                {"Шифр блочной перестановки", new ColumnarTranspositionCypher("key",' ') }
            };

            _cyphersNames = new ObservableCollection<string>(_cyphersDictionary.Keys);
            cbCypherItemList.DataSource = _cyphersNames;

            _chartTypesDictionary = new Dictionary<string, ChartType>() {
                { "Графики исходного и расшифрованного сообщений",ChartType.InitialAndEncrypted},
                { "Графики исходного и дешифрованного сообщений",ChartType.InitialAndDecrypted}
            };
            _chartTypesNames = new ObservableCollection<string>(_chartTypesDictionary.Keys);
            cbTypeOfChart.DataSource = _chartTypesNames;

            btnCypherDecypher.Text = "Зашифровать";
            _selectedCypherName = cbCypherItemList.Items[0].ToString();
            _selectedChartTypeName = cbTypeOfChart.Items[0].ToString();

        }
        private bool _isDecriptionMode = false;
        private string? _selectedChartTypeName;

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            _isDecriptionMode = !_isDecriptionMode;
            btnCypherDecypher.Text = btnCypherDecypher.Text == "Зашифровать" ? "Расшифровать" : "Зашифровать";
        }

        private async void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { CheckFileExists = true, SupportMultiDottedExtensions = true, RestoreDirectory = true };
            openFileDialog.Filter = "Text Files|*.txt|All files|*.*";
            //openFileDialog.InitialDirectory=Directory.GetCurrentDirectory();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var reader = File.OpenText(openFileDialog.FileName))
                {
                    InitialMessage = await reader.ReadToEndAsync();
                }
            }
        }

        private async void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog() { CreatePrompt = true, RestoreDirectory = true, SupportMultiDottedExtensions = true };
            saveFileDialog.Filter = "Text Files|*.txt|All files|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (_doesOverwrite)
                {
                    await File.WriteAllTextAsync(saveFileDialog.FileName, txbMessage.Text);
                }
                else
                {
                    await File.AppendAllTextAsync(saveFileDialog.FileName, txbMessage.Text);
                }
            }
        }

        private void cbCypherItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            if (comboBox == null) { return; }
            string selectedName = comboBox.SelectedItem.ToString();
            _selectedCypherName = selectedName;

        }

        private void btnCypherDecypher_Click(object sender, EventArgs e)
        {
            InitialMessage = txbMessage.Text;
            string result=string.Empty;
            if(_isDecriptionMode == false)
            {
                result=_cyphersDictionary[_selectedCypherName].Encrypt(InitialMessage);

            }
            else
            {
                result= _cyphersDictionary[_selectedCypherName].Decrypt(InitialMessage);
                
            }
           

            txbMessage.Text = result;
          
            if (_isDecriptionMode)
            {
                DecryptedMessage = result;
                EncryptedMessage = null;
            }
            else
            {
                EncryptedMessage = result;
                DecryptedMessage = null;
            }
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            var selectedCypher = _cyphersDictionary[_selectedCypherName];
            if (selectedCypher is InverseCypher)
            {
                NoSettingsAvailableForm noSettingsAvailableForm = new NoSettingsAvailableForm();
                noSettingsAvailableForm.ShowDialog();
            }
            if (selectedCypher is CeaserCypher)
            {
                var ceaserCypher= _cyphersDictionary["Шифр Цезаря"] as CeaserCypher;
                ushort shift = 0;
                if(ceaserCypher==null)
                    shift = 0;
                else
                    shift = ceaserCypher.Shift;

                CeaserCypherSettingsForm ceaserCypherSettingsForm = new CeaserCypherSettingsForm(shift );
                if (ceaserCypherSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _cyphersDictionary[_selectedCypherName] = new CeaserCypher(ceaserCypherSettingsForm.Shift);
                }
            }
            if (selectedCypher is RepeatingkeyVigenereCypher ) {
                var repeatingkeyVigenereCypher = _cyphersDictionary["Шифр Виженера"] as RepeatingkeyVigenereCypher;
                string key = "";
                if (repeatingkeyVigenereCypher == null)
                    key = "key";
                else
                    key = repeatingkeyVigenereCypher.Key;
                SetKeySettingsForm setKeySettingsForm = new SetKeySettingsForm(key);
                if (setKeySettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _cyphersDictionary[_selectedCypherName]= new RepeatingkeyVigenereCypher(setKeySettingsForm.Key);
                }
            }
            if (selectedCypher is StreamCypher)
            {
                
                var streamCypher = _cyphersDictionary["Шифр Гаммированием"] as StreamCypher;
                string key= "";
                if (streamCypher == null)
                    key="key";
                else
                    key = streamCypher.Key;
                SetKeySettingsForm setKeySettingsForm = new SetKeySettingsForm(key);
                if (setKeySettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _cyphersDictionary[_selectedCypherName] = new StreamCypher(setKeySettingsForm.Key);
                }
            }
            if (selectedCypher is ReplacementCypher)
            {
                var ceaserCypher = _cyphersDictionary["Шифр перестановкой"] as ReplacementCypher;
                IList<int> order = new List<int>() { 1, 3, 2 };
                if (ceaserCypher != null)
                    order = ceaserCypher.Order;

                ReplacementCypherSettingsForm replacementCypherSettingsForm = new ReplacementCypherSettingsForm(order);
                if (replacementCypherSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    var orderOfNumbers = replacementCypherSettingsForm.Order;
                    _cyphersDictionary[_selectedCypherName] = ReplacementCypher.Instantiate(orderOfNumbers.ToList());
                }
            }
            if (selectedCypher is ColumnarTranspositionCypher) {
                var columnarTranspositionCypher = _cyphersDictionary["Шифр блочной перестановки"] as ColumnarTranspositionCypher;
                string key = "";
                if (columnarTranspositionCypher == null)
                    key = "key";
                else
                    key = columnarTranspositionCypher.Key;
                SetKeySettingsForm setKeySettingsForm = new SetKeySettingsForm(key);
                if (setKeySettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _cyphersDictionary[_selectedCypherName] = new ColumnarTranspositionCypher(setKeySettingsForm.Key,' ') ;
                }
            }
        }

        private void chbOverwrite_CheckedChanged(object sender, EventArgs e)
        {
            _doesOverwrite = !_doesOverwrite;
        }



        private void materialButton1_Click(object sender, EventArgs e)
        {

            CharacterChart characterChart;
            ChartType chartType = _chartTypesDictionary[_selectedChartTypeName];
            if (InitialMessage == null)
            {
                MessageBox.Show("Необоходимо ввести сообщение","Отсутствует сообщение",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chartType == ChartType.InitialAndEncrypted)
            {
                if (EncryptedMessage == null)
                {
                    MessageBox.Show("Необоходимо зашифровать сообщение", "Отсутствует зашифрованное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                characterChart = new CharacterChart(InitialMessage, EncryptedMessage, false);
            }
            else
            {
                if (DecryptedMessage == null)
                {
                    MessageBox.Show("Необоходимо расшифровать сообщение", "Отсутствует расшифрованное сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                characterChart = new CharacterChart(InitialMessage, DecryptedMessage, true);
            }
            characterChart.ShowDialog();
        }

        private void cbTypeOfChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            if (comboBox == null) { return; }
            string selectedChartType = comboBox.SelectedItem.ToString();
            _selectedChartTypeName = selectedChartType;
        }
    }
}
