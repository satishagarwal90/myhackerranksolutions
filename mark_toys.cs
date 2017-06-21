//https://www.hackerrank.com/challenges/mark-and-toys
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),Convert.ToInt32);
        int n = input[0], k = input[1];
        List<int> lst = new List<int>();
        lst.AddRange(Array.ConvertAll(Console.ReadLine().Trim().Split(' '),Convert.ToInt32));
        lst.Sort();
        int count = 0;
        for(int i=0;i<n;i++){
            if(k-lst[i] < 0)
                break;
            else{
                k-=lst[i];
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
