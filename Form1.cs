using Cyphers;
using LB1_codes.CypherSettingsForms;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace LB1_codes
{
    public partial class Form1 : Form
    {
        public class CypherItem
        {
            public CypherItem(string name, ICypher cypher)
            {
                Name = name;
                Cypher = cypher;
            }
            public string Name { get; set; }
            public ICypher Cypher { get; set; }
        }

        private string _selectedCypherName;
        private bool _doesOverwrite=false;
        private Dictionary<string, ICypher> _cyphersDictionary; 
        private ObservableCollection<string> _cyphersNames;

        
        public Form1()
        {
            InitializeComponent();
            _cyphersDictionary = new Dictionary<string, ICypher>()
            {
                { "Шифр Цезаря", new CeaserCypher(3) },
                {"Инверсный шифр",new InverseCypher()},
                {"Шифр перестановкой", ReplacementCypher.Instantiate(1,3,2)}
            };

            _cyphersNames = new ObservableCollection<string>(_cyphersDictionary.Keys);
            cbCypherItemList.DataSource = _cyphersNames;
            cbCypherItemList.DisplayMember = "name";

            btnCypherDecypher.Text = "Зашифровать";
        }
        private bool _isDecriptionMode = false;



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

                    txbMessage.Text = await reader.ReadToEndAsync();
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
            string result = (_isDecriptionMode == false) ? _cyphersDictionary[_selectedCypherName].Encrypt(txbMessage.Text) : _cyphersDictionary[_selectedCypherName].Decrypt(txbMessage.Text);
            txbMessage.Text = result;
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
                CeaserCypherSettingsForm ceaserCypherSettingsForm = new CeaserCypherSettingsForm();
                if (ceaserCypherSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    _cyphersDictionary[_selectedCypherName]= new CeaserCypher(ceaserCypherSettingsForm.Shift);
                }
            }

            if (selectedCypher is ReplacementCypher)
            {
                ReplacementCypherSettingsForm replacementCypherSettingsForm = new ReplacementCypherSettingsForm();
                if (replacementCypherSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    var order = replacementCypherSettingsForm.Order.Select(x=>Convert.ToUInt32(x));
                    _cyphersDictionary[_selectedCypherName] = ReplacementCypher.Instantiate(order.ToList());
                }
            }
        }

        private void chbOverwrite_CheckedChanged(object sender, EventArgs e)
        {
            _doesOverwrite = !_doesOverwrite;
        }
    }
}
