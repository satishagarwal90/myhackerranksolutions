//https://www.hackerrank.com/challenges/palindrome-index/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int palindromeIndex(string s){
        // Complete this function
        int n = s.Length;
        int result = -1;
        for(int i=0,j=n-1;i<n/2;i++,j--){
            if(s[i] != s[j]){
                string a = s.Substring(i,(j-i));
                string b = s.Substring(i+1,(j-i));
                if(checkpalindrome(a))
                    result = j;
                else if(checkpalindrome(b))
                    result = i;
                break;
            }
        }
        return result;
    }
    
    static bool checkpalindrome(string a){
        char[] temp = a.ToCharArray();
        Array.Reverse(temp);
        return a == new string(temp);
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            int result = palindromeIndex(s);
            Console.WriteLine(result);
        }
    }
}
