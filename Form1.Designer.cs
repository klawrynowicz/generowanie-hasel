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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(109, 152);
            button1.Name = "button1";
            button1.Size = new Size(188, 67);
            button1.TabIndex = 1;
            button1.Text = "Generuj jedno hasło";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(109, 251);
            button2.Name = "button2";
            button2.Size = new Size(188, 67);
            button2.TabIndex = 2;
            button2.Text = "Generuj wiele haseł";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(109, 351);
            button3.Name = "button3";
            button3.Size = new Size(188, 67);
            button3.TabIndex = 3;
            button3.Text = "Informacje o programie";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 81);
            label2.Name = "label2";
            label2.Size = new Size(254, 37);
            label2.TabIndex = 4;
            label2.Text = "Generator haseł";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.padlock;
            logo.Location = new Point(169, 22);
            logo.Name = "logo";
            logo.Size = new Size(56, 56);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 5;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 600);
            Controls.Add(logo);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private PictureBox logo;
    }
}