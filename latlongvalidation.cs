//https://www.hackerrank.com/challenges/detecting-valid-latitude-and-longitude

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t0 = Convert.ToInt32(Console.ReadLine());
        Regex lat = new Regex(@"\([+-]?[1-9][0-9]*([.]?\d+)?,");
        Regex lon = new Regex(@"\s[+-]?[1-9][0-9]*([.]?\d+)?\)");
        for(int t=0;t<t0;t++){
            string s = Console.ReadLine();
            Match mLat = lat.Match(s);
            Match mLon = lon.Match(s);
            if(mLat.Success && mLon.Success){
                float latf = Convert.ToSingle(Regex.Match(s,@"\d+([.]?\d+)?,").Value.Trim(','));
                float lonf = Convert.ToSingle(Regex.Match(s,@"\d+([.]?\d+)?\)").Value.Trim(')'));
                if(latf <= 90.0 && lonf <= 180.0)
                    Console.WriteLine("Valid");
                else
                    Console.WriteLine("Invalid");
            }
            else{
                Console.WriteLine("Invalid");
            }
        }
    }
}
