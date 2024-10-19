namespace LB1_codes.CypherSettingsForms
{
    partial class NoSettingsAvailableForm
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.Green;
            richTextBox1.Location = new Point(3, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(415, 165);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Для данного метода шифрования отсутсвтуют какие-либо настойки";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(123, 194);
            button1.Name = "button1";
            button1.Size = new Size(174, 46);
            button1.TabIndex = 1;
            button1.Text = "Хорошо";
            button1.UseVisualStyleBackColor = true;
            // 
            // NoSettingsAvailableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 252);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "NoSettingsAvailableForm";
            Text = "NoSettingsAvailableForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
    }
}