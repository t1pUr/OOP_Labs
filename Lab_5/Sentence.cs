using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Sentence
    {
        private string sentence;
        private Word[] words;
        public Sentence(Word[] words, Punctuation[] punctuations)
        {
            this.words = words;
            sentence = "";
            for (int i = 0; i < words.Length; i++)
            {
                sentence += words[i].GetWord + punctuations[i].GetPunctuation;
                if (i != words.Length-1)
                {
                    sentence += " ";
                }
            }
        }

        public string GetSentence
        {
            get { return sentence; }
        }

        public string[][] SearchWord(char letter)
        {
            int count = 0;
            string[][] array = new string[2][];
            array[0] = new string[words.Length];
            array[1] = new string[words.Length];
            int number = 0;
            foreach (Word word in words)
            {
                if (word.GetWord.ToLower().Contains(letter))
                    count = word.GetWord.ToLower().Split(letter).Length - 1;
                else
                    count = 0;
                array[0][number] = word.GetWord;
                array[1][number] = Convert.ToString(count);
                number++;
            }
            return array;
        }
    }
}
