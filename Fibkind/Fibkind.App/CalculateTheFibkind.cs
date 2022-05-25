using System;
using System.Collections.Generic;

namespace Fibkind.App
{
    public class CalculateTheFibkind : ICalculateTheFibkind
    {
        private List<int> ListToReturn = new List<int>();
        private int[] ArrayOfU_I(int n)
        {
            ListToReturn.Add(1);
            ListToReturn.Add(1);

            for (int i = 2; i < n; i++)
            {
                var value1 = i - ListToReturn[i - 1];
                var value2 = i - ListToReturn[i - 2];

                ListToReturn.Add(ListToReturn[value1] + ListToReturn[value2]);
            }
            return ListToReturn.ToArray();
        }

        public long LengthSupUK(int n, int k)
        {
            var count = 0;
            foreach (var integer in ArrayOfU_I(n))
            {
                if(integer >= k)
                {
                    count += 1;
                }
            }
            return count;
        }

        public long Comp(int n)
        {
            var array = ArrayOfU_I(n);
            var count = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if(array[i] < array[i-1])
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
