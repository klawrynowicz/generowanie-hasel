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
    public partial class Form2 : Form
    {
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

        private int numbOfPass = 1;
        private int lengthOfPass = 12;

        public Form2()
        {
            InitializeComponent();
            CharacterSet characterSet = new CharacterSet(ifLetterCase, ifUpperCase, ifNumbers, ifSymbols, ifSpace, ifPlLetters, ifSpecificSymbols, ifExcludeSimilarChars, includeChar, excludeChar);
            Generator generator = new Generator(characterSet, numbOfPass, lengthOfPass);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
