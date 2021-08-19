using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/design-an-ordered-stream/
    /// </summary>
    class _1656_Design_an_Ordered_Stream
    {
        public class OrderedStream
        {
            string[] _array = null;
            int counter;

            public OrderedStream(int n)
            {
                _array = new string[n + 1];
                counter = 1;
            }

            public IList<string> Insert(int idKey, string value)
            {
                _array[idKey] = value;
                var result = new List<string>();

                while (_array[counter] != null)
                    result.Add(_array[counter++]);

                return result;
            }
        }
    }
}
