using System;
using System.Collections;

namespace ASC_Desing_2
{
    public class User_Input
    {
        public User_Input()
        {
            

            //Change color for CAA to red
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[ CAA ] :");
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" What is your name? ");


            //Creating a string variable to store name form user input
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[ User ] :");
            Console.ForegroundColor = ConsoleColor.White;   
            String Name = Console.ReadLine();
             
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[ CAA ] :");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello  " + Name);

            String A = Console.ReadLine();


        }
    }
}