namespace generatorHasel
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
            tabControl1 = new TabControl();
            tabPage_home = new TabPage();
            logo = new PictureBox();
            label2 = new Label();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            tabPage_generateOnePass = new TabPage();
            tabPage_generatePasswds = new TabPage();
            tabPage3_button_generatePass = new Button();
            tabPage3_textBox_excludedChar = new TextBox();
            tabPage3_textBox_includedChar = new TextBox();
            label1 = new Label();
            tabPage3_numericUpDown_numbOfPass = new NumericUpDown();
            groupBox3 = new GroupBox();
            tabPage3_numericUpDown_lengthOfPass = new NumericUpDown();
            tabPage3_trackBar_lengthOfPass = new TrackBar();
            groupBox2 = new GroupBox();
            tabPage3_checkBox_ifExcludeSpecialChar = new CheckBox();
            tabPage3_checkBox_ifIncludeSpecialChar = new CheckBox();
            tabPage3_checkBox_ifSpecificSymbols = new CheckBox();
            tabPage3_checkBox_ifPlLetters = new CheckBox();
            tabPage3_checkBox_ifSpace = new CheckBox();
            tabPage3_checkBox_ifSymbols = new CheckBox();
            tabPage3_checkBox_ifExcludeSimilarChars = new CheckBox();
            tabPage3_checkBox_ifNumbers = new CheckBox();
            tabPage3_checkBox_ifUpperCase = new CheckBox();
            tabPage3_checkBox_ifLetterCase = new CheckBox();
            groupBox1 = new GroupBox();
            tabPage3_radioButton2 = new RadioButton();
            tabPage3_radioButton1 = new RadioButton();
            tabPage_about = new TabPage();
            tabPage3_saveFileDialog = new SaveFileDialog();
            tabControl1.SuspendLayout();
            tabPage_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            tabPage_generatePasswds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabPage3_numericUpDown_numbOfPass).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabPage3_numericUpDown_lengthOfPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabPage3_trackBar_lengthOfPass).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_home);
            tabControl1.Controls.Add(tabPage_generateOnePass);
            tabControl1.Controls.Add(tabPage_generatePasswds);
            tabControl1.Controls.Add(tabPage_about);
            tabControl1.Location = new Point(1, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(472, 789);
            tabControl1.TabIndex = 7;
            // 
            // tabPage_home
            // 
            tabPage_home.Controls.Add(logo);
            tabPage_home.Controls.Add(label2);
            tabPage_home.Controls.Add(button3);
            tabPage_home.Controls.Add(button1);
            tabPage_home.Controls.Add(button2);
            tabPage_home.Location = new Point(4, 29);
            tabPage_home.Name = "tabPage_home";
            tabPage_home.Padding = new Padding(3);
            tabPage_home.Size = new Size(464, 756);
            tabPage_home.TabIndex = 0;
            tabPage_home.Text = "tabPage1";
            tabPage_home.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.padlock;
            logo.Location = new Point(198, 35);
            logo.Name = "logo";
            logo.Size = new Size(56, 56);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 5;
            logo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(101, 94);
            label2.Name = "label2";
            label2.Size = new Size(254, 37);
            label2.TabIndex = 4;
            label2.Text = "Generator haseł";
            // 
            // button3
            // 
            button3.Location = new Point(133, 399);
            button3.Name = "button3";
            button3.Size = new Size(188, 67);
            button3.TabIndex = 5;
            button3.Text = "Informacje o programie";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(133, 208);
            button1.Name = "button1";
            button1.Size = new Size(188, 67);
            button1.TabIndex = 4;
            button1.Text = "Generuj jedno hasło";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(133, 299);
            button2.Name = "button2";
            button2.Size = new Size(188, 67);
            button2.TabIndex = 3;
            button2.Text = "Generuj wiele haseł";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabPage_generateOnePass
            // 
            tabPage_generateOnePass.Location = new Point(4, 29);
            tabPage_generateOnePass.Name = "tabPage_generateOnePass";
            tabPage_generateOnePass.Padding = new Padding(3);
            tabPage_generateOnePass.Size = new Size(464, 756);
            tabPage_generateOnePass.TabIndex = 1;
            tabPage_generateOnePass.Text = "tabPage2";
            tabPage_generateOnePass.UseVisualStyleBackColor = true;
            // 
            // tabPage_generatePasswds
            // 
            tabPage_generatePasswds.Controls.Add(tabPage3_button_generatePass);
            tabPage_generatePasswds.Controls.Add(tabPage3_textBox_excludedChar);
            tabPage_generatePasswds.Controls.Add(tabPage3_textBox_includedChar);
            tabPage_generatePasswds.Controls.Add(label1);
            tabPage_generatePasswds.Controls.Add(tabPage3_numericUpDown_numbOfPass);
            tabPage_generatePasswds.Controls.Add(groupBox3);
            tabPage_generatePasswds.Controls.Add(groupBox2);
            tabPage_generatePasswds.Controls.Add(groupBox1);
            tabPage_generatePasswds.Location = new Point(4, 29);
            tabPage_generatePasswds.Name = "tabPage_generatePasswds";
            tabPage_generatePasswds.Padding = new Padding(3);
            tabPage_generatePasswds.Size = new Size(464, 756);
            tabPage_generatePasswds.TabIndex = 2;
            tabPage_generatePasswds.Text = "tabPage3";
            tabPage_generatePasswds.UseVisualStyleBackColor = true;
            // 
            // tabPage3_button_generatePass
            // 
            tabPage3_button_generatePass.Location = new Point(138, 667);
            tabPage3_button_generatePass.Name = "tabPage3_button_generatePass";
            tabPage3_button_generatePass.Size = new Size(166, 60);
            tabPage3_button_generatePass.TabIndex = 15;
            tabPage3_button_generatePass.Text = "Generuj";
            tabPage3_button_generatePass.UseVisualStyleBackColor = true;
            tabPage3_button_generatePass.Click += button_generatePass_Click;
            // 
            // tabPage3_textBox_excludedChar
            // 
            tabPage3_textBox_excludedChar.Location = new Point(239, 430);
            tabPage3_textBox_excludedChar.Name = "tabPage3_textBox_excludedChar";
            tabPage3_textBox_excludedChar.Size = new Size(194, 27);
            tabPage3_textBox_excludedChar.TabIndex = 14;
            tabPage3_textBox_excludedChar.Visible = false;
            // 
            // tabPage3_textBox_includedChar
            // 
            tabPage3_textBox_includedChar.Location = new Point(39, 430);
            tabPage3_textBox_includedChar.Name = "tabPage3_textBox_includedChar";
            tabPage3_textBox_includedChar.Size = new Size(176, 27);
            tabPage3_textBox_includedChar.TabIndex = 13;
            tabPage3_textBox_includedChar.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 611);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 12;
            label1.Text = "liczba haseł";
            // 
            // tabPage3_numericUpDown_numbOfPass
            // 
            tabPage3_numericUpDown_numbOfPass.Location = new Point(241, 606);
            tabPage3_numericUpDown_numbOfPass.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            tabPage3_numericUpDown_numbOfPass.Name = "tabPage3_numericUpDown_numbOfPass";
            tabPage3_numericUpDown_numbOfPass.Size = new Size(44, 27);
            tabPage3_numericUpDown_numbOfPass.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tabPage3_numericUpDown_lengthOfPass);
            groupBox3.Controls.Add(tabPage3_trackBar_lengthOfPass);
            groupBox3.Location = new Point(26, 484);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(418, 102);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "długość haseł";
            // 
            // tabPage3_numericUpDown_lengthOfPass
            // 
            tabPage3_numericUpDown_lengthOfPass.Location = new Point(349, 33);
            tabPage3_numericUpDown_lengthOfPass.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            tabPage3_numericUpDown_lengthOfPass.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            tabPage3_numericUpDown_lengthOfPass.Name = "tabPage3_numericUpDown_lengthOfPass";
            tabPage3_numericUpDown_lengthOfPass.Size = new Size(50, 27);
            tabPage3_numericUpDown_lengthOfPass.TabIndex = 8;
            tabPage3_numericUpDown_lengthOfPass.Value = new decimal(new int[] { 1, 0, 0, 0 });
            tabPage3_numericUpDown_lengthOfPass.ValueChanged += tabPage3_numericUpDown_lengthOfPass_ValueChanged;
            // 
            // tabPage3_trackBar_lengthOfPass
            // 
            tabPage3_trackBar_lengthOfPass.Location = new Point(23, 33);
            tabPage3_trackBar_lengthOfPass.Maximum = 50;
            tabPage3_trackBar_lengthOfPass.Minimum = 1;
            tabPage3_trackBar_lengthOfPass.Name = "tabPage3_trackBar_lengthOfPass";
            tabPage3_trackBar_lengthOfPass.Size = new Size(296, 56);
            tabPage3_trackBar_lengthOfPass.TabIndex = 7;
            tabPage3_trackBar_lengthOfPass.Value = 1;
            tabPage3_trackBar_lengthOfPass.ValueChanged += tabPage3_trackBar_lengthOfPass_Scroll;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tabPage3_checkBox_ifExcludeSpecialChar);
            groupBox2.Controls.Add(tabPage3_checkBox_ifIncludeSpecialChar);
            groupBox2.Controls.Add(tabPage3_checkBox_ifSpecificSymbols);
            groupBox2.Controls.Add(tabPage3_checkBox_ifPlLetters);
            groupBox2.Controls.Add(tabPage3_checkBox_ifSpace);
            groupBox2.Controls.Add(tabPage3_checkBox_ifSymbols);
            groupBox2.Controls.Add(tabPage3_checkBox_ifExcludeSimilarChars);
            groupBox2.Controls.Add(tabPage3_checkBox_ifNumbers);
            groupBox2.Controls.Add(tabPage3_checkBox_ifUpperCase);
            groupBox2.Controls.Add(tabPage3_checkBox_ifLetterCase);
            groupBox2.Location = new Point(26, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(418, 348);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "opcje hasła";
            // 
            // tabPage3_checkBox_ifExcludeSpecialChar
            // 
            tabPage3_checkBox_ifExcludeSpecialChar.AutoSize = true;
            tabPage3_checkBox_ifExcludeSpecialChar.Location = new Point(215, 266);
            tabPage3_checkBox_ifExcludeSpecialChar.Name = "tabPage3_checkBox_ifExcludeSpecialChar";
            tabPage3_checkBox_ifExcludeSpecialChar.Size = new Size(197, 24);
            tabPage3_checkBox_ifExcludeSpecialChar.TabIndex = 15;
            tabPage3_checkBox_ifExcludeSpecialChar.Text = "wyklucz szczególne znaki";
            tabPage3_checkBox_ifExcludeSpecialChar.UseVisualStyleBackColor = true;
            tabPage3_checkBox_ifExcludeSpecialChar.CheckedChanged += tabPage3_checkBox_ifExcludeSpecialChar_CheckedChanged;
            // 
            // tabPage3_checkBox_ifIncludeSpecialChar
            // 
            tabPage3_checkBox_ifIncludeSpecialChar.AutoSize = true;
            tabPage3_checkBox_ifIncludeSpecialChar.Location = new Point(15, 268);
            tabPage3_checkBox_ifIncludeSpecialChar.Name = "tabPage3_checkBox_ifIncludeSpecialChar";
            tabPage3_checkBox_ifIncludeSpecialChar.Size = new Size(190, 24);
            tabPage3_checkBox_ifIncludeSpecialChar.TabIndex = 14;
            tabPage3_checkBox_ifIncludeSpecialChar.Text = "dołącz szczególne znaki";
            tabPage3_checkBox_ifIncludeSpecialChar.UseVisualStyleBackColor = true;
            tabPage3_checkBox_ifIncludeSpecialChar.CheckedChanged += tabPage3_checkBox_ifIncludeSpecialChar_CheckedChanged;
            // 
            // tabPage3_checkBox_ifSpecificSymbols
            // 
            tabPage3_checkBox_ifSpecificSymbols.AutoSize = true;
            tabPage3_checkBox_ifSpecificSymbols.Location = new Point(17, 193);
            tabPage3_checkBox_ifSpecificSymbols.Name = "tabPage3_checkBox_ifSpecificSymbols";
            tabPage3_checkBox_ifSpecificSymbols.Size = new Size(173, 24);
            tabPage3_checkBox_ifSpecificSymbols.TabIndex = 13;
            tabPage3_checkBox_ifSpecificSymbols.Text = "specyficzne znaki [`~]";
            tabPage3_checkBox_ifSpecificSymbols.UseVisualStyleBackColor = true;
            // 
            // tabPage3_checkBox_ifPlLetters
            // 
            tabPage3_checkBox_ifPlLetters.AutoSize = true;
            tabPage3_checkBox_ifPlLetters.Location = new Point(215, 149);
            tabPage3_checkBox_ifPlLetters.Name = "tabPage3_checkBox_ifPlLetters";
            tabPage3_checkBox_ifPlLetters.Size = new Size(164, 24);
            tabPage3_checkBox_ifPlLetters.TabIndex = 12;
            tabPage3_checkBox_ifPlLetters.Text = "polskie znaki [ąĆĘ...]";
            tabPage3_checkBox_ifPlLetters.UseVisualStyleBackColor = true;
            // 
            // tabPage3_checkBox_ifSpace
            // 
            tabPage3_checkBox_ifSpace.AutoSize = true;
            tabPage3_checkBox_ifSpace.Location = new Point(16, 149);
            tabPage3_checkBox_ifSpace.Name = "tabPage3_checkBox_ifSpace";
            tabPage3_checkBox_ifSpace.Size = new Size(91, 24);
            tabPage3_checkBox_ifSpace.TabIndex = 11;
            tabPage3_checkBox_ifSpace.Text = "spacja [ ]";
            tabPage3_checkBox_ifSpace.UseVisualStyleBackColor = true;
            // 
            // tabPage3_checkBox_ifSymbols
            // 
            tabPage3_checkBox_ifSymbols.AutoSize = true;
            tabPage3_checkBox_ifSymbols.Location = new Point(215, 98);
            tabPage3_checkBox_ifSymbols.Name = "tabPage3_checkBox_ifSymbols";
            tabPage3_checkBox_ifSymbols.Size = new Size(184, 24);
            tabPage3_checkBox_ifSymbols.TabIndex = 10;
            tabPage3_checkBox_ifSymbols.Text = "znaki specjalne [-_!@...]";
            tabPage3_checkBox_ifSymbols.UseVisualStyleBackColor = true;
            // 
            // tabPage3_checkBox_ifExcludeSimilarChars
            // 
            tabPage3_checkBox_ifExcludeSimilarChars.AutoSize = true;
            tabPage3_checkBox_ifExcludeSimilarChars.Location = new Point(215, 193);
            tabPage3_checkBox_ifExcludeSimilarChars.Name = "tabPage3_checkBox_ifExcludeSimilarChars";
            tabPage3_checkBox_ifExcludeSimilarChars.Size = new Size(185, 24);
            tabPage3_checkBox_ifExcludeSimilarChars.TabIndex = 9;
            tabPage3_checkBox_ifExcludeSimilarChars.Text = "wyklucz podobne znaki";
            tabPage3_checkBox_ifExcludeSimilarChars.UseVisualStyleBackColor = true;
            // 
            // tabPage3_checkBox_ifNumbers
            // 
            tabPage3_checkBox_ifNumbers.AutoSize = true;
            tabPage3_checkBox_ifNumbers.Location = new Point(17, 100);
            tabPage3_checkBox_ifNumbers.Name = "tabPage3_checkBox_ifNumbers";
            tabPage3_checkBox_ifNumbers.Size = new Size(109, 24);
            tabPage3_checkBox_ifNumbers.TabIndex = 8;
            tabPage3_checkBox_ifNumbers.Text = "cyfry [123...]";
            tabPage3_checkBox_ifNumbers.UseVisualStyleBackColor = true;
            // 
            // tabPage3_checkBox_ifUpperCase
            // 
            tabPage3_checkBox_ifUpperCase.AutoSize = true;
            tabPage3_checkBox_ifUpperCase.Location = new Point(215, 57);
            tabPage3_checkBox_ifUpperCase.Name = "tabPage3_checkBox_ifUpperCase";
            tabPage3_checkBox_ifUpperCase.Size = new Size(151, 24);
            tabPage3_checkBox_ifUpperCase.TabIndex = 2;
            tabPage3_checkBox_ifUpperCase.Text = "duże litery [ABC...]";
            tabPage3_checkBox_ifUpperCase.UseVisualStyleBackColor = true;
            // 
            // tabPage3_checkBox_ifLetterCase
            // 
            tabPage3_checkBox_ifLetterCase.AutoSize = true;
            tabPage3_checkBox_ifLetterCase.Location = new Point(17, 57);
            tabPage3_checkBox_ifLetterCase.Name = "tabPage3_checkBox_ifLetterCase";
            tabPage3_checkBox_ifLetterCase.Size = new Size(148, 24);
            tabPage3_checkBox_ifLetterCase.TabIndex = 1;
            tabPage3_checkBox_ifLetterCase.Text = "małe litery [abc...]";
            tabPage3_checkBox_ifLetterCase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabPage3_radioButton2);
            groupBox1.Controls.Add(tabPage3_radioButton1);
            groupBox1.Location = new Point(56, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 69);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // tabPage3_radioButton2
            // 
            tabPage3_radioButton2.AutoSize = true;
            tabPage3_radioButton2.Location = new Point(173, 26);
            tabPage3_radioButton2.Name = "tabPage3_radioButton2";
            tabPage3_radioButton2.Size = new Size(138, 24);
            tabPage3_radioButton2.TabIndex = 2;
            tabPage3_radioButton2.TabStop = true;
            tabPage3_radioButton2.Text = "generuj do pliku";
            tabPage3_radioButton2.UseVisualStyleBackColor = true;
            // 
            // tabPage3_radioButton1
            // 
            tabPage3_radioButton1.AutoSize = true;
            tabPage3_radioButton1.Checked = true;
            tabPage3_radioButton1.Location = new Point(6, 26);
            tabPage3_radioButton1.Name = "tabPage3_radioButton1";
            tabPage3_radioButton1.Size = new Size(169, 24);
            tabPage3_radioButton1.TabIndex = 1;
            tabPage3_radioButton1.TabStop = true;
            tabPage3_radioButton1.Text = "generuj w programie";
            tabPage3_radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabPage_about
            // 
            tabPage_about.Location = new Point(4, 29);
            tabPage_about.Name = "tabPage_about";
            tabPage_about.Padding = new Padding(3);
            tabPage_about.Size = new Size(464, 756);
            tabPage_about.TabIndex = 3;
            tabPage_about.Text = "tabPage4";
            tabPage_about.UseVisualStyleBackColor = true;
            // 
            // tabPage3_saveFileDialog
            // 
            tabPage3_saveFileDialog.FileName = "passwords.txt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 785);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage_home.ResumeLayout(false);
            tabPage_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            tabPage_generatePasswds.ResumeLayout(false);
            tabPage_generatePasswds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabPage3_numericUpDown_numbOfPass).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabPage3_numericUpDown_lengthOfPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabPage3_trackBar_lengthOfPass).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage_home;
        private TabPage tabPage_generateOnePass;
        private PictureBox logo;
        private Label label2;
        private Button button3;
        private Button button1;
        private Button button2;
        private TabPage tabPage_generatePasswds;
        private TabPage tabPage_about;
        private GroupBox groupBox1;
        private RadioButton tabPage3_radioButton1;
        private RadioButton tabPage3_radioButton2;
        private GroupBox groupBox2;
        private CheckBox tabPage3_checkBox_ifLetterCase;
        private CheckBox tabPage3_checkBox_ifUpperCase;
        private CheckBox tabPage3_checkBox_ifExcludeSimilarChars;
        private CheckBox tabPage3_checkBox_ifNumbers;
        private CheckBox tabPage3_checkBox_ifSymbols;
        private CheckBox tabPage3_checkBox_ifSpace;
        private CheckBox tabPage3_checkBox_ifPlLetters;
        private CheckBox tabPage3_checkBox_ifSpecificSymbols;
        private GroupBox groupBox3;
        private NumericUpDown tabPage3_numericUpDown_lengthOfPass;
        private TrackBar tabPage3_trackBar_lengthOfPass;
        private Label label1;
        private NumericUpDown tabPage3_numericUpDown_numbOfPass;
        private TextBox tabPage3_textBox_excludedChar;
        private TextBox tabPage3_textBox_includedChar;
        private CheckBox tabPage3_checkBox_ifExcludeSpecialChar;
        private CheckBox tabPage3_checkBox_ifIncludeSpecialChar;
        private Button tabPage3_button_generatePass;
        private SaveFileDialog tabPage3_saveFileDialog;
    }
}