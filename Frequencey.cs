using System;
using System.Collections.Generic;
namespace Freaquency{
   public class Word{
      public static void Main(String[] args){
        Console.WriteLine("Enter a string");
     string word =  Console.ReadLine().ToLower();
     Console.WriteLine("Enter the character to find the frequency");
     char target=Char.ToLower(Console.ReadKey().KeyChar);
     Console.WriteLine();
     int freq=0;
     foreach(char c in word){
         if(c==target){
            freq++;
         }
     }
     Console.WriteLine($"The character {target} appears {freq} times");

      }  
    }
}