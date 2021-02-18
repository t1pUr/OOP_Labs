using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Word
    {
        private string word;
        

        public Word(Letter[] letters)
        {
            word = "";
            for (int i = 0; i < letters.Length; i++)
            {
                word += letters[i].GetLetter;
            }
            
        }

        public string GetWord
        {
            get { return word; } 
        }
    }
}
