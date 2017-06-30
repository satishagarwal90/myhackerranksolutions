//https://www.hackerrank.com/challenges/contacts

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t0 = Convert.ToInt32(Console.ReadLine());
        Trie root = new Trie();
        for(int t=0;t<t0;t++){
            string[] input = Console.ReadLine().Split(' ');
            string op = input[0], key=input[1];
            if(op == "add"){
                root.AddWord(root,key);
            }
            else{
                int count = root.CountPrefixes(root,key);
                Console.WriteLine(count);
            }
        }
    }
}

class Trie{
    public int words;
    public int prefixes;
    Trie[] edges;
    
    public Trie(){
        edges = new Trie[26];
    }
    
    public void AddWord(Trie vertex, string word){
        if(string.IsNullOrEmpty(word)){
            vertex.words++;
            vertex.prefixes++;
        }
        else {
            char k = word.Substring(0,1)[0];
            if(vertex.edges[k-'a'] == null){
                vertex.edges[k-'a'] = new Trie();
            }
            vertex.prefixes++;
            word = word.Substring(1);
            AddWord(vertex.edges[k-'a'],word);
        }
    }
    
    public int CountPrefixes(Trie vertex, string prefix){
        if(string.IsNullOrEmpty(prefix))
            return vertex.prefixes;
        else {
            char k = prefix.Substring(0,1)[0];
            if(vertex.edges[k-'a'] == null){
                return 0;
            }
            else{
                prefix = prefix.Substring(1);
                return CountPrefixes(vertex.edges[k-'a'], prefix);
            }
        }
    }
}
