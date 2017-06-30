//https://www.hackerrank.com/challenges/day-of-the-programmer

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string solve(int year){
        // Complete this function
        int date = 13;
        if(year < 1918){
            if(year%4 == 0) date--;
        }
        else if(year > 1918){
            if((year%400 == 0)||((year%4 == 0)&&(year%100 != 0))) date--;
        }
        else {
            date+=13;
        }
        return String.Format("{0}.09.{1}",date,year);
    }

    static void Main(String[] args) {
        int year = Convert.ToInt32(Console.ReadLine());
        string result = solve(year);
        Console.WriteLine(result);
    }
}
