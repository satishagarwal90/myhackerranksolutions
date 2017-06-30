//https://www.hackerrank.com/challenges/between-two-sets

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int getTotalX(int[] a, int[] b){
        // Complete this function
        int n = a.Length, lcm = a[0];
        for(int i=1;i<n;i++){
            lcm = CalculateLCM(lcm,a[i]); 
        }        
        
        int count = 0;
        for(int i=lcm;i<=100;i+=lcm){
            bool flag = false;
            foreach(var value in b){
                if(value%i != 0)
                    flag = true;
            }
            if(!flag) count++;
        }
        return count;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp,Int32.Parse);
        int total = getTotalX(a, b);
        Console.WriteLine(total);
    }
    
    static int CalculateLCM(int a, int b){
        return (a*b)/CalculateHCF(a,b);
    }
    
    static int CalculateHCF(int a, int b){
        if(b == 0) return a;
        else return CalculateHCF(b,a%b);
    }
}
