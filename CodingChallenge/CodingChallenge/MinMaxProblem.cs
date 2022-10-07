using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge
{
    public class MinMaxProblem
    {
        public static void MinMaxPblm(string[] args)
        {

            List<int> arr = new List<int> { 1,2,3,4,5};

            Result.miniMaxSum(arr);
        }
    }
    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
            long sum = 0;
            int min = arr[0];
            int max = arr[0];
            for(int i =0;i<arr.Count;i++)
            {
                sum=sum+arr[i];
                if (arr[i]<min)
                {
                    min=arr[i];
                }
                if(arr[i]>max)
                {
                    max=arr[i];
                }

            }
            Console.WriteLine($"{sum-max} {sum-min}");

        }

    }
}
        