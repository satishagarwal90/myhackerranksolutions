//https://www.hackerrank.com/challenges/no-prefix-set

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        Trie root = new Trie();
        for(int i=0;i<n;i++){
            string key = Console.ReadLine();
            if(!root.AddWord(root,key)){
                Console.WriteLine("BAD SET");
                Console.WriteLine(key);
                return;
            }
        }
        Console.WriteLine("GOOD SET");
    }
}

class Trie{
    public int words;
    public int prefixes;
    public Trie[] edges;
    
    public Trie(){
        edges = new Trie[10];
    }
    
    public bool AddWord(Trie vertex, string word){
        if(string.IsNullOrEmpty(word)){
            if(vertex.words == 0 && vertex.prefixes == 0){
                vertex.words++;
                return true;
            }
            else{
                return false;
            }            
        }            
        else {
            if(vertex.words > 0) return false;
            vertex.prefixes++;
            char k = word.Substring(0,1)[0];
            if(vertex.edges[k-'a'] == null){
                vertex.edges[k-'a'] = new Trie();
            }
            word = word.Substring(1);
            return AddWord(vertex.edges[k-'a'],word);
        }
    }
}
