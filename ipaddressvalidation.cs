//https://www.hackerrank.com/challenges/ip-address-validation

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t0 = Convert.ToInt32(Console.ReadLine());
        Regex r4 = new Regex(@"^([0-2]?[0-9]?[0-9]\.){3}([0-2]?[0-9]?[0-9]){1}$");
        Regex r6 = new Regex(@"^([0-9a-f]{1,4}:){7}[0-9a-f]{1,4}$");
        for(int t=0;t<t0;t++){
            string s = Console.ReadLine();
            if(r4.IsMatch(s))
                Console.WriteLine("IPv4");
            else if(r6.IsMatch(s))
                Console.WriteLine("IPv6");
            else
                Console.WriteLine("Neither");
        }
    }
}
