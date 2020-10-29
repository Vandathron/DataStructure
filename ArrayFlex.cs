using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class ArrayFlex
    {
        public int[,] arr = new int[4, 2]
        {
            {2, 4 },
            {5, 2 },
            {7, 20 },
            {4, 10 }
        };

        //Jagged Array
        public string[][,] names = new string[4][,]
        {
            new string[2,2]
            {
                {"Name", "VAndathron"},
                {"name", "VAn"}
            },
            new string[,]
            {
                {"Name", "VAndathron" },
                {"name", "VAn" }
            },
            new string[,]
            {
                {"Name", "VAndathron" },
                {"name", "VAn" }
            },
            new string[,]
            {
                {"Name", "VAndathron" },
                {"name", "VAn" }
            }
        }; 

        public void LogArray(int[,] arr)
        {
            foreach (var item in arr)
            {

            }
        }
    }
}
