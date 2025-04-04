using System;
using System.IO;
using System.Drawing;
using System.Net.Http.Headers;

namespace ASC_Desing_2
{
    public class logo_Display
    {
        //Constructor
        public logo_Display()
        {
            //Get the full location of the project
            string full_location = AppDomain.CurrentDomain.BaseDirectory;

            //replace the bin\Debug folder in the full_location
            string new_location = full_location.Replace("bin\\Debug\\", "");


            //Combine the path
            string new_path = Path.Combine(new_location, "logoo.jpg");

            //Using the ASCII

            //Creating the BitMap class
            Bitmap image = new Bitmap(new_path);

            //Set the size of the image  
            image = new Bitmap(image, new Size(50, 120));

            //outer and inner loop
            for (int height = 0; height < image.Height; height++)
            {

                //inner loop
                for (int width = 0; width < image.Width; width++)
                {
                    Color pixelColor = image.GetPixel(width, height);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    char asciiChar = gray > 200 ? '.' : gray > 150 ? '*' : gray > 100 ? 'o' : gray > 50 ? '#' : '0';
                    Console.Write(asciiChar);



                }

                Console.WriteLine();

            }//End of outer loop


        }//End of Constructor

    }//End of class

}//End of namespace