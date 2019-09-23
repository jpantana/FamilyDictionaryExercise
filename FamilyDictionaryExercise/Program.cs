using System;
using System.Collections.Generic;

namespace FamilyDictionaryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("big sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "47" } });
            myFamily.Add("younger sister", new Dictionary<string, string>() { { "name", "Lisa" }, { "age", "45" } });
            myFamily.Add("older brother", new Dictionary<string, string>() { { "name", "Matt" }, { "age", "44" } });
            myFamily.Add("twin brother", new Dictionary<string, string>() { { "name", "Jason" }, { "age", "34" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Linda" }, { "age", "71" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "John" }, { "age", "72" } });
            myFamily.Add("wife", new Dictionary<string, string>() { { "name", "Stephanie" }, { "age", "34" } });

            int count = 0;

            foreach (var famMember in myFamily)
            {
                var nameAndAgeOfRelationDictionary = famMember.Value;
                string fillerTxt = ", and is";

                foreach (var relationsNameAndAge in nameAndAgeOfRelationDictionary.Values)
                {

                    Console.Write($" {relationsNameAndAge}");
                    var relationship = "";

                    relationship = famMember.Key;
                    
                    while (count < 1)
                    {
                        Console.Write($" is my {relationship}");
                        count++;
                    }
                    Console.Write(fillerTxt);

                    fillerTxt = "";
                }
                Console.Write(".");
                count = 0;

                Console.WriteLine();
            }

            

        }
    }
}
