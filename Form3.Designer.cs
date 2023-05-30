namespace generatorHasel
{
    partial class Form3
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            checkIfExcludeSimilarChars = new CheckBox();
            checkIfSpecificSymbols = new CheckBox();
            checkIfPlLetters = new CheckBox();
            checkIfSpace = new CheckBox();
            checkIfSymbols = new CheckBox();
            checkIfNumbers = new CheckBox();
            checkIfUpperCase = new CheckBox();
            checkIfLetterCase = new CheckBox();
            numbOfPass_numeric = new NumericUpDown();
            label1 = new Label();
            groupBox3 = new GroupBox();
            lengthOfPass_numeric = new NumericUpDown();
            lengthOfPass_track = new TrackBar();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numbOfPass_numeric).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lengthOfPass_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lengthOfPass_track).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(169, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "generuj w programie";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(206, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(138, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "generuj do pliku";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(67, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 63);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkIfExcludeSimilarChars);
            groupBox2.Controls.Add(checkIfSpecificSymbols);
            groupBox2.Controls.Add(checkIfPlLetters);
            groupBox2.Controls.Add(checkIfSpace);
            groupBox2.Controls.Add(checkIfSymbols);
            groupBox2.Controls.Add(checkIfNumbers);
            groupBox2.Controls.Add(checkIfUpperCase);
            groupBox2.Controls.Add(checkIfLetterCase);
            groupBox2.Location = new Point(67, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(382, 195);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "opcje hasła";
            // 
            // checkIfExcludeSimilarChars
            // 
            checkIfExcludeSimilarChars.AutoSize = true;
            checkIfExcludeSimilarChars.Location = new Point(193, 156);
            checkIfExcludeSimilarChars.Name = "checkIfExcludeSimilarChars";
            checkIfExcludeSimilarChars.Size = new Size(185, 24);
            checkIfExcludeSimilarChars.TabIndex = 7;
            checkIfExcludeSimilarChars.Text = "wyklucz podobne znaki";
            checkIfExcludeSimilarChars.UseVisualStyleBackColor = true;
            checkIfExcludeSimilarChars.CheckedChanged += checkIfExcludeSimilarChars_CheckedChanged;
            // 
            // checkIfSpecificSymbols
            // 
            checkIfSpecificSymbols.AutoSize = true;
            checkIfSpecificSymbols.Location = new Point(16, 156);
            checkIfSpecificSymbols.Name = "checkIfSpecificSymbols";
            checkIfSpecificSymbols.Size = new Size(173, 24);
            checkIfSpecificSymbols.TabIndex = 6;
            checkIfSpecificSymbols.Text = "specyficzne znaki [`~]";
            checkIfSpecificSymbols.UseVisualStyleBackColor = true;
            checkIfSpecificSymbols.CheckedChanged += checkIfSpecificSymbols_CheckedChanged;
            // 
            // checkIfPlLetters
            // 
            checkIfPlLetters.AutoSize = true;
            checkIfPlLetters.Location = new Point(193, 118);
            checkIfPlLetters.Name = "checkIfPlLetters";
            checkIfPlLetters.Size = new Size(164, 24);
            checkIfPlLetters.TabIndex = 5;
            checkIfPlLetters.Text = "polskie znaki [ąĆĘ...]";
            checkIfPlLetters.UseVisualStyleBackColor = true;
            checkIfPlLetters.CheckedChanged += checkIfPlLetters_CheckedChanged;
            // 
            // checkIfSpace
            // 
            checkIfSpace.AutoSize = true;
            checkIfSpace.Location = new Point(15, 118);
            checkIfSpace.Name = "checkIfSpace";
            checkIfSpace.Size = new Size(91, 24);
            checkIfSpace.TabIndex = 4;
            checkIfSpace.Text = "spacja [ ]";
            checkIfSpace.UseVisualStyleBackColor = true;
            checkIfSpace.CheckedChanged += checkIfSpace_CheckedChanged;
            // 
            // checkIfSymbols
            // 
            checkIfSymbols.AutoSize = true;
            checkIfSymbols.Location = new Point(193, 79);
            checkIfSymbols.Name = "checkIfSymbols";
            checkIfSymbols.Size = new Size(184, 24);
            checkIfSymbols.TabIndex = 3;
            checkIfSymbols.Text = "znaki specjalne [-_!@...]";
            checkIfSymbols.UseVisualStyleBackColor = true;
            checkIfSymbols.CheckedChanged += checkIfSymbols_CheckedChanged;
            // 
            // checkIfNumbers
            // 
            checkIfNumbers.AutoSize = true;
            checkIfNumbers.Location = new Point(13, 79);
            checkIfNumbers.Name = "checkIfNumbers";
            checkIfNumbers.Size = new Size(109, 24);
            checkIfNumbers.TabIndex = 2;
            checkIfNumbers.Text = "cyfry [123...]";
            checkIfNumbers.UseVisualStyleBackColor = true;
            checkIfNumbers.CheckedChanged += checkIfNumbers_CheckedChanged;
            // 
            // checkIfUpperCase
            // 
            checkIfUpperCase.AutoSize = true;
            checkIfUpperCase.Location = new Point(193, 38);
            checkIfUpperCase.Name = "checkIfUpperCase";
            checkIfUpperCase.Size = new Size(151, 24);
            checkIfUpperCase.TabIndex = 1;
            checkIfUpperCase.Text = "duże litery [ABC...]";
            checkIfUpperCase.UseVisualStyleBackColor = true;
            checkIfUpperCase.CheckedChanged += checkIfUpperCase_CheckedChanged;
            // 
            // checkIfLetterCase
            // 
            checkIfLetterCase.AutoSize = true;
            checkIfLetterCase.Location = new Point(13, 38);
            checkIfLetterCase.Name = "checkIfLetterCase";
            checkIfLetterCase.Size = new Size(148, 24);
            checkIfLetterCase.TabIndex = 0;
            checkIfLetterCase.Text = "małe litery [abc...]";
            checkIfLetterCase.UseVisualStyleBackColor = true;
            checkIfLetterCase.CheckedChanged += checkIfLetterCase_CheckedChanged;
            // 
            // numbOfPass_numeric
            // 
            numbOfPass_numeric.Location = new Point(273, 412);
            numbOfPass_numeric.Name = "numbOfPass_numeric";
            numbOfPass_numeric.Size = new Size(44, 27);
            numbOfPass_numeric.TabIndex = 7;
            numbOfPass_numeric.ValueChanged += numbOfPass_numeric_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 417);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 8;
            label1.Text = "liczba haseł";
            label1.Click += label1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lengthOfPass_numeric);
            groupBox3.Controls.Add(lengthOfPass_track);
            groupBox3.Location = new Point(70, 322);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(379, 84);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "długość haseł";
            // 
            // lengthOfPass_numeric
            // 
            lengthOfPass_numeric.Location = new Point(304, 26);
            lengthOfPass_numeric.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            lengthOfPass_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            lengthOfPass_numeric.Name = "lengthOfPass_numeric";
            lengthOfPass_numeric.Size = new Size(50, 27);
            lengthOfPass_numeric.TabIndex = 8;
            lengthOfPass_numeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            lengthOfPass_numeric.ValueChanged += lengthOfPass_numeric_ValueChanged;
            // 
            // lengthOfPass_track
            // 
            lengthOfPass_track.Location = new Point(5, 26);
            lengthOfPass_track.Maximum = 256;
            lengthOfPass_track.Minimum = 1;
            lengthOfPass_track.Name = "lengthOfPass_track";
            lengthOfPass_track.Size = new Size(293, 56);
            lengthOfPass_track.TabIndex = 7;
            lengthOfPass_track.Value = 1;
            lengthOfPass_track.Scroll += lengthOfPass_track_Scroll;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 450);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(numbOfPass_numeric);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numbOfPass_numeric).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lengthOfPass_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)lengthOfPass_track).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox checkIfUpperCase;
        private CheckBox checkIfLetterCase;
        private CheckBox checkIfSpace;
        private CheckBox checkIfSymbols;
        private CheckBox checkIfNumbers;
        private CheckBox checkIfExcludeSimilarChars;
        private CheckBox checkIfSpecificSymbols;
        private CheckBox checkIfPlLetters;
        private NumericUpDown numbOfPass_numeric;
        private Label label1;
        private GroupBox groupBox3;
        private NumericUpDown lengthOfPass_numeric;
        private TrackBar lengthOfPass_track;
    }
}