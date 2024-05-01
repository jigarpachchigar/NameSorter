using System.Collections.Generic;
using System.IO;

namespace NameSorter
{
    public class FileService
    {
        public IEnumerable<string> ReadNamesFromFile(string filePath)
        {
            return File.ReadAllLines(filePath);
        }

        public void WriteNamesToFile(IEnumerable<string> names, string filePath)
        {
            File.WriteAllLines(filePath, names);
        }
    }
}