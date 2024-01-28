using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) {
            double nb;
            bool valid;
            int i = 1;
            string input;
            double sum = 0;
            string sentence = $"Write the {i} number:";
            Console.WriteLine(sentence);

            do
            {
                input = Console.ReadLine();
                valid = double.TryParse(input, out nb);

                if(!valid)
                {
                    Console.WriteLine("Not a number, " + sentence);  
                }
                if(valid)
                {
                    i++;
                    sum += nb;
                    Console.WriteLine(sentence);
                }
            } while(input != "end");

            Console.Clear();

            int nbDivise = i - 1;
            double average = sum / nbDivise;
            Console.WriteLine("Average is: " + average);

        }
    }
}