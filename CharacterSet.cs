using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generatorHasel
{
    internal class CharacterSet
    {

        private List<char> characterSet = new List<char>();

        public List<char> getCharacterSet {  get { return characterSet; } }

        public int NumbOfChar { get { return characterSet.Count; } }

        public CharacterSet(List<char> characterSet)
        {
            this.characterSet = characterSet;
        }

        public void include(CharacterSet includeCharList)
        // This method adds only those items that DO NOT appear in the List<char> characterSet 
        {
            foreach (char item in includeCharList.getCharacterSet) { if (characterSet.IndexOf(item) == -1) { characterSet.Add(item); } }
        }

        public void exclude(CharacterSet excludeCharList)
        // This method removes the FIRST occurrence of a specific object from the List<char> characterSet
        {
            foreach (char item in excludeCharList.getCharacterSet) { characterSet.Remove(item); }
        }

        public string display()
        {
            return String.Join(", ", characterSet);
        }
        // This method returns string with all char in List<char> characterSet a comma-separated
        
        public char drawASign()
        // This method draw a sign from the List<char> characterSet
        {
            return characterSet.ElementAt(
                new Random().Next(0, characterSet.Count)
                );
        }

        public bool Any()
        {
            if (characterSet.Any() == true) return true;
            else return false;
        }

        public void AddRange(CharacterSet includedCharacterSet)
        // This method add ALL items from includedCharacterSet to List<char> characterSet
        {
            characterSet.AddRange(includedCharacterSet.getCharacterSet);
        }

        public void Add(char includedChar)
        // This method add ONCE char from includedChar to List<char> characterSet
        {
            characterSet.Add(includedChar);
        }
    }
}
