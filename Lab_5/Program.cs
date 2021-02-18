using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Letter[] letters = new Letter[]
            {
                new Letter('T'),
                new Letter('h'),
                new Letter('a'),
                new Letter('n'),
                new Letter('k'),
            };
            Letter[] letters2 = new Letter[]
            {
                new Letter('y'),
                new Letter('o'),
                new Letter('u')
            };

            Letter[] letters3 = new Letter[]
            {
                new Letter('b'),
                new Letter('u'),
                new Letter('s')
            };
            Letter[] letters4 = new Letter[]
            {
                new Letter('d'),
                new Letter('r'),
                new Letter('i'),
                new Letter('v'),
                new Letter('e'),
                new Letter('r')
            };
            Letter[] letters5 = new Letter[]
            {
                new Letter('v'),
                new Letter('e'),
                new Letter('r'),
                new Letter('y')
            };
            Letter[] letters6 = new Letter[]
            {
                new Letter('c'),
                new Letter('o'),
                new Letter('o'),
                new Letter('l')
            };
            Letter[] letters7 = new Letter[]
            {
                new Letter('I')
            };
            Letter[] letters8 = new Letter[]
            {
                new Letter('l'),
                new Letter('i'),
                new Letter('k'),
                new Letter('e')
            };
            Letter[] letters9 = new Letter[]
            {
                new Letter('b'),
                new Letter('u'),
                new Letter('s'),
                new Letter('e'),
                new Letter('s')
            };

            Word[] words = new Word[] { new Word(letters), new Word(letters2), new Word(letters3), new Word(letters4), new Word(letters5), new Word(letters6) };
            Word[] words2 = new Word[] { new Word(letters7), new Word(letters8), new Word(letters9) };
            Punctuation[] punctuations = new Punctuation[] { new Punctuation(""), new Punctuation(""), new Punctuation(""), new Punctuation(","), new Punctuation(""), new Punctuation("!") };
            Punctuation[] punctuations2 = new Punctuation[] { new Punctuation(""), new Punctuation(""), new Punctuation(".") };

            Sentence[] sentences = new Sentence[] { new Sentence(words, punctuations), new Sentence(words2, punctuations2) };

            Text text = new Text(sentences);
            Console.WriteLine("Исходный текст: ");
            Console.WriteLine(text.GetText);

            Dictionary<string, int> pairs = new Dictionary<string, int>();

            Console.Write("Введите букву, чтобы отсортировать список слов за вхождением: ");
            char searchChar;
            for (;;)
            {
                string searchLetter = Console.ReadLine();
                if (searchLetter.Length == 1)
                {
                    searchChar = Convert.ToChar(searchLetter);
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели больше, чем 1 символ, попробуйте еще: ");
                }
            }

            pairs = Result(searchChar, text, pairs);
            pairs = pairs.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);   //сортируем за возрастанием 
            

            foreach (KeyValuePair<string, int> keyValue in pairs)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            Console.ReadKey();
        }

        static Dictionary<string, int> Result(char letter, Text text, Dictionary<string, int> pairs)   //метод, который возыращает словарь, в котором ключ это слово, значение - количество вхождений буквы в слово
        {
            text.SearchWord(letter, pairs);
            return pairs;
        }
    }
}
