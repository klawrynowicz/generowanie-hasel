using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generatorHasel
{
    public partial class Form3 : Form
    {
        private bool
            ifPrintPassInApp = true,
            ifPrintPassInFile = false;

        private bool
            ifLetterCase = true,        // abc...
            ifUpperCase = true,         // ABC...
            ifNumbers = true,           // 012...
            ifSymbols = false,          // !@#...
            ifSpace = false,            // ' '
            ifPlLetters = false,        // ąĄćĆ...
            ifSpecificSymbols = false,  // ~`
            ifExcludeSimilarChars = false; // 0oOiI1l|'`;

        private List<char> includeChar = new List<char> { };
        private List<char> excludeChar = new List<char> { };

        private int lengthOfPass = 12;
        private int numbOfPass = 1;

        public Form3()
        {
            InitializeComponent();
            CharacterSet characterSet = new CharacterSet(ifLetterCase, ifUpperCase, ifNumbers, ifSymbols, ifSpace, ifPlLetters, ifSpecificSymbols, ifExcludeSimilarChars, includeChar, excludeChar);
            Generator generator = new Generator(characterSet, numbOfPass, lengthOfPass);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            checkIfLetterCase.Checked = ifLetterCase;
            checkIfUpperCase.Checked = ifUpperCase;
            checkIfNumbers.Checked = ifNumbers;
            checkIfSymbols.Checked = ifSymbols;
            checkIfSpace.Checked = ifSpace;
            checkIfPlLetters.Checked = ifPlLetters;
            checkIfSpecificSymbols.Checked = ifSpecificSymbols;

            lengthOfPass_track.Value = lengthOfPass;
            lengthOfPass_numeric.Value = lengthOfPass;

            numbOfPass_numeric.Value = numbOfPass;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lengthOfPass_numeric_ValueChanged(object sender, EventArgs e)
        {
            lengthOfPass = (int)lengthOfPass_numeric.Value;
            lengthOfPass_track.Value = lengthOfPass;
        }

        private void lengthOfPass_track_Scroll(object sender, EventArgs e)
        {
            lengthOfPass = lengthOfPass_track.Value;
            lengthOfPass_numeric.Value = lengthOfPass;
        }

        private void checkIfLetterCase_CheckedChanged(object sender, EventArgs e)
        {
            ifLetterCase = checkIfLetterCase.Checked;
        }

        private void checkIfUpperCase_CheckedChanged(object sender, EventArgs e)
        {
            ifUpperCase = checkIfUpperCase.Checked;
        }

        private void checkIfNumbers_CheckedChanged(object sender, EventArgs e)
        {
            ifNumbers = checkIfNumbers.Checked;
        }

        private void checkIfSymbols_CheckedChanged(object sender, EventArgs e)
        {
            ifSymbols = checkIfSymbols.Checked;
        }

        private void checkIfSpace_CheckedChanged(object sender, EventArgs e)
        {
            ifSpace = checkIfSpace.Checked;
        }

        private void checkIfPlLetters_CheckedChanged(object sender, EventArgs e)
        {
            ifPlLetters = checkIfPlLetters.Checked;
        }

        private void checkIfSpecificSymbols_CheckedChanged(object sender, EventArgs e)
        {
            ifSpecificSymbols = checkIfSpecificSymbols.Checked;
        }

        private void checkIfExcludeSimilarChars_CheckedChanged(object sender, EventArgs e)
        {
            ifExcludeSimilarChars = checkIfExcludeSimilarChars.Checked;
        }

        private void numbOfPass_numeric_ValueChanged(object sender, EventArgs e)
        {
            numbOfPass = (int)numbOfPass_numeric.Value;
        }
    }
}