using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    public class SaveableDictionary
    {
        private Dictionary<string, string> dictionary;
        private string file;
        public SaveableDictionary()
        {
            this.dictionary = new Dictionary<string, string>();
        }

        public SaveableDictionary(string file) : this()
        {
            this.file = file;
        }

        public void Add(string word, string translation)
        {
            if (!this.dictionary.ContainsKey(word) && !this.dictionary.ContainsKey(translation))
            {
                this.dictionary.Add(word, translation);
                this.dictionary.Add(translation, word);
            }
        }

        public bool Load()
        {
            try
            {
                string[] lines = File.ReadAllLines(this.file);
                NextLine(lines);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public bool Save()
        {
            try
            {
                StreamWriter writer = new StreamWriter(this.file);
                // Saves every other line from the dictionary to the file to avoid double entries.
                for (int i = 0; i < this.dictionary.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        writer.WriteLine(this.dictionary.Keys.ElementAt(i) + ":" + this.dictionary[this.dictionary.Keys.ElementAt(i)]);
                    }
                }

                writer.Close();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public string Translate(string word)
        {
            if (this.dictionary.ContainsKey(word))
            {
                return this.dictionary[word];
            }

            return null;
        }

        public void Delete(string word)
        {
            foreach (KeyValuePair<string, string> item in this.dictionary)
            {
                if (item.Key == word || item.Value == word)
                {
                    this.dictionary.Remove(item.Key);
                }
            }
        }

        public void NextLine(string[] lines)
        {
            foreach (string line in lines)
            {
                string[] parts = line.Split(":");
                if (!this.dictionary.ContainsKey(parts[0]) || !this.dictionary.ContainsKey(parts[1]))
                {
                    this.dictionary.Add(parts[0], parts[1]);
                    this.dictionary.Add(parts[1], parts[0]);
                }
            }
        }
    }
}