using System;

namespace MyCompiler 
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            // input to start over.

            string again;
            
            do {
                double nb;
                bool valid;
                string input;
                double sum = 0;
                int i = 1;

                Console.WriteLine($"Write the {i} number 'and' write end to finish.");
                
                do
                {
                    // Input of averages

                    input = Console.ReadLine();
                    valid = double.TryParse(input, out nb);

                    if(input != "end")
                    {
                        if(!valid)
                        {
                            Console.WriteLine($"Not a number, Write the {i} number:");  
                        }
                        else
                        {
                            i++;
                            sum += nb;
                            Console.WriteLine($"Write the {i} number:");
                        }
                    }
                } while(input != "end");

                // See if he's put in any average.

                if(i > 2)
                {
                    CalculateAverage(sum, i);
                }
                else 
                {
                    Console.WriteLine("\nThere is no number.");
                }

                // Sentences to start over.

                Console.WriteLine("\nDo you want to do it all over again? [y or n]");
                again = Console.ReadLine();
            }while(again == "y");
        }

        // function to calculate the average.

        static void CalculateAverage(double sum, int i)
        {
            int nbDivise = i - 1;
            double average = sum / nbDivise;
            Console.WriteLine("\n////////////// Average is: " + average + " //////////////");   
        }
    }
}