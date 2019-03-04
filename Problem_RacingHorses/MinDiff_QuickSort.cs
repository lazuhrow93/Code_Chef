using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinDifference
{
    class MinDiff_QuickSort
    {
        static void Main(string[] args)
        {

            quick_sort(ref args, 0, args.Length - 1); //sort the array first, min diff will be by consecutive numbers in sorted array

            find_min_Diff(args); //once sorted find the min diff

            Console.ReadKey();
        }

        static void find_min_Diff(string[] args)
        {
            int min_diff = Int32.Parse(args[1]) - Int32.Parse(args[0]); //assign min difference to the first two elements

            for(int i = 0; i < args.Length-1; ++i)
            {
                if(Int32.Parse(args[i+1]) - Int32.Parse(args[i]) < min_diff) //compare temp min_diff with curr min_diff
                {
                    min_diff = Int32.Parse(args[i + 1]) - Int32.Parse(args[i]);
                }
            }

            Console.WriteLine("the min diff is: " + min_diff); //output the min diff
        }

        static void quick_sort(ref string[] args, int beginnning_index, int ending_index)
        {

            if(beginnning_index < ending_index)
            {
                int p = index_partition(ref args, beginnning_index, ending_index);
                quick_sort(ref args, beginnning_index, p - 1);
                quick_sort(ref args, p, ending_index);
            }

        }

        static int index_partition(ref string[] args, int low, int high)
        {
            int pivot = Int32.Parse(args[high]);
            int i = low;
            for(int j = low; j<high; ++j)
            {
                if (Int32.Parse(args[j]) < pivot)
                {
                    string temp1 = args[i];
                    args[i] = args[j];
                    args[j] = temp1;
                    ++i;
                }
            }

            string temp2 = args[i];
            args[i] = args[high];
            args[high] = temp2;

            return i;
        }
    }
}
