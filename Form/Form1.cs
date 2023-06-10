using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace generatorHasel
{
    public partial class Form1 : Form
    {
        #region define default Character Set and auxiliary lists
        private List<char>
            letterCase_Chars = new(),
            upperCase_Chars = new(),
            numbers_Chars = new(),
            symbol_Chars = new(),
            space_Char = new(),
            letterPlCase_Chars = new(),
            upperPlCase_Chars = new(),
            specificSymbols_Chars = new(),
            similarChars_Chars = new();

        private CharacterSet
            letterCase,
            upperCase,
            numbers,
            symbols,
            space,
            letterPlCase,
            upperPlCase,
            specificSymbols,
            similarChars;
        #endregion

        public Form1()
        {
            InitializeComponent();
            #region create default Character Set
            letterCase_Chars.AddRange("abcdefghijklmnopqrstuvwxyz");
            letterCase = new(letterCase_Chars);
            upperCase_Chars.AddRange("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            upperCase = new(upperCase_Chars);
            numbers_Chars.AddRange("0123456789");
            numbers = new(numbers_Chars);
            symbol_Chars.AddRange("!@#$%^&*-_+=()[]{}\"\',./\\|:;<>?");
            symbols = new(symbol_Chars);
            space_Char.Add(' ');
            space = new(space_Char);
            letterPlCase_Chars.AddRange("πÊÍ≥ÒÛúüø");
            letterPlCase = new(letterPlCase_Chars);
            upperPlCase_Chars.AddRange("•∆ £—”åèØ");
            upperPlCase = new(upperPlCase_Chars);
            specificSymbols_Chars.AddRange("~`");
            specificSymbols = new(specificSymbols_Chars);
            similarChars_Chars.AddRange("0oOiI1l|\'\"`;");
            similarChars = new(similarChars_Chars);
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region ukrycie nag≥ÛwkÛw tabPage
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            #endregion

            #region wartoúci domyúlne
            tabPage2_checkBox_ifLetterCase.Checked = true;
            tabPage2_checkBox_ifUpperCase.Checked = true;
            tabPage2_checkBox_ifNumbers.Checked = true;
            tabPage2_checkBox_ifSymbols.Checked = false;
            tabPage2_checkBox_ifSpace.Checked = false;
            tabPage2_checkBox_ifPlLetters.Checked = false;
            tabPage2_checkBox_ifSpecificSymbols.Checked = false;
            tabPage2_checkBox_ifExcludeSimilarChars.Checked = false;
            tabPage2_trackBar_lengthOfPass.Value = 12;
            tabPage2_numericUpDown_lengthOfPass.Value = tabPage2_trackBar_lengthOfPass.Value;

            tabPage3_checkBox_ifLetterCase.Checked = true;
            tabPage3_checkBox_ifUpperCase.Checked = true;
            tabPage3_checkBox_ifNumbers.Checked = true;
            tabPage3_checkBox_ifSymbols.Checked = false;
            tabPage3_checkBox_ifSpace.Checked = false;
            tabPage3_checkBox_ifPlLetters.Checked = false;
            tabPage3_checkBox_ifSpecificSymbols.Checked = false;
            tabPage3_checkBox_ifExcludeSimilarChars.Checked = false;
            tabPage3_trackBar_lengthOfPass.Value = 12;
            tabPage3_numericUpDown_lengthOfPass.Value = tabPage3_trackBar_lengthOfPass.Value;
            tabPage3_numericUpDown_numbOfPass.Value = 1;
            #endregion
        }

        #region tabPage1 - home
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage_generateOnePass);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage_generatePasswds);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage_about);
        }
        #endregion

        #region tabPage2 - generateOnePassword
        private void tabPage2_checkBox_ifIncludeSpecialChar_CheckedChanged(object sender, EventArgs e)
        {
            tabPage2_textBox_includedChar.Visible = tabPage2_checkBox_ifIncludeSpecialChar.Checked;
        }

        private void tabPage2_checkBox_ifExcludeSpecialChar_CheckedChanged(object sender, EventArgs e)
        {
            tabPage2_textBox_excludedChar.Visible = tabPage2_checkBox_ifExcludeSpecialChar.Checked;
        }

        private void tabPage2_trackBar_lengthOfPass_Scroll(object sender, EventArgs e)
        {
            tabPage2_numericUpDown_lengthOfPass.Value = tabPage2_trackBar_lengthOfPass.Value;
        }

        private void tabPage2_numericUpDown_lengthOfPass_ValueChanged(object sender, EventArgs e)
        {
            tabPage2_trackBar_lengthOfPass.Value = (int)tabPage2_numericUpDown_lengthOfPass.Value;
        }

        private void tabPage2_button_generatePass_Click(object sender, EventArgs e)
        {
            #region create customised Character Set
            CharacterSet characterSet = new(new List<char> { });

            if (tabPage2_checkBox_ifLetterCase.Checked == true)
            { characterSet.AddRange(letterCase); }
            if (tabPage2_checkBox_ifUpperCase.Checked == true)
            { characterSet.AddRange(upperCase); }
            if (tabPage2_checkBox_ifNumbers.Checked == true)
            { characterSet.AddRange(numbers); }
            if (tabPage2_checkBox_ifSymbols.Checked == true)
            { characterSet.AddRange(symbols); }
            if (tabPage2_checkBox_ifSpace.Checked == true)
            { characterSet.AddRange(space); }
            if (tabPage2_checkBox_ifPlLetters.Checked == true && tabPage2_checkBox_ifLetterCase.Checked == true)
            { characterSet.AddRange(letterPlCase); }
            if (tabPage2_checkBox_ifPlLetters.Checked == true && tabPage2_checkBox_ifUpperCase.Checked == true)
            { characterSet.AddRange(upperPlCase); }
            if (tabPage2_checkBox_ifPlLetters.Checked == true && (tabPage2_checkBox_ifLetterCase.Checked == false && tabPage2_checkBox_ifUpperCase.Checked == false))
            {
                characterSet.AddRange(letterPlCase);
                characterSet.AddRange(upperPlCase);
            }
            if (tabPage2_checkBox_ifSpecificSymbols.Checked == true)
            { characterSet.AddRange(specificSymbols); }
            if (tabPage2_checkBox_ifExcludeSimilarChars.Checked == true)
            { characterSet.exclude(similarChars); }

            if (tabPage2_checkBox_ifIncludeSpecialChar.Checked == true)
            {
                List<char> includeChar_list = new List<char> { };
                includeChar_list.AddRange(tabPage2_textBox_includedChar.Text);
                CharacterSet includeChar = new(includeChar_list);
                includeChar_list = null;
                characterSet.include(includeChar);
            }
            if (tabPage2_checkBox_ifExcludeSpecialChar.Checked == true)
            {
                List<char> excludeChar_list = new List<char> { };
                excludeChar_list.AddRange(tabPage2_textBox_excludedChar.Text);
                CharacterSet excludeChar = new(excludeChar_list);
                characterSet.exclude(excludeChar);
                excludeChar_list = null;
            }
            #endregion
            Generator generator = new(characterSet, (int)tabPage2_numericUpDown_lengthOfPass.Value, 1);
            sendPasswords(generator.passListToString(), false);
        }
        #endregion

        #region tabPage3 - generatePasswords
        private void tabPage3_checkBox_ifIncludeSpecialChar_CheckedChanged(object sender, EventArgs e)
        {
            tabPage3_textBox_includedChar.Visible = tabPage3_checkBox_ifIncludeSpecialChar.Checked;
        }

        private void tabPage3_checkBox_ifExcludeSpecialChar_CheckedChanged(object sender, EventArgs e)
        {
            tabPage3_textBox_excludedChar.Visible = tabPage3_checkBox_ifExcludeSpecialChar.Checked;
        }

        private void tabPage3_trackBar_lengthOfPass_Scroll(object sender, EventArgs e)
        {
            tabPage3_numericUpDown_lengthOfPass.Value = tabPage3_trackBar_lengthOfPass.Value;
        }

        private void tabPage3_numericUpDown_lengthOfPass_ValueChanged(object sender, EventArgs e)
        {
            tabPage3_trackBar_lengthOfPass.Value = (int)tabPage3_numericUpDown_lengthOfPass.Value;
        }

        private void tabPage3_button_generatePass_Click(object sender, EventArgs e)
        {
            #region create customised Character Set
            CharacterSet characterSet = new(new List<char> { });

            if (tabPage3_checkBox_ifLetterCase.Checked == true)
            { characterSet.AddRange(letterCase); }
            if (tabPage3_checkBox_ifUpperCase.Checked == true)
            { characterSet.AddRange(upperCase); }
            if (tabPage3_checkBox_ifNumbers.Checked == true)
            { characterSet.AddRange(numbers); }
            if (tabPage3_checkBox_ifSymbols.Checked == true)
            { characterSet.AddRange(symbols); }
            if (tabPage3_checkBox_ifSpace.Checked == true)
            { characterSet.AddRange(space); }
            if (tabPage3_checkBox_ifPlLetters.Checked == true && tabPage3_checkBox_ifLetterCase.Checked == true)
            { characterSet.AddRange(letterPlCase); }
            if (tabPage3_checkBox_ifPlLetters.Checked == true && tabPage3_checkBox_ifUpperCase.Checked == true)
            { characterSet.AddRange(upperPlCase); }
            if (tabPage3_checkBox_ifPlLetters.Checked == true && (tabPage3_checkBox_ifLetterCase.Checked == false && tabPage3_checkBox_ifUpperCase.Checked == false))
            {
                characterSet.AddRange(letterPlCase);
                characterSet.AddRange(upperPlCase);
            }
            if (tabPage3_checkBox_ifSpecificSymbols.Checked == true)
            { characterSet.AddRange(specificSymbols); }
            if (tabPage3_checkBox_ifExcludeSimilarChars.Checked == true)
            { characterSet.exclude(similarChars); }

            if (tabPage3_checkBox_ifIncludeSpecialChar.Checked == true)
            {
                List<char> includeChar_list = new List<char> { };
                includeChar_list.AddRange(tabPage3_textBox_includedChar.Text);
                CharacterSet includeChar = new(includeChar_list);
                includeChar_list = null;
                characterSet.include(includeChar);
            }
            if (tabPage3_checkBox_ifExcludeSpecialChar.Checked == true)
            {
                List<char> excludeChar_list = new List<char> { };
                excludeChar_list.AddRange(tabPage3_textBox_excludedChar.Text);
                CharacterSet excludeChar = new(excludeChar_list);
                characterSet.exclude(excludeChar);
                excludeChar_list = null;
            }
            #endregion

            Generator generator = new(characterSet, (int)tabPage3_numericUpDown_lengthOfPass.Value, (int)tabPage3_numericUpDown_numbOfPass.Value);
            sendPasswords(generator.passListToString(), true);
        }
        #endregion

        #region tabPage4 - about
        #endregion

        private void tabPageX_pictureBox_back_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage_home);
        }

        private void sendPasswords(string passList, bool isManyPass)
        {
            if (isManyPass == true)
            {
                if (tabPage3_radioButton1.Checked == true)
                {
                    Form2 form2 = new Form2(passList);
                    form2.Show();
                }
                else if (tabPage3_radioButton2.Checked == true)
                {
                    if (tabPage3_saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter writer = new StreamWriter(tabPage3_saveFileDialog.OpenFile());
                        writer.Write(passList);
                        writer.Dispose();
                        writer.Close();
                    }
                }
                else { MessageBox.Show("Nie wybrano miejsca dokπd chcesz wygenerowaÊ has≥a!", "B≥πd", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                tabPage2_textBox_generatedPass.Text = passList;
            }
        }
    }
}