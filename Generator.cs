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
        private List<Pass> passList = new List<Pass>() { };
        public List<Pass> PassList { get { return passList; } }
        
        private CharacterSet characterSet;
        private int numbOfPass = 0;
        private int lengthOfPass = 0;

        private const int minLengthOfPass = 5;
        private const int minNumberOfCharAvailable = 5;

        public Generator(CharacterSet characterSet, int lengthOfPass, int numbOfPass) 
        {
            this.characterSet = characterSet;
            this.lengthOfPass = lengthOfPass;
            this.numbOfPass = numbOfPass;

            if (this.characterSet.Any() == false) MessageBox.Show("Nie wybrano żadnych znaków!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (this.characterSet.NumbOfChar < minNumberOfCharAvailable) MessageBox.Show($"Zbyt mała liczba dostępnych znaków. Jest obecnie {characterSet.NumbOfChar}, a minimalna wartość wynosi: {minNumberOfCharAvailable}!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (this.lengthOfPass < minLengthOfPass) MessageBox.Show($"Błąd! Próba generowania zbyt krótkiego hasła! Wybrano długość hasła {lengthOfPass}, a minimalna dłogość wynosi {minLengthOfPass}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else generateResult();
        }

        private void generateResult()
        {
            for (int i = 0; i < numbOfPass; i++)
            {
                passList.Add(
                    new Pass(characterSet, lengthOfPass)
                );
            }
        }

        public string passListToString()
        {
            return String.Join("\r\n", passList);
        }
    }
}
