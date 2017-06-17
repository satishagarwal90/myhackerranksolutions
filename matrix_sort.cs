using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int t0 = Convert.ToInt32(Console.ReadLine());
        for(int t = 0; t<t0;t++){
            int[] input0 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            int[] input1 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            int key = Convert.ToInt32(Console.ReadLine());
            int m = input0[0], n = input0[1], k=0;
            int[,] arr = new int[m,n];
            for(int i=0;i<m;i++){
                for(int j=0;j<n;j++){
                    arr[i,j] = input1[k++];
                }
            }
            int result = MatrixSort(arr,m,n,key);
            Console.WriteLine(result);
        }
    }
    
    static int MatrixSort(int[,] a, int m, int n, int key){
        int i=0, j=n-1;
        while(i<m && j>=0){
            if(a[i,j] == key) return 1;
            else if(a[i,j] < key){
                i++;
            }
            else
                j--;
        }
        return 0;
    }
}
