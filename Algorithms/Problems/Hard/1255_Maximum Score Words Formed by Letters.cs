using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Hard
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-score-words-formed-by-letters/
    /// // TODO: Improve performance
    /// </summary>
    class _1255_Maximum_Score_Words_Formed_by_Letters
    {
        public void Run()
        {
            var words = new string[] { "dog", "cat", "dad", "good" };
            var letters = new string[] { "a", "a", "c", "d", "d", "d", "g", "o", "o" }.Select(c => Convert.ToChar(c)).ToArray();
            var score = new int[] { 1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var result = MaxScoreWords(words, letters, score);
        }

        public int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            var max = 0;
            var letterFrequency = GetFrequency(new string(letters));
            var wordsTuple = words.Select(word =>
            {
                var frequency = GetFrequency(word);
                return new Tuple<int[], int>(frequency, CountScore(frequency, score));
            }).ToList();

            MaxScoreWords(wordsTuple, letterFrequency, new int[26], score, 0, ref max);
            return max;
        }

        public void MaxScoreWords(List<Tuple<int[], int>> wordsTuple, int[] letterFrequency, int[] usedLetterFrequency, int[] score, int currentValue, ref int max)
        {
            for (int i = 0; i < wordsTuple.Count; i++)
            {
                var tuple = wordsTuple[i];
                var tmpUsedLetterFrequency = new int[26];
                var lettersEnough = true;

                for (int j = 0; j < tmpUsedLetterFrequency.Length; j++)
                {
                    tmpUsedLetterFrequency[j] = tuple.Item1[j] + usedLetterFrequency[j];
                    if (tmpUsedLetterFrequency[j] > letterFrequency[j])
                    {
                        lettersEnough = false;
                        break;
                    }
                }

                if (lettersEnough)
                {
                    wordsTuple.RemoveAt(i);
                    max = Math.Max(max, currentValue + tuple.Item2);
                    MaxScoreWords(wordsTuple, letterFrequency, tmpUsedLetterFrequency, score, currentValue + tuple.Item2, ref max);
                    wordsTuple.Insert(i, tuple);
                }
            }
        }

        public int CountScore(int[] frequency, int[] score)
        {
            var counter = 0;
            for (int i = 0; i < frequency.Length; i++)
            {
                counter += frequency[i] * score[i];
            }
            return counter;
        }

        public int[] GetFrequency(string word)
        {
            int[] frequency = new int[26];
            foreach (var c in word)
            {
                frequency[c - 'a']++;
            }
            return frequency;
        }
    }
}
