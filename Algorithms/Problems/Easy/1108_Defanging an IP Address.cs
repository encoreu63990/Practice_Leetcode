using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/defanging-an-ip-address/
    /// 
    /// Case 1:
    /// Input: address = "1.1.1.1"
    /// Output: "1[.]1[.]1[.]1"
    /// 
    /// Case 2:
    /// Input: address = "255.100.50.0"
    /// Output: "255[.]100[.]50[.]0"
    /// 
    /// </summary>
    public class _1108_Defanging_an_IP_Address
    {
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}
