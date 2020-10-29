using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class Floodfill
    {

        public int[,] flood;

        public Floodfill(int[,] flood)
        {
            this.flood = flood;
        }


        public HashSet<int> visited = new HashSet<int>();

        public Stack<Pixel> neighbors = new Stack<Pixel>();

        public Pixel[] getValidNeighbors(int rowId, int colId)
        {
            var pixels =  new Pixel[]
            {
                new Pixel(rowId-1, colId-1), new Pixel(rowId-1, colId), new Pixel(rowId-1, colId+1),
                new Pixel(rowId, colId-1), new Pixel(rowId, colId+1),
                new Pixel(rowId+1, colId-1), new Pixel(rowId+1, colId), new Pixel(rowId+1, colId+1)
            };

            LinkedList<Pixel> pix = new LinkedList<Pixel>(pixels);
            LinkedList<Pixel> p = new LinkedList<Pixel>();

            foreach (var pixel in pix)
            {
                if ((pixel.rowId >= flood.GetLength(0) || pixel.colId >= flood.GetLength(1) || pixel.rowId < 0 || pixel.colId < 0))
                {

                }
                else p.AddLast(pixel);
            }

            var pixe = new Pixel[p.Count];
            for (int i = 0; i < pixe.Length; i++)
            {
                pixe[i] = p.First.Value;
                p.RemoveFirst();
            }

            return pixe;
        }

        public void fillFlood(int rowId, int colId, int colorToReplace, int replacementColor)
        {
            printFlood();
            if (rowId >= flood.GetLength(0) || colId >= flood.GetLength(1)) return;


            if (flood[rowId, colId] != colorToReplace) return;

            visited.Add(new Pixel(rowId, colId).GetHashCode());
            flood[rowId, colId] = replacementColor; //Fill the first Pixel
            printFlood();
            Pixel[] n = getValidNeighbors(rowId, colId);

            addNeighours(n);


            while (neighbors.Count > 0)
            {
                Pixel lastPixel = neighbors.Pop();
                Console.WriteLine(neighbors.Count);
                if (visited.Contains(lastPixel.GetHashCode()))
                {
                    Console.WriteLine("conatins");
                } else
                {
                    Console.WriteLine("Here");
                    flood[lastPixel.rowId, lastPixel.colId] = replacementColor;
                    visited.Add(lastPixel.GetHashCode());
                    addNeighours(getValidNeighbors(lastPixel.rowId, lastPixel.colId));
                }
            }

            Console.WriteLine("Filled");
            Console.WriteLine("----------------------------------------------");
            printFlood();
        }

        public void addNeighours(Pixel[] pixels)
        {
            foreach (Pixel pixel in pixels)
            {
                neighbors.Push(pixel);
            }
        }

        public void printFlood()
        {
            for (int row = 0; row < flood.GetLength(0) ; row++)
            {
                for (int col = 0; col < flood.GetLength(1); col++)
                {
                    Console.Write(" {0} ", flood[row, col]);
                }
                Console.WriteLine();
            }
        }


        public class Pixel
        {
            public int rowId;
            public int colId;

            public Pixel(int rowId, int colId)
            {
                this.rowId = rowId;
                this.colId = colId;
                
            }
        }
    }
}
