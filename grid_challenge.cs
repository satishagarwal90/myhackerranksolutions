//https://www.hackerrank.com/challenges/grid-challenge
//using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t0 = Convert.ToInt32(Console.ReadLine());
        for(int t=0;t<t0;t++){
            int n = Convert.ToInt32(Console.ReadLine());
            string[] input = new string[n];
            for(int i=0;i<n;i++){
                input[i] = String.Concat(Console.ReadLine().OrderBy(c=>c));
            }
            bool flag = true;
            for(int i=0;i<n-1 && flag;i++){
                for(int j=0;j<n;j++){
                    if(input[i][j]-'a' > input[i+1][j]-'a'){
                        Console.WriteLine("NO");
                        flag = false;
                        break;
                    }
                }
            }
            if(flag)
                Console.WriteLine("YES");
        }
    }
}
