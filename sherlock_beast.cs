//https://www.hackerrank.com/challenges/sherlock-and-the-beast
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            int fives = n, threes = 0;
            while(fives%3 != 0 && fives>0){
                threes += 5;
                fives-=5;
            }
            if(fives <0)
                Console.WriteLine(-1);
            else {
                StringBuilder sb = new StringBuilder();
                while(fives > 0){
                    sb.Append("5");
                    fives--;
                }
                while(threes > 0){
                    sb.Append("3");
                    threes--;
                }
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
