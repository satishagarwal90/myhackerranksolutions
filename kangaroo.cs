//https://www.hackerrank.com/challenges/kangaroo

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string kangaroo(int x1, int v1, int x2, int v2) {
        // Complete this function
        string result = "NO";
        if(x1==x2 && v1==v2)
            result = "YES";
        else if(x1<x2 && v1>v2 && ((x2-x1)%(v1-v2) == 0)){            
            result = "YES";   
        }            
        else if(x1>x2 && v2> v1 && ((x1-x2)%(v2-v1)==0)){
            result = "YES";   
        }
        return result;
    }

    static void Main(String[] args) {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        string result = kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
    }
}
