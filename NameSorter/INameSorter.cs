using System.Collections.Generic;
using System.Linq;

namespace NameSorter
{
    public interface INameSorter
    {
        IEnumerable<string> SortNames(IEnumerable<string> unsortedNames);
    }
}