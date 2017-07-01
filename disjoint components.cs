//https://www.hackerrank.com/challenges/components-in-graph

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        DisjointSet ds = new DisjointSet(n);
        for(int i=0;i<n;i++){
            int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),Convert.ToInt32);
            ds.Union(input[0],input[1]);
        }
        int size = (2*n)+1;
        int[] result = new int[size];
        for(int i=1;i<=2*n;i++){
            int x = ds.Find(i);
            if(x!= i)
                result[x]++;
        }
        //find min and max of result;
        int min = 0, max = 0;
        for(int i=1;i<=2*n;i++){
            if((result[i]!= 0) && (min>result[i])||(min==0))
                min = result[i];
            if(max<result[i])
                max = result[i];
        }
        min++;max++;
        Console.WriteLine(min+" "+max);
    }
}

class DisjointSet{
    public int[] parent;
    
    public DisjointSet(int size){
        int j = size*2;
        parent = new int[j+1];
        for(int i=1;i<=j;i++){
            parent[i] = -1;
        }
    }
    
    public int Find(int u){
        if(parent[u] == -1)
            return u;
        return Find(parent[u]);
    }
    
    public void Union(int u, int v){
        int x = Find(u);
        int y = Find(v);
        if(x==y) return;
        else parent[x] = y;
    }
}
