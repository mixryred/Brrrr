using System;
using System.Linq;
using System.Security.Cryptography;

namespace Series
{
    public class Series
    {
        public int Series16(int a, int[] arr)
        {
            int arrayLength = arr.Length;
            Array.Sort(arr, 0, arrayLength - 2);
            return (arr[arrayLength - 2] > a ? arrayLength - 1 : 0);
        }

        static void Series18(int a, int[] arr)
        {
            int b = 0;
            for (int i = b; i < a; i++)
            {
                int curElement = arr[i];
                Console.WriteLine(curElement);
                for (int j = i; j < a; j++)
                {
                    if (j == a - 1)
                    {
                        return;
                    }
                    if (arr[j] != curElement)
                    {
                        i = j - 1;
                        break;
                    }
                }
            }
        }

        static void Series20(int a, int[] arr)
        {
            int amountOfNums = 0;
            for (int i = 0; i < a - 1; i++)
            {
                Console.WriteLine(arr[i] < arr[i + 1] ? arr[i] : (int?)null);
                amountOfNums++;
            }
            Console.WriteLine(amountOfNums);
        }

        public int Series22(int a, double[] arr)
        {
            for (int i = 1; i < a; i++)
            {
                if (arr[i] > arr[i - 1])
                    return i + 1;
            }
            return 0;
        }

        public int Series24(int a, int[] arr)
        {
            int sum = 0;
            int zeroCounter = 0;
            for (int i = a - 1; i >= 0; i--)
            {
                if (zeroCounter == 2)
                    return sum;
                if (arr[i] == 0)
                    zeroCounter++;
                else
                    sum += arr[i];
            }
            return 0;
        }

        static void Series26(int a, int b, double[] arr)
        {
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(Math.Pow(arr[i], a));
            }
        }

        static void Series28(int a, double[] arr)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(Math.Pow(arr[i], a - i));
            }
        }

        static void Series30(int a, int b, int[][] arr)
        {
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(arr[i].Sum());
            }
        }

        static void Series32(int a, int b, int[][] arr)
        {
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(Array.IndexOf(arr, 2) + 1);
            }
        }

        static void Series34(int a, int b, int[][] arr)
        {
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(Array.IndexOf(arr[i], 2) == -1 ? 0 : arr[i].Sum());
            }
        }

        static bool isSorted(int[] arr)
        {
            int[] arrOrig = arr;
            int[] arrSorted = { };
            Array.Sort(arrSorted, 0, arrSorted.Length - 2);
            return (arrOrig == arrSorted);
        }

        static bool isReversed(int[] arr)
        {
            int[] arrOrig = arr;
            int[] arrReversed = { };
            Array.Sort(arrReversed, 0, arrReversed.Length - 2);
            Array.Reverse(arrReversed, 0, arrReversed.Length - 2);
            return (arrOrig == arrReversed);
        }

        static void Series36(int a, int[][] arr)
        {
            int numOfSortedArrays = 0;
            for (int i = 0; i < a; i++)
            {
                if (isSorted(arr[i]))
                    numOfSortedArrays++;
            }
            Console.WriteLine(numOfSortedArrays);
        }

        static void Series38(int a, int[][] arr)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(isSorted(arr[i]) ? 1 : isReversed(arr[i]) ? -1 : 0);
            }
        }
    }
}
