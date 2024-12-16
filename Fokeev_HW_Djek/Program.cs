//Вот дом, который построил Джек. А это пшеница, которая в тёмном чулане хранится в доме, 
//который построил Джек. А это весёлая птица-синица, которая часто ворует пшеницу, 
//которая в тёмном чулане хранится в доме, который построил Джек.

namespace Fokeev_HW_Djek
{
    using static System.Console;
    internal class Programm
    {
        static void Main(string[] args)
        {
            string str = "Вот дом, который построил Джек. " +
                "А это пшеница, которая в тёмном чулане хранится в доме, " +
                "который построил Джек. А это весёлая птица-синица, " +
                "которая часто ворует пшеницу, " +
                "которая в тёмном чулане хранится в доме, который построил Джек.";
            string[] allWords = str.Split(new char[] { ' ', ',', '.', '-'}, StringSplitOptions.RemoveEmptyEntries);
            var sameWords = new Dictionary<string, int>();
            foreach (string word in allWords)
            {
                if (sameWords.ContainsKey(word)) sameWords[word]++;
                else sameWords.Add(word, 1);
            }
            int count = 0, summ = 0;
            foreach (var (word, val) in sameWords)
            {
                WriteLine($"{++count}. {word} {((word.Length<=3)&&(count<=10)?"\t\t":"\t")} {val}");
                summ += val;
            }
            WriteLine($"Всего слов {summ}, количество уникальных слов {count}");
        }


    }
}