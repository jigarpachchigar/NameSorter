using System;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: name-sorter <inputFile>");
                return;
            }

            string inputFile = args[0];
            string outputFile = "sorted-names-list.txt";

            var nameSorter = new LinqNameSorter();
            var fileService = new FileService();
            var app = new NameSorterApp(nameSorter, fileService);

            app.SortAndSaveNames(inputFile, outputFile);
        }
    }
}