using System;
using System.Linq;

//Program takes a sentence and returns the most frequently occuring letter in the string

//Note for future development:
//        - account for if there are multiple highest frequency letters 

namespace programmingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a sentence: ");
            string sentence = Console.ReadLine();
            mostFrequentNumber(sentence);
        }



        static void mostFrequentNumber(string sentence)
        {
            int highestCount = 0;
            string highestLetter = "a"; 

            sentence = sentence.Replace(" ", ""); //strip sentence of spaces
            char[] charArray = sentence.ToArray(); 
            Array.Sort(charArray); //re-orders sentence alphabetically a->z

            string currentLetter = "a";
            int currentCount = 0;


            for(int i=0; i < charArray.Length; i++) 
            {

                currentLetter = charArray[i].ToString();
                currentCount++; //counting appearances of each character

                if (i + 1 >= charArray.Length) {
                        //Checks if next letter is end of array, or out of bounds 
                    if (currentCount > highestCount)
                    {
                        highestCount = currentCount;
                        highestLetter = currentLetter;
  
                    }
                    currentCount = 0; //reset for next letter
                }
                else if(i + 1 < charArray.Length)
                {
                    if (charArray[i] != charArray[i + 1]) //checks if next char in array is different letter
                    {
                        if (currentCount > highestCount)
                        {
                            highestCount = currentCount;
                            highestLetter = currentLetter; 

                        }
                        currentCount = 0; //reset for next letter

                    }
                }
            }

            
            if (highestCount == 1)
            {
                Console.WriteLine("All letters appear only once");
            }
            else
            {
                Console.WriteLine("The most frequent letter is " + highestLetter + ", appearing " + highestCount.ToString() + " times.");
            }

        }
    }
}

