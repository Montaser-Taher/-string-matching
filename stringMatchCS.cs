using System;

/*
* Note: Upon compilation of this C-Sharp program, the compiler will generate an executable file (.exe) just be sure to run "csc" and then 
* "name_of_file.exe" in the command prompt.
*
*/ 
namespace StringMatching
{
    class Program
    {
      static void Main(string[] args){

          Console.WriteLine("Enter a long text with letters");
          string text = Console.ReadLine();
          Console.WriteLine("Enter a pattern to find in your text");
          string pattern = Console.ReadLine();
          StringMatch(text, pattern);

      }

      static void StringMatch(string text, string pattern){ // Naive-Algorithm
        int count = 0; // Pattern Index 

        for(int i = 0; i < text.Length ; i++){ // Iterate through text
          Console.WriteLine($"Starting at index {i}");

           while(count < pattern.Length){ // While not all of the pattern is compared. 
            
              if(text[i + count] == pattern[count]){ // Compare Nth letter of text to Nth letter of pattern
                Console.WriteLine($"Letter {text[i + count]} matches with Pattern {pattern[count]}");
                count++; //move on to N+1           

                if(count == i){
                  Console.WriteLine("Pattern found at Index " + (count - i));
                }

              }else{
                Console.WriteLine("No Match");
                count = 0; // Initial word doesn't match, reset counter and move to the next letter of the text
                break;
              }
           }
        }


      }
    }



}