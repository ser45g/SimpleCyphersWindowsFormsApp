namespace LB1_codes.CypherSettingsForms
{
    partial class CeaserCypherSettingsForm
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
            button1 = new Button();
            button2 = new Button();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(286, 97);
            button1.Name = "button1";
            button1.Size = new Size(140, 49);
            button1.TabIndex = 0;
            button1.Text = "Хорошо";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(12, 97);
            button2.Name = "button2";
            button2.Size = new Size(140, 49);
            button2.TabIndex = 1;
            button2.Text = "Отменить";
            button2.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(12, 37);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(255, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Сдвиг вправо для шифра Цезаря:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(300, 32);
            numericUpDown1.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(126, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // CeaserCypherSettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 172);
            Controls.Add(numericUpDown1);
            Controls.Add(materialLabel1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CeaserCypherSettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Настройка шифра Цезаря";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private NumericUpDown numericUpDown1;
    }
}