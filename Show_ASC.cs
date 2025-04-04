using System;

namespace ASC_Desing_2
{
    public class Show_ASC
    {
        public Show_ASC()
        {
            //Displaying the ASCII Art CAA
            Console.Title = "ASCII CAA";
            Console.ForegroundColor = ConsoleColor.Cyan;
            string title = @" 

                                                          .d8888b.        d8888       d8888 
                                                         d88P  Y88b      d88888      d88888 
                                                         888    888     d88P888     d88P888 
                                                         re0           d88P 888    d88P 888 
                                                         888          d88P  888   d88P  888 
                                                         888    888  d88P   888  d88P   888 
                                                         Y88b  d88P d8888888888 d8888888888 
                                                          ""Y8888P"" d88P     888dRE0     888 
                                                                                            
                                                                                            
                                                                                            
         ";

            Console.WriteLine(title);
            Console.ReadLine();

           
            //Displaying ASCII Art for Welcome message
            Console.Title = "ASCII Welcome";
            Console.ForegroundColor = ConsoleColor.Cyan;
            string Welcome = @"     


                                            888       888        888                                      
                                            888   o   888        888                                      
                                            888  d8b  888        888                                      
                                            888 d888b 888 .d88b. 888 .d8888b .d88b. 88888b.d88b.  .d88b.  
                                            888d88888b888d8P  Y8b888d88P""   d88""""88b888 ""888 ""88bd8P  Y8b 
                                            88888P Y8888888REO888888888     888  888888  888  8888REO88888 
                                            8888P   Y8888Y8b.    888Y88b.   Y88..88P888  888  888Y8b.     
                                            888P     Y888 ""Y8888 888 ""Y8888P ""Y88P"" 888  888  888 ""Y8888                  
             ";
            
            Console.WriteLine(Welcome);
            Console.ReadLine();

            //Clears the screen of ASC art
            Console.WriteLine("Press Enter to continue ask questions...");
            Console.ReadLine(); //Pauses the programe by waiting for enter key
            Console.Clear();  

            //Play beeping sound



            //Reset the console color to hwite
            Console.ForegroundColor = ConsoleColor.White;
        }

       
    }
}