using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Punctuation
    {
        private string punctuation;

        public Punctuation(string punct)
        {
            this.punctuation = punct;
        }

        public string GetPunctuation
        {
            get { return punctuation; }
        }
    }
}
