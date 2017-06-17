//https://www.hackerrank.com/challenges/anagram
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int anagram(string s){
        // Complete this function
        int n = s.Length;
        if(n%2 != 0) return -1;
        string a = s.Substring(0,n/2);
        string b = s.Substring(n/2,n/2);
        
        int[] hasha = new int[26];
        int[] hashb = new int[26];
        
        foreach(char c in a){
            hasha[c-'a']++;
        }
        foreach(char c in b){
            hashb[c-'a']++;
        }
        
        int count = 0;
        for(int i=0;i<26;i++){
            count+= Math.Abs(hasha[i]-hashb[i]);
        }
        return count/2;
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            int result = anagram(s);
            Console.WriteLine(result);
        }
    }
}
