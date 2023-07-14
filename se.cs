using System;
using System.Collections.Generic;

namespace SearchEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a collection of documents
            List<string> documents = new List<string>
            {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "Sed eget lacus a dolor fringilla dictum.",
                "Morbi in felis vitae elit fringilla dapibus.",
                "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.",
                "Vestibulum ac justo ac enim iaculis tristique."
            };

            // Perform a search
            Console.Write("Enter a search query: ");
            string query = Console.ReadLine();

            List<string> results = Search(documents, query);

            // Display search results
            Console.WriteLine("Search Results:");
            if (results.Count > 0)
            {
                foreach (string result in results)
                {
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine("No results found.");
            }

            Console.ReadLine();
        }

        static List<string> Search(List<string> documents, string query)
        {
            List<string> results = new List<string>();

            foreach (string document in documents)
            {
                if (document.ToLower().Contains(query.ToLower()))
                {
                    results.Add(document);
                }
            }

            return results;
        }
    }
}