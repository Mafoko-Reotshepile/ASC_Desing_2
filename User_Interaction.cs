using System.Collections;
using System;

namespace ASC_Desing_2
{
    internal class User_Interaction
    {
        public User_Interaction()
        {
            
            //Try Filtering in here
            //Declaration and array declatartin
            ArrayList Questions = new ArrayList();
            ArrayList ignore = new ArrayList();


            //Add and then Store in the array List
            Questions.Add("Password to be protected.");
            Questions.Add("What is a firewall");
            ignore.Add("tell");
            ignore.Add("me");
            ignore.Add("about");

            //Prompt usre to ask question
            Console.WriteLine("Enter your question");
            string ask = Console.ReadLine();

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