using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generatorHasel
{
    internal class Pass
    {
        private string password = "";
        public string Password { get; }

        private int lengthOfPass = 0;
        public Pass(CharacterSet characterSet, int lengthOfPass)
        {
            List<char> listChar = new List<char>() { };

            this.lengthOfPass = lengthOfPass;

            for (int i = 0; i < lengthOfPass; i++)
            {
                char drawnChar = characterSet.drawASign();
                while (isTheFirstOrTheLastPositionInPass(i) == true && drawnChar == ' ')
                {
                    drawnChar = characterSet.drawASign();
                }
                listChar.Add(drawnChar);
            }

            password = String.Join("", listChar);
        }

        private bool isTheFirstOrTheLastPositionInPass(int i)
        {
            if (i == 0 || i == (lengthOfPass - 1)) return true;
            else return false;
        }

        public override string ToString()
        {
            return password;
        }

    }
}
