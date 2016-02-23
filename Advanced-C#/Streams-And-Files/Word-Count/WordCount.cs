using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Word_Count
{
    class WordCount
    {
        static void Main()
        {
            var result = new Dictionary<string, int>();

            using (StreamReader wordsReader = new StreamReader("../../words.txt"))
            {
                using (StreamReader textReader = new StreamReader("../../text.txt"))
                {
                    using (StreamWriter resultWriter=new StreamWriter("../../result.txt") )
                    {
                        
                        string currrentWord=wordsReader.ReadLine().ToLower();
                        string text=textReader.ReadToEnd().ToLower();

                        while (currrentWord != null)
                        {
                            if (!result.ContainsKey(currrentWord))
                            {
                                result.Add(currrentWord, 0);
                            }

                            if (Regex.IsMatch(text, currrentWord))
                                    {
                                        string pattern = @"\b" + currrentWord + @"\b";
                                        int matches = Regex.Matches(text, pattern).Count;
                                        result[currrentWord] += matches;
                                    }

                                currrentWord = wordsReader.ReadLine();
                            if (currrentWord != null)
                            {
                                currrentWord = currrentWord.ToLower();
                            }
                        }

                        var ordered = result.OrderByDescending(x => x.Value);

                        foreach (var word in ordered)
                        {
                            resultWriter.WriteLine("{0} - {1}", word.Key, word.Value);
                        }
                    }
                }
            }    
        }
    }
}
