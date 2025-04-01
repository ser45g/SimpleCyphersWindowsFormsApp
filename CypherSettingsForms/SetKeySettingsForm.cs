﻿using System;
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
    public partial class SetKeySettingsForm : Form
    {
        public string Key { get; private set; } = "key";

        public SetKeySettingsForm(string key)
        {
            InitializeComponent();
            Key = key;
            richTextBox1.Text = Key;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Key = richTextBox1.Text;
        }
    }
}
