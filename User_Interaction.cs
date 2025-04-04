using System.Collections;
using System;

namespace ASC_Desing_2
{
    public class User_Interaction
    {
        public User_Interaction()
        {

            //Try Filtering in here
            //Declaration and array declatartin
            ArrayList Questions = new ArrayList();
            ArrayList ignore = new ArrayList();


            //Add and then Store in the array List
            Questions.Add("A password should be at least 12 characters long (ideally 16 characters or more); our password-related research has found that 45 percent of Americans use passwords of eight characters or less, which are not as secure as longer passwords..");
            Questions.Add("phishing is when criminals use scam emails, text messages or phone calls to trick their victims. The aim is often to make you visit a website, which may download a virus onto your computer, or steal bank details or other personal information.");
            Questions.Add("When browsing the internet take care to make sure that the site that you are on is secure. \r\nTake note to check for \"https://\" with particular care to the \"s\" as that will mean that site is \"secure\". \r\n\r\nSome web browsers will also display the icons below to help you determine whether or not a site is secure.\r\nTo check a site's security, to the left of the web address, look at the security status:");
            Questions.Add("cybercrime encompasses a wide range of criminal activities that are carried out using digital devices and/or networks. These crimes involve the use of technology to commit fraud, identity theft, data breaches, computer viruses, scams, and expanded upon in other malicious acts.");
            Questions.Add("cybersecurity is the application of technologies, processes and controls to protect systems, networks, programs, devices and data from cyber attacks.\r\n\r\nIt aims to reduce the risk of cyber attacks and protect against the unauthorised exploitation of systems, networks and technologies.");

            ignore.Add("tell");
            ignore.Add("me");
            ignore.Add("about");


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[ CAA ] : ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please enter your question or type 'exit' to quit:");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("[ User ] : ");
                Console.ForegroundColor = ConsoleColor.White;
                string ask = Console.ReadLine();

                if (ask.ToLower() == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[ CAA ] : Goodbye!");
                    break;
                }




                //Split the question and store in 1D array
                string[] filtered_question = ask.Split(' ');
                ArrayList correct_filtered = new ArrayList();


                //Display using the for loop
                //as it search it should filter more
                Boolean found = false;

                for (int count = 0; count < filtered_question.Length; count++)
                {
                    //Final Filter
                    if (!ignore.Contains(filtered_question[count]))
                    {
                        //Assign to true
                        found = true;

                        //Add the value to correct filtered
                        correct_filtered.Add(filtered_question[count]);


                    }


                }

                //Check if found 
                if (found)
                {
                    //loop to show user answers
                    for (int counting = 0; counting < correct_filtered.Count; counting++)
                    {
                        //Display Answer
                        for (int count = 0; count < Questions.Count; count++)
                        {
                            //Final Display
                            if (Questions[count].ToString().Contains(correct_filtered[counting].ToString()))
                            {
                                //output
                                Console.WriteLine(Questions[count].ToString());

                            }

                        }

                    }

                }
                else
                {
                    Console.WriteLine("Please search something.");
                }

            }
        }
    }
}