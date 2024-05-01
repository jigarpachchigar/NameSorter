using System;
using System.Collections.Generic;

namespace NameSorter
{
    public class NameSorterApp
    {
        private readonly INameSorter _nameSorter;
        private readonly FileService _fileService;

        public NameSorterApp(INameSorter nameSorter, FileService fileService)
        {
            _nameSorter = nameSorter;
            _fileService = fileService;
        }

        public void SortAndSaveNames(string inputFile, string outputFile)
        {
            var unsortedNames = _fileService.ReadNamesFromFile(inputFile);
            var sortedNames = _nameSorter.SortNames(unsortedNames);

            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }

            _fileService.WriteNamesToFile(sortedNames, outputFile);
        }
    }
}