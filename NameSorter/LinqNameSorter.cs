using System.Collections.Generic;
using System.Linq;

namespace NameSorter
{
    public class LinqNameSorter : INameSorter
    {
        public IEnumerable<string> SortNames(IEnumerable<string> unsortedNames)
        {
            return unsortedNames
                .OrderBy(name => name.Split(' ').Last())
                .ThenBy(name => string.Join(" ", name.Split(' ').Take(name.Split(' ').Length - 1)));
        }
    }
}