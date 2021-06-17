using System;
using DataStructure.Sorting;
using Xunit;

namespace DataStructure.Tests
{
    public class SelectionTest
    {
        public SelectionTest()
        {
        }

        [Theory]
        [InlineData("2 3 6 1 9 4", "1 2 3 4 6 9")]
        [InlineData("6 4 6 1 9 2", "1 2 4 6 6 9")]
        [InlineData("4 10 2 1 20 40", "1 2 4 10 20 40")]
        [InlineData("9 7 4 8 3 5 3", "3 3 4 5 7 8 9")]
        public void exercise_shouldReturnSortedArray(string input, string expected)
        {
            SelectionSort sort = new SelectionSort();

            string actual = sort.excercise(input);

            Assert.Equal(expected, actual);
        }

    }
}
