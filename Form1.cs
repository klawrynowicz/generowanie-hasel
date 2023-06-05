using System.Reflection.Emit;
using System.Windows.Forms;

namespace generatorHasel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region ukrycie nag≥ÛwkÛw tabPage
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            #endregion

            #region wartoúci domyúlne
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

        #region tabPage3 - generatePasswords
        private void tabPage3_trackBar_lengthOfPass_Scroll(object sender, EventArgs e)
        {
            tabPage3_numericUpDown_lengthOfPass.Value = tabPage3_trackBar_lengthOfPass.Value;
        }

        private void tabPage3_numericUpDown_lengthOfPass_ValueChanged(object sender, EventArgs e)
        {
            tabPage3_trackBar_lengthOfPass.Value = (int)tabPage3_numericUpDown_lengthOfPass.Value;
        }

        private void tabPage3_checkBox_ifIncludeSpecialChar_CheckedChanged(object sender, EventArgs e)
        {
            tabPage3_textBox_includedChar.Visible = tabPage3_checkBox_ifIncludeSpecialChar.Checked;
        }

        private void tabPage3_checkBox_ifExcludeSpecialChar_CheckedChanged(object sender, EventArgs e)
        {
            tabPage3_textBox_excludedChar.Visible = tabPage3_checkBox_ifExcludeSpecialChar.Checked;
        }
        #endregion

        private void button_generatePass_Click(object sender, EventArgs e)
        {
            #region create default Character Set
            CharacterSet letterCase = new(
                new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' });
            CharacterSet upperCase = new(
                 new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' });
            CharacterSet numbers = new(
                 new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
            CharacterSet symbols = new(
                 new List<char> { '!', '@', '#', '$', '%', '^', '&', '*', '-', '_', '+', '=', '(', ')', '[', ']', '{', '}', '"', '\'', ',', '.', '/', '\\', '|', ':', ';', '<', '>', '?' });
            char space = ' ';
            CharacterSet letterPlCase = new(
                 new List<char> { 'π', 'Ê', 'Í', '≥', 'Ò', 'Û', 'ú', 'ü', 'ø' });
            CharacterSet upperPlCase = new(
                 new List<char> { '•', '∆', ' ', '£', '—', '”', 'å', 'è', 'Ø' });
            CharacterSet specificSymbols = new(
                 new List<char> { '~', '`' });
            CharacterSet similarChars = new(
                 new List<char> { '0', 'o', 'O', 'i', 'I', '1', 'l', '|', '\'', '`', ';' });
            #endregion

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
            { characterSet.Add(space); }
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
            sendPasswords(generator.passListToString());
        }


        private void sendPasswords(string passList)
        {
            if (tabPage3_radioButton1.Checked == true)
            {
                Form2 form2 = new Form2(passList);
                form2.Show();
            }
            if (tabPage3_radioButton2.Checked == true)
            {
                tabPage3_saveFileDialog.ShowDialog();
            }
            // !!! else wyúwietl pojedyÒcze has≥o - tabPage2
        }

    }
}