using System;

namespace dice
{
    class Program
    {
        static void Main(string[] args)

        {
            Random rng = new Random();
            bool running = true;

            while(running)
            {
            Console.Clear();
            Console.WriteLine("Give me a value:");
            //string of provided dice ex:'1d6'
            string strDice = Console.ReadLine();

#region Bad Solution...
            //values to save integers for rolling
            //int numberOfDice = 0;
            // int sidesOfDice = 0;
            //attempt to convert strings to integers
            //                                                          creates new integer numberOfDice
            // bool numberSuccess = Int32.TryParse(strDice[0].ToString(), out int numberOfDice);
            //                                                          sets value of sidesOfDice
            // bool sidesSuccess = Int32.TryParse(strDice.Substring(2), out sidesOfDice);
            //if both succeeded
#endregion
            //improved solution
            /// strDice = "13d89"
            // valuesArray = ["13", "89"]
            string[] valuesArray = strDice.ToLower().Split('d');
            bool numberSuccess = Int32.TryParse(valuesArray[0], out int numberOfDice);
            bool sidesSuccess = Int32.TryParse(valuesArray[1], out int sidesOfDice);


            
            if (numberSuccess && sidesSuccess)
            {
                Console.Clear();
                System.Console.WriteLine("rolling" + strDice);
                
                int total = 0; 
                for(int i = 0; i < numberOfDice; i++)
                {
                    int roll = rng.Next(1, sidesOfDice +1);
                    System.Console.WriteLine(roll);
                    total += roll;
                }

                System.Console.WriteLine("total:" + total);
                }
                else
                {
                    System.Console.WriteLine("thats no dice");
                }
                System.Console.WriteLine("Again? (Press 'q' to quit or any key to continue)");
                ConsoleKeyInfo choice = Console.ReadKey();
                if(choice.KeyChar == 'q')
                {
                    running = false;
                }
            }
            Console.Clear();
            System.Console.WriteLine("Fine Leave");
        }
    }
}