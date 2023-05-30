using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generatorHasel
{
    internal class CharacterSet
    {
        private bool
            ifLetterCase = true,        // abc...
            ifUpperCase = true,         // ABC...
            ifNumbers = true,           // 012...
            ifSymbols = false,          // !@#...
            ifSpace = false,            // ' '
            ifLetterPlCase = false,     // ąćę...
            ifUpperPlCase = false,      // ĄĆĘ...
            ifSpecificSymbols = false,  // ~`
            ifExcludeSimilarChars = false; // 0oOiI1l|'`;

        private List<char> includeChar;
        private List<char> excludeChar;

        private List<char> letterCase = new List<char>()
            { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private List<char> upperCase = new List<char>()
            { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private List<char> numbers = new List<char>()
            { '0', '1' ,'2', '3', '4', '5', '6', '7', '8', '9' };
        private List<char> symbols = new List<char>()
            { '!', '@', '#', '$', '%', '^', '&', '*', '-', '_', '+', '=', '(', ')', '[', ']', '{', '}', '"', '\'', ',', '.', '/', '\\', '|', ':', ';', '<', '>', '?' };
        private char space = ' ';
        private List<char> letterPlCase = new List<char>()
            { 'ą', 'ć', 'ę', 'ł', 'ń', 'ó', 'ś', 'ź', 'ż' };
        private List<char> upperPlCase = new List<char>()
            { 'Ą', 'Ć', 'Ę', 'Ł', 'Ń', 'Ó', 'Ś', 'Ź', 'Ż' };
        private List<char> specificSymbols = new List<char>()
            { '~', '`' };
        private List<char> similarChars = new List<char>()
            { '0', 'o', 'O', 'i', 'I', '1', 'l', '|', '\'', '`', ';'};

        private List<char> characterSet = new List<char>();

        public CharacterSet(bool ifLetterCase, bool ifUpperCase, bool ifNumbers, bool ifSymbols, bool ifSpace, bool ifPlLetters, bool ifSpecificSymbols, bool ifExcludeSimilarChars, List<char> includeChar, List<char> excludeChar)
        {
            this.ifLetterCase = ifLetterCase;
            this.ifUpperCase = ifUpperCase;
            this.ifNumbers = ifNumbers;
            this.ifSymbols = ifSymbols;
            this.ifSpace = ifSpace;
            this.ifLetterPlCase = (ifPlLetters == true && ifLetterCase == true) ? true : false;
            this.ifUpperPlCase = (ifPlLetters == true && ifUpperCase == true) ? true : false;
            if (ifPlLetters == true && ifLetterCase == false && ifUpperCase == false) {this.ifLetterPlCase = true; this.ifUpperPlCase = true; }
            this.ifSpecificSymbols = ifSpecificSymbols;
            this.ifExcludeSimilarChars = ifExcludeSimilarChars;

            this.includeChar = includeChar;
            this.excludeChar = excludeChar;

            createListChars();
            //characterSet.ElementAt(0);
        }

        private void createListChars()
        {
            if (ifLetterCase == true) characterSet.AddRange(letterCase);
            if (ifUpperCase == true) characterSet.AddRange(upperCase);
            if (ifNumbers == true) characterSet.AddRange(numbers);
            if (ifSymbols == true) characterSet.AddRange(symbols);
            if (ifSpace == true) characterSet.Add(space);
            if (ifLetterPlCase == true) characterSet.AddRange(letterPlCase);
            if (ifUpperPlCase == true) characterSet.AddRange(upperPlCase);
            if (ifSpecificSymbols == true) characterSet.AddRange(specificSymbols);
            if (ifExcludeSimilarChars == true) exclude(similarChars);

            if (includeChar.Any() == true) include(includeChar);
            if (excludeChar.Any() == true) exclude(excludeChar);
        }

        private void include(List<char> includeCharList)
        {
            foreach (char item in includeCharList) { if (characterSet.IndexOf(item) != -1) characterSet.Add(item); }
        }

        private void exclude(List<char> excludeCharList)
        // This method removes the first occurrence of a specific object from the List<char> characterSet
        {
            foreach (char item in excludeCharList) { characterSet.Remove(item); }
        }

        private bool ifThisCharIsInList(char znak)
        {
            return true;
            }
    }
}
