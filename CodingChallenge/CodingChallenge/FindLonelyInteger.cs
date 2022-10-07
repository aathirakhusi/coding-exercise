using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge
{
    public class FindLonelyInteger
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 1,1,2,3,2,3,4};
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int i in list)
            {
                if(dict.ContainsKey(i))
                {
                    dict[i] = dict[i]+1;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }
            Console.WriteLine(dict.OrderBy(x => x.Value).First().Key);

        }
       
    }
}
