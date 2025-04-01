using Cyphers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1_codes.CypherSettingsForms
{
    public partial class CeaserCypherSettingsForm : Form
    {
        public ushort Shift { get; private set; }
        public CeaserCypherSettingsForm(ushort shift=0)
        {
            InitializeComponent();
            Shift = shift;
            numericUpDown1.Value=Shift;
        }   

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var numericUpDown = sender as NumericUpDown;
            if (numericUpDown == null) { return; }

            Shift=(ushort)numericUpDown.Value;
        }
    }
}
