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
    public partial class ReplacementCypherSettingsForm : Form
    {
        public List<int> Order;
        public ReplacementCypherSettingsForm()
        {
            InitializeComponent();
            Order = Enumerable.Range((int)numericUpDown1.Minimum, (int)numericUpDown1.Value).ToList();
            FillListBox(Order);
            this.listBox1.AllowDrop = true;
        }
        private void FillListBox(IEnumerable<int> order)
        {
            listBox1.Items.Clear();
            foreach (int item in order)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.listBox1.SelectedItem == null) return;
            this.listBox1.DoDragDrop(this.listBox1.SelectedItem, DragDropEffects.Move);
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            Point point = listBox1.PointToClient(new Point(e.X, e.Y));
            int index = this.listBox1.IndexFromPoint(point);
            if (index < 0) index = this.listBox1.Items.Count - 1;
            object data = listBox1.SelectedItem;
            this.listBox1.Items.Remove(data);
            this.listBox1.Items.Insert(index, data);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            FillListBox(Enumerable.Range((int)numericUpDown1.Minimum, (int)numericUpDown1.Value));
        }

        private void ReplacementCypherSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Order.Clear();
            foreach(var item in this.listBox1.Items)
            {
                int value;
                bool result=int.TryParse(item.ToString(),out value);
                if (!result)
                    throw new Exception("Can't cast a list item containing a number to a string");
                Order.Add(value);
            }
        }
    }
}
