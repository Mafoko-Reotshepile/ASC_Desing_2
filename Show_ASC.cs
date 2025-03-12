using System;

namespace ASC_Desing_2
{
    public class Show_ASC
    {
        public Show_ASC()
        {
            Console.Title = "ASCII Art";
            Console.ForegroundColor = ConsoleColor.Cyan;
            string title = @" 

                                                          .d8888b.        d8888       d8888 
                                                         d88P  Y88b      d88888      d88888 
                                                         888    888     d88P888     d88P888 
                                                         888           d88P 888    d88P 888 
                                                         888          d88P  888   d88P  888 
                                                         888    888  d88P   888  d88P   888 
                                                         Y88b  d88P d8888888888 d8888888888 
                                                          ""Y8888P"" d88P     888d88P     888 
                                                                                            
                                                                                            
                                                                                            
         ";

            Console.WriteLine(title);
            Console.Read();


        }

        //Add method to Display welcome message
    }
}