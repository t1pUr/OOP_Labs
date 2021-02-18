using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Letter
    {
        private char letter;

        public Letter(char letter)
        {
            this.letter = letter;
        }

        public char GetLetter
        {
            get { return letter; }
        }
    }
}
