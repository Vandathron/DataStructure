using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Sorting
{
    public class MergeSort
    {
        public void Implementation(int[] leftArray, int[] rightArray, int[] parentArray)
        {
            int parentIndex = 0;
            int leftIndex = 0;
            int rightIndex = 0;


            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length )
            {
                if(leftArray[leftIndex] <= rightArray[rightIndex]){
                    parentArray[parentIndex] = leftArray[leftIndex];
                    leftIndex++;
                } else
                {
                    parentArray[parentIndex] = rightArray[rightIndex];
                    rightIndex++;
                }
                parentIndex++;
            }

            while(leftIndex < leftArray.Length)
            {
                parentArray[parentIndex] = leftArray[leftIndex];
                parentIndex++;
                leftIndex++;
            }

            while (rightIndex < rightArray.Length)
            {
                parentArray[parentIndex] = rightArray[rightIndex];
                parentIndex++;
                rightIndex++;
            }
        }

        public void merge(int[] array)
        {
            int arrayLength = array.Length;
            if (arrayLength < 2) return;
            int midLength = arrayLength / 2;
            int[] leftArray = new int[midLength];
            int[] rightArray = new int[arrayLength - midLength];

            for (int i = 0; i < midLength; i++)
            {
                leftArray[i] = array[i];
            }

            for (int i = midLength; i < array.Length; i++)
            {
                rightArray[i] = array[i];
            }

            merge(leftArray);
            merge(rightArray);
            Implementation(leftArray, rightArray, array);
        }

        public void First()
        {

        }
    }
}
