using System;

namespace LabReport_Csit_SijanKarki
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[4][] { new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6,9,67,56 },
                new int[] { 6, 7, 8,45,23 },
                new int[]{2,3 } };


            foreach(int [] subarray in jaggedArray)
            {
                foreach(int j in subarray)
                {
                    Console.Write(j+" ");
                }
            }
        }

    }
}
