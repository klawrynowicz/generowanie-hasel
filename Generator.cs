using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generatorHasel
{
    internal class Generator
    {
        private CharacterSet characterSet;
        private int numbOfPass = 0;
        private int lengthOfPass = 0;
        private List<string> passList = new List<string>() { };

        public Generator(CharacterSet characterSet, int numbOfPass, int lengthOfPass) 
        {
            this.characterSet = characterSet;
            this.numbOfPass = numbOfPass;
            this.lengthOfPass = lengthOfPass;

            generateResult();
        }

        private void generateResult()
        {
            for (int i = 0; i < numbOfPass; i++)
            {
                passList.Add(generateOnePass());
            }
        }

        private string generateOnePass()
        {
            List<char> password = new List<char>() { };

            for (uint i = 0; i < lengthOfPass; i++)
            {
                char drawnChar = characterSet.drawASign();
                if (isTheFirstOrTheLastPositionInPass(i) == true && drawnChar == ' ')
                {
                    while (true)
                    {
                        drawnChar = characterSet.drawASign();
                        if (drawnChar == ' ') continue;
                        else break;
                    }
                }
                password.Add(drawnChar);
            }
            return String.Join("", password);
        }

        private bool isTheFirstOrTheLastPositionInPass(uint i)
        {
            if (i == 0 || i == (lengthOfPass - 1)) return true;
            else return false;
        }

        public string display()
        {
            return String.Join("\n", passList);
        }
    }
}
