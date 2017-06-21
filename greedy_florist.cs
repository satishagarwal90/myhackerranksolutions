//https://www.hackerrank.com/challenges/greedy-florist
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int getMinimumCost(int n, int k, int[] c){
        // Complete this function
        Array.Sort(c);
        int x = 0, cost = 0;
        for(int i=n-1,y=0;i>=0;i--,y++){
            cost+= (x+1)*c[i];
            if((y+1)%k == 0)
                x++;
        }
        return cost;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);
        int minimumCost = getMinimumCost(n, k, c);
        Console.WriteLine(minimumCost);
    }
}
