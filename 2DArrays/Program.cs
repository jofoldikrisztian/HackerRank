using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrays
{
    class Program
    {

        static int hourglassSum(int[][] arr)
        {
            int maxSum = (-9) * 7;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int temp = arr[i + 1][j + 1];
                    for (int k = 0; k < 3; k++)
                    {
                        temp += arr[i][j + k] + arr[i + 2][j + k];
                    }
                    if (temp>=maxSum)
                    {
                        maxSum = temp;
                    }
                }
            }
            return maxSum;
        }



        static void Main(string[] args)
        {


            int[][] arr = new int[][]
            {
                    new int[] {7, 6, 8, 2, 4, 3 },
                    new int[] {7, 3, 3, 0, 6, 1 },
                    new int[] {3, 8, 7, 7, 2, 2 },
                    new int[] {0, 8, 6, 8, 6, 1 },
                    new int[] {7, 1, 6, 0, 2, 4 },
                    new int[] {2, 7, 8, 1, 7, 4 }
            };



            int result = hourglassSum(arr);

            Console.WriteLine(result);
            Console.ReadKey();


        }
    }
}




