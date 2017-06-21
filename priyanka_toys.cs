//https://www.hackerrank.com/challenges/priyanka-and-toys
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> input = new List<int>(n);
        input.AddRange(Array.ConvertAll(Console.ReadLine().Trim().Split(' '),Convert.ToInt32));
        input.Sort();
        int count=1, w=input[0]+4;
        for(int i=1;i<n;i++){
            if(input[i]>w){
                w=input[i]+4;
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
