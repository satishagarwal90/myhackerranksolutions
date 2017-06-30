//https://www.hackerrank.com/challenges/migratory-birds

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int migratoryBirds(int n, int[] ar) {
        // Complete this function
        int[] hash = new int[6];
        int max = 0;
        foreach(var item in ar){
            hash[item]++;
            if(hash[item] > hash[max]) max = item;
            else if(hash[item] == hash[max] && max > item) max = item;
        }
        return max;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
    }
}
