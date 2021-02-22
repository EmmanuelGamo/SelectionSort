using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[10];
            int i;
            Console.WriteLine("Input 10 numbers:");
            for (i = 0; i < 10; i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nThe numbers in the array are: ");
            PrintElements(Numbers);
            SelectionSort(Numbers);
            Console.Write("\n Sorted using Selection Sort: ");
            PrintElements(Numbers);
            Console.ReadKey();
        }
        public static void SelectionSort(int[] Numbers)  //using Selection Sort
        {
            int space; int min;

            for (int i = 0; i < 10 - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < 10; j++)
                {
                    if (Numbers[j] < Numbers[min])
                    {
                        min = j;
                    }
                }
                space= Numbers[min];
                Numbers[min] = Numbers[i];
                Numbers[i] = space;
            }


        }
        public static void PrintElements(int[] Numbers)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", Numbers[i]);
            }
        }
    }
}
