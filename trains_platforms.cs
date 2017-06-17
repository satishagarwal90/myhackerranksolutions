//https://www.hackerrank.com/contests/kilobyte-uz-contest1/challenges/trains-and-platforms
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        List<train> input = new List<train>();
        for(int i=0;i<n;i++){
            int[] temp = Array.ConvertAll(Console.ReadLine().Trim().Split(' '),Convert.ToInt32);
            input.Add(new train(temp[0],true));
            input.Add(new train(temp[1],false));
        }
        input.Sort();
        int count = 0, maxcount = 0;
        foreach(train t in input){
            if(t.isarrival){
                count++;
                if(count > maxcount) maxcount = count;
            }
            else{
                count--;
            }
        }
        Console.WriteLine(maxcount);
    }
}

class train : IComparable<train> {
    public int time;
    public bool isarrival;
    
    public train(int time, bool isarrival){
        this.time = time;
        this.isarrival = isarrival;
    }
    
    public int CompareTo(train other){
        if(this.time > other.time) return 1;
        else if(this.time < other.time) return -1;
        else return 0;
    }
}
