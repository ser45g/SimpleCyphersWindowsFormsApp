using Cyphers;
using LB1_codes.CypherSettingsForms;
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

        private ICypher _selectedCypher;
        private bool _doesOverwrite=false;

        public List<CypherItem> _cyphers;

        public Form1()
        {
            InitializeComponent();
            _cyphers = new List<CypherItem>() {
                new CypherItem("Шифр Цезаря",new CeaserCypher(3)) ,
                new CypherItem("Инверсный шифр", new InverseCypher()),
                new CypherItem("Шифр перестановкой", ReplacementCypher.Instantiate(1,3,2) )
            };
            cbCypherItemList.DataSource = _cyphers;
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

            _selectedCypher = _cyphers[comboBox.SelectedIndex].Cypher;

        }

        private void btnCypherDecypher_Click(object sender, EventArgs e)
        {
            string result = (_isDecriptionMode == false) ? _selectedCypher.Encrypt(txbMessage.Text) : _selectedCypher.Decrypt(txbMessage.Text);
            txbMessage.Text = result;
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            if (_selectedCypher is InverseCypher)
            {
                NoSettingsAvailableForm noSettingsAvailableForm = new NoSettingsAvailableForm();
                noSettingsAvailableForm.ShowDialog();
            }
            if (_selectedCypher is CeaserCypher)
            {
                CeaserCypherSettingsForm ceaserCypherSettingsForm = new CeaserCypherSettingsForm();
                if (ceaserCypherSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    CypherItem item = _cyphers.Find((el) => el.Cypher is CeaserCypher);
                    if (item == null)
                    {
                        throw new Exception("No Ceaser Cypher Item in the _cypher list");
                    }
                    item.Cypher = new CeaserCypher(ceaserCypherSettingsForm.Shift);
                }
            }

            if (_selectedCypher is ReplacementCypher)
            {
                ReplacementCypherSettingsForm replacementCypherSettingsForm = new ReplacementCypherSettingsForm();
                if (replacementCypherSettingsForm.ShowDialog() == DialogResult.OK)
                {
                    CypherItem item = _cyphers.Find((el) => el.Cypher is ReplacementCypher);
                    if (item == null)
                    {
                        throw new Exception("No Replacement Cypher Item in the _cypher list");
                    }
                    item.Cypher = ReplacementCypher.Instantiate(replacementCypherSettingsForm.Order.Cast<uint>().ToList());
                }
            }
        }

        private void chbOverwrite_CheckedChanged(object sender, EventArgs e)
        {
            _doesOverwrite = !_doesOverwrite;
        }
    }
}
