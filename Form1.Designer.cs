namespace LB1_codes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txbMessage = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            toggleButton1 = new CustomControls.ToggleButton();
            panel1 = new Panel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            panel2 = new Panel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            btnOpenFileDialog = new Button();
            panel3 = new Panel();
            chbOverwrite = new MaterialSkin.Controls.MaterialCheckbox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            btnSaveFileDialog = new Button();
            panel4 = new Panel();
            cbCypherItemList = new ComboBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            pictureBoxSettings = new PictureBox();
            cbOverwrite = new CheckBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            btnCypherDecypher = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            cbTypeOfChart = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSettings).BeginInit();
            SuspendLayout();
            // 
            // txbMessage
            // 
            txbMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txbMessage.BackColor = Color.FromArgb(255, 255, 255);
            txbMessage.BorderStyle = BorderStyle.None;
            txbMessage.Depth = 0;
            txbMessage.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txbMessage.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txbMessage.Hint = "Введённое сообщение...";
            txbMessage.Location = new Point(12, 12);
            txbMessage.MouseState = MaterialSkin.MouseState.HOVER;
            txbMessage.Name = "txbMessage";
            txbMessage.Size = new Size(811, 412);
            txbMessage.TabIndex = 1;
            txbMessage.Text = "";
            // 
            // toggleButton1
            // 
            toggleButton1.AutoSize = true;
            toggleButton1.Location = new Point(144, 11);
            toggleButton1.Margin = new Padding(5);
            toggleButton1.MinimumSize = new Size(80, 35);
            toggleButton1.Name = "toggleButton1";
            toggleButton1.OffBackColor = Color.Gray;
            toggleButton1.OffToggleColor = Color.Gainsboro;
            toggleButton1.OnBackColor = Color.MediumSlateBlue;
            toggleButton1.OnToggleColor = Color.WhiteSmoke;
            toggleButton1.Size = new Size(80, 35);
            toggleButton1.TabIndex = 3;
            toggleButton1.UseVisualStyleBackColor = true;
            toggleButton1.CheckedChanged += toggleButton1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(materialLabel3);
            panel1.Controls.Add(materialLabel2);
            panel1.Controls.Add(toggleButton1);
            panel1.Location = new Point(12, 509);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 61);
            panel1.TabIndex = 6;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(244, 22);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(115, 19);
            materialLabel3.TabIndex = 14;
            materialLabel3.Text = "Расшифровать";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(12, 22);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(107, 19);
            materialLabel2.TabIndex = 13;
            materialLabel2.Text = "Зашифровать";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(materialLabel5);
            panel2.Controls.Add(btnOpenFileDialog);
            panel2.Location = new Point(595, 430);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 65);
            panel2.TabIndex = 7;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(14, 24);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(122, 19);
            materialLabel5.TabIndex = 16;
            materialLabel5.Text = "Выбрать файл...";
            // 
            // btnOpenFileDialog
            // 
            btnOpenFileDialog.Image = Properties.Resources.icons8_file_26;
            btnOpenFileDialog.Location = new Point(172, 9);
            btnOpenFileDialog.Name = "btnOpenFileDialog";
            btnOpenFileDialog.Size = new Size(51, 45);
            btnOpenFileDialog.TabIndex = 5;
            btnOpenFileDialog.UseVisualStyleBackColor = true;
            btnOpenFileDialog.Click += btnOpenFileDialog_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(chbOverwrite);
            panel3.Controls.Add(materialLabel4);
            panel3.Controls.Add(btnSaveFileDialog);
            panel3.Location = new Point(392, 509);
            panel3.Name = "panel3";
            panel3.Size = new Size(431, 61);
            panel3.TabIndex = 8;
            // 
            // chbOverwrite
            // 
            chbOverwrite.AutoSize = true;
            chbOverwrite.Depth = 0;
            chbOverwrite.Location = new Point(246, 12);
            chbOverwrite.Margin = new Padding(0);
            chbOverwrite.MouseLocation = new Point(-1, -1);
            chbOverwrite.MouseState = MaterialSkin.MouseState.HOVER;
            chbOverwrite.Name = "chbOverwrite";
            chbOverwrite.Ripple = true;
            chbOverwrite.Size = new Size(166, 37);
            chbOverwrite.TabIndex = 16;
            chbOverwrite.Text = "Переписать файл";
            chbOverwrite.UseVisualStyleBackColor = true;
            chbOverwrite.CheckedChanged += chbOverwrite_CheckedChanged;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(22, 20);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(136, 19);
            materialLabel4.TabIndex = 15;
            materialLabel4.Text = "Сохранить файл...";
            // 
            // btnSaveFileDialog
            // 
            btnSaveFileDialog.BackColor = Color.Transparent;
            btnSaveFileDialog.Image = Properties.Resources.icons8_file_26;
            btnSaveFileDialog.Location = new Point(172, 7);
            btnSaveFileDialog.Name = "btnSaveFileDialog";
            btnSaveFileDialog.Size = new Size(51, 44);
            btnSaveFileDialog.TabIndex = 5;
            btnSaveFileDialog.UseVisualStyleBackColor = false;
            btnSaveFileDialog.Click += btnSaveFileDialog_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(cbCypherItemList);
            panel4.Controls.Add(materialLabel1);
            panel4.Controls.Add(pictureBoxSettings);
            panel4.Location = new Point(12, 430);
            panel4.Name = "panel4";
            panel4.Size = new Size(577, 65);
            panel4.TabIndex = 11;
            // 
            // cbCypherItemList
            // 
            cbCypherItemList.DisplayMember = "Name";
            cbCypherItemList.FormattingEnabled = true;
            cbCypherItemList.Location = new Point(244, 13);
            cbCypherItemList.Name = "cbCypherItemList";
            cbCypherItemList.Size = new Size(276, 28);
            cbCypherItemList.TabIndex = 13;
            cbCypherItemList.Text = "Выберите метод шифрования...";
            cbCypherItemList.SelectedIndexChanged += cbCypherItemList_SelectedIndexChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(12, 22);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(155, 19);
            materialLabel1.TabIndex = 12;
            materialLabel1.Text = "Метод шифрования:";
            // 
            // pictureBoxSettings
            // 
            pictureBoxSettings.Image = Properties.Resources.more;
            pictureBoxSettings.Location = new Point(543, 9);
            pictureBoxSettings.Name = "pictureBoxSettings";
            pictureBoxSettings.Size = new Size(29, 49);
            pictureBoxSettings.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSettings.TabIndex = 11;
            pictureBoxSettings.TabStop = false;
            pictureBoxSettings.Click += pictureBoxSettings_Click;
            // 
            // cbOverwrite
            // 
            cbOverwrite.AutoSize = true;
            cbOverwrite.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbOverwrite.Location = new Point(241, 18);
            cbOverwrite.Name = "cbOverwrite";
            cbOverwrite.Size = new Size(179, 26);
            cbOverwrite.TabIndex = 12;
            cbOverwrite.Text = "Переписать файл";
            cbOverwrite.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.Red;
            richTextBox1.Location = new Point(49, 588);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(437, 44);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "Внимание: если вы не настраиваете метод шифрования, то будут использованы настройки по умолчанию";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(14, 588);
            label1.Name = "label1";
            label1.Size = new Size(29, 41);
            label1.TabIndex = 13;
            label1.Text = "!";
            // 
            // btnCypherDecypher
            // 
            btnCypherDecypher.AccentTextColor = Color.FromArgb(255, 64, 129);
            btnCypherDecypher.Anchor = AnchorStyles.Right;
            btnCypherDecypher.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCypherDecypher.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCypherDecypher.Depth = 0;
            btnCypherDecypher.HighEmphasis = true;
            btnCypherDecypher.Icon = null;
            btnCypherDecypher.Location = new Point(673, 650);
            btnCypherDecypher.Margin = new Padding(4, 6, 4, 6);
            btnCypherDecypher.MouseState = MaterialSkin.MouseState.HOVER;
            btnCypherDecypher.Name = "btnCypherDecypher";
            btnCypherDecypher.NoAccentTextColor = Color.FromArgb(63, 81, 181);
            btnCypherDecypher.Size = new Size(132, 36);
            btnCypherDecypher.TabIndex = 14;
            btnCypherDecypher.Text = "Зашифровать";
            btnCypherDecypher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCypherDecypher.UseAccentColor = false;
            btnCypherDecypher.UseVisualStyleBackColor = true;
            btnCypherDecypher.Click += btnCypherDecypher_Click;
            // 
            // materialButton1
            // 
            materialButton1.AccentTextColor = Color.FromArgb(255, 64, 129);
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(348, 650);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.FromArgb(63, 81, 181);
            materialButton1.Size = new Size(91, 36);
            materialButton1.TabIndex = 15;
            materialButton1.Text = "Графики";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // cbTypeOfChart
            // 
            cbTypeOfChart.DisplayMember = "Name";
            cbTypeOfChart.FormattingEnabled = true;
            cbTypeOfChart.Location = new Point(25, 650);
            cbTypeOfChart.Name = "cbTypeOfChart";
            cbTypeOfChart.Size = new Size(276, 28);
            cbTypeOfChart.TabIndex = 14;
            cbTypeOfChart.Text = "Выберите тип графика...";
            cbTypeOfChart.SelectedIndexChanged += cbTypeOfChart_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 712);
            Controls.Add(cbTypeOfChart);
            Controls.Add(materialButton1);
            Controls.Add(btnCypherDecypher);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(txbMessage);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSettings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialMultiLineTextBox txbMessage;
        private CustomControls.ToggleButton toggleButton1;
        private Panel panel1;
        private Panel panel2;
        private Button btnOpenFileDialog;
        private Panel panel3;
        private Button btnSaveFileDialog;
        private Panel panel4;
        
        private CheckBox cbOverwrite;
        private PictureBox pictureBoxSettings;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCheckbox chbOverwrite;
        private ComboBox cbCypherItemList;
        private RichTextBox richTextBox1;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton btnCypherDecypher;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private ComboBox cbTypeOfChart;
    }
}
