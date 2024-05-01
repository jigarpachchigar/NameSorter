using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NameSorter; 

namespace NameSorter.Tests
{
    [TestFixture]
    public class NameSorterTests
    {
        [Test]
        public void SortNames_ShouldSortNamesCorrectly()
{
    // Arrange
    var unsortedNames = new[]
    {
        "Janet Parsons",
        "Vaughn Lewis",
        "Adonis Julius Archer",
        "Shelby Nathan Yoder",
        "Marin Alvarez",
        "London Lindsey",
        "Beau Tristan Bentley",
        "Leo Gardner",
        "Hunter Uriah Mathew Clarke",
        "Mikayla Lopez",
        "Frankie Conner Ritter"
    };

    var expectedSortedNames = new[]
    {
        "Marin Alvarez",
        "Adonis Julius Archer",
        "Beau Tristan Bentley",
        "Hunter Uriah Mathew Clarke",
        "Leo Gardner",
        "Vaughn Lewis",
        "London Lindsey",
        "Mikayla Lopez",
        "Janet Parsons",
        "Frankie Conner Ritter",
        "Shelby Nathan Yoder"
    };

    var nameSorter = new LinqNameSorter();

    // Act
    var sortedNames = nameSorter.SortNames(unsortedNames);

    // Assert
    Assert.AreEqual(expectedSortedNames, sortedNames);
}

[Test]
public void SortNames_ShouldHandleEmptyInput()
{
    // Arrange
    var unsortedNames = new string[] { };

    var nameSorter = new LinqNameSorter();

    // Act
    var sortedNames = nameSorter.SortNames(unsortedNames);

    // Assert
    Assert.IsEmpty(sortedNames);

    }
    }
}