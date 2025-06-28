using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocabularyCommon
{
    public class SetVocabulary
    {
        public string Word { get; set; }
        public string Meaning { get; set; }
        public string Sentence { get; set; }

        public SetVocabulary()
        {
        }

        public void UpdateDetails(string word, string meaning, string sentence)
        {
            if (!string.IsNullOrWhiteSpace(word)) Word = word;
            if (!string.IsNullOrWhiteSpace(meaning)) Meaning = meaning;
            if (!string.IsNullOrWhiteSpace(sentence)) Sentence = sentence;

        }
        public SetVocabulary(string word, string meaning, string sentence)
        {
            Word = word;
            Meaning = meaning;
            Sentence = sentence;

        }

        public override string ToString()
        {
            return $"Word: {Word}\nMeaning: {Meaning}\nSentence: {Sentence}";
        }
    }


}
