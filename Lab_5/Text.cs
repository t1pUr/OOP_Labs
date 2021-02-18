using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Text
    {
        private string text;
        private Sentence[] sentences;

        public Text(Sentence[] sentences)
        {
            this.sentences = sentences;
            text = "";
            for (int i = 0; i < sentences.Length; i++)
            {
                if (i>0)
                {
                    text += " " + sentences[i].GetSentence;
                }
                else
                {
                    text += sentences[i].GetSentence;
                }
            }
        }

        public string GetText
        {
            get { return text; }
        }

        public void SearchWord(char letter, Dictionary<string, int> pairs)
        {
            
            foreach (Sentence sentence in sentences)
            {
                string[][] array = new string[2][];
                array = sentence.SearchWord(letter);
                for (int i = 0; i < array[0].Length; i++)
                {
                    pairs.Add(array[0][i], Convert.ToInt32(array[1][i]));
                }
            }
        }
    }
}
