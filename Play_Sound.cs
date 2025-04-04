namespace ASC_Desing_2
{
    using System.Media;
    using System;
    using System.IO;

    public class Play_Sound
    {
        public Play_Sound()
        {

            //getting the full location of the project
            string full_location = AppDomain.CurrentDomain.BaseDirectory;
            //Console.WriteLine(full_location);

            //replace the bin\Debug folder in the full_location
            string new_path = full_location.Replace("bin\\Debug\\", "");

            //Try and catch 

            try
            {
                string full_Path = Path.Combine(new_path, "greeting.wav");

                //Creating instance for the SoundPlay class
                using (SoundPlayer play = new SoundPlayer(full_Path))
                {
                    play.PlaySync();
                }

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

        }
    }
}