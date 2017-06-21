//https://www.hackerrank.com/contests/hw1/challenges/merge-sort
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> lst = new List<int>();
        int[] input;
        do {
            lst.AddRange(Array.ConvertAll(Console.ReadLine().Trim().Split(' '),Convert.ToInt32));
        }while(lst.Count < n);
        input = lst.ToArray();
        MergeSort(input,0,n-1);
        StringBuilder sb = new StringBuilder();
        sb.Append("[");
        foreach(var i in input){
            sb.Append(i+",");
        }
        sb.Length--;
        sb.Append("]");
        Console.WriteLine(sb.ToString());
    }
    
    static void MergeSort(int[] a, int low, int high){
        if(low>=high) return;
        int mid = (low+high)/2;
        MergeSort(a,low,mid);
        MergeSort(a,mid+1,high);
        Merge(a,low,mid,high);
    }
    
    static void Merge(int[] a, int low, int mid, int high){
        int m = mid-low+1, n = high-mid;
        int[] left = new int[m];
        int[] right = new int[n];
        int k = 0;
        for(int i=low;i<=mid;i++){
            left[k++] = a[i];
        }
        
        k = 0;
        for(int i=mid+1;i<=high;i++){
            right[k++] = a[i];
        }
        
        int l=0,r=0;
        while(l<m && r<n){
            if(left[l]<right[r]){
                a[low++] = left[l++];
            }
            else{
                a[low++] = right[r++];
            }
        }
        while (l<m){
            a[low++] = left[l++];
        }
        while(r<n){
            a[low++] = right[r++];
        }
    }
}
