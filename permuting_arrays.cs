//https://www.hackerrank.com/challenges/two-arrays/problem
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t0 = Convert.ToInt32(Console.ReadLine());
        for(int t=0;t<t0;t++){
            int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),Convert.ToInt32);
            int n = input[0], k= input[1];
            int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),Convert.ToInt32);
            int[] b = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),Convert.ToInt32);
            Array.Sort(a);
            Array.Sort(b);
            bool flag = false;
            for(int i=0,j=n-1;i<n&&j>=0;i++,j--){
                if(a[i]+b[j]<k){
                    Console.WriteLine("NO");
                    flag = true;
                    break;
                }
            }
            if(!flag)
                Console.WriteLine("YES");
        }
    }
}
