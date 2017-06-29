//https://www.hackerrank.com/challenges/valid-pan-format

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Regex r = new Regex(@"[A-Z]{5}\d{4}[A-Z]");
        int t0 = Convert.ToInt32(Console.ReadLine());
        for(int t=0;t<t0;t++){
            if(r.IsMatch(Console.ReadLine()))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
