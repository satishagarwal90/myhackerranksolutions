//https://www.hackerrank.com/challenges/breaking-best-and-worst-records

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] getRecord(int[] s){
        // Complete this function
        int n = s.Length;
        int[] result = new int[2];
        int max = s[0], min = s[0];
        for(int i=1;i<n;i++){
            if(s[i]<min){
                result[1]++;
                min = s[i];
            }
            else if(s[i]>max){
                max = s[i];
                result[0]++;
            }
        }
        return result;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        int[] result = getRecord(s);
        Console.WriteLine(String.Join(" ", result));
    }
}
