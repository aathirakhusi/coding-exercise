using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge
{
    public class FindMedian
    {
        public static void MainFindMedian(string[] args)
        {

            List<int> arr = new List<int> { 1, 2, 3, 4, 5 };

            var val = findMedian(arr);
            Console.WriteLine(val); 
        }
        public static int findMedian(List<int> arr)
        {
            arr.Sort();
            int middle = arr.Count() / 2;
            return arr[middle];

        }
    }
}
