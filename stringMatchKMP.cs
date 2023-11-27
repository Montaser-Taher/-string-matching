using System;
using System.Diagnostics;
using System.Collections.Generic;
// https://www.youtube.com/watch?v=5i7oKodCRJo Explanation of KMP algorithm


namespace StringMatchingKMP{

    class Program{

        static void Main(string[] args){
          // Console.WriteLine("Enter a long text with letters");
          // string text = Console.ReadLine();
          Console.WriteLine("Enter a pattern to find in your text");
          string pattern = Console.ReadLine();
          PrefixSuffixLookup(pattern);
        }
        
        
        
        static List<int> PrefixSuffixLookup(string pattern){
         
          int patLength = pattern.Length; // Pattern Length

          List<int> lps = new List<int>(); // LPS list 
          
          for(int i = 0; i < patLength ; i++){ // Progessively increment through each character (e.g; A,AB,ABC....ABCDEF)


            string tempPat = pattern.Substring(0, i + 1); // Create new string up to index of pattern each iteration

 
            List<string> prefix = new List<string>(); // Temporary Prefix List
            List<string> suffix = new List<string>(); // Temporary Suffix List
            




            for(int j = 0; j < tempPat.Length; j++ ){ // Create Prefix of pattern
                prefix.Add(tempPat.Substring(0, j)); // Start from index 0, till but exclusive nth index
 
            }
 
  
            for(int k = tempPat.Length; k > 0; k--){ // Create Suffix of pattern 
                suffix.Add(tempPat.Substring(k)); // start from index N, down till but exclusive 0th index
 
            }


            Console.WriteLine("Prefix - [" + string.Join(",", prefix) + "]");
            Console.WriteLine("Suffix - [" + string.Join(",", suffix) + "]");

            
            foreach(string pElement in prefix){ // Find common suffixes and prefixes within each other
                if(suffix.Contains(pElement)){ // if prefix element is in suffix list
                    lps.Add(pElement.Length); // add prefix element length to lps list
                }
            }
          }

          Console.WriteLine("[ " + string.Join(",", lps) + "]"); 
          return lps;
        }


 



      }

}