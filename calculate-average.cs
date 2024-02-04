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

                Console.WriteLine($"Write the {i} number and write 'end' to finish:");
                
                do
                {
                    // Input of averages.

                    input = Console.ReadLine();
                    valid = double.TryParse(input, out nb);

                    if(input != "end")
                    {
                        if(!valid)
                        {
                            Console.WriteLine($"Not a number, write the {i} number:");  
                        }
                        else
                        {
                            i++;
                            sum += nb;
                            Console.WriteLine($"Write the {i} number:");
                        }
                    }
                    else if (i < 3)
                    {
                        Console.WriteLine($"There aren't enough numbers, write the {i} number:");
                    }
                } while(input != "end" || i < 3);

                // Calls the Function.

                CalculateAverage(sum, i);

                // Sentences to start over.

                Console.WriteLine("\nDo you want to do it all over again? [y or n]");
                again = Console.ReadLine();
            } while(again == "y");
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