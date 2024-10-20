namespace LB1_codes
{
    partial class CharacterChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            SuspendLayout();
            // 
            // cartesianChart1
            // 
            cartesianChart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartesianChart1.BackColor = SystemColors.ControlLightLight;
            cartesianChart1.Location = new Point(32, 34);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(695, 294);
            cartesianChart1.TabIndex = 0;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // cartesianChart2
            // 
            cartesianChart2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartesianChart2.BackColor = SystemColors.ControlLightLight;
            cartesianChart2.Location = new Point(32, 360);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(695, 294);
            cartesianChart2.TabIndex = 1;
            cartesianChart2.Text = "cartesianChart2";
            // 
            // CharacterChart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 666);
            Controls.Add(cartesianChart2);
            Controls.Add(cartesianChart1);
            Name = "CharacterChart";
            StartPosition = FormStartPosition.CenterParent;
            Text = "График";
            ResumeLayout(false);
        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
    }
}