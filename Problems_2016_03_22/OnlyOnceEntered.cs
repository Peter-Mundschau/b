using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2016_03_22
{
    public class OnlyOnceEntered
    {
        public List<string> wordsList = new List<string>();
        public string userInput;


        bool running = true;
        public void PutitontheList()
        {
            string start = "     ";
            wordsList.Add(start);
            while (running)
            {



                for (int newWord = 0; newWord < wordsList.Count; newWord++)
                {
                    Console.WriteLine("Choose your words carefully.\nGive me a new word.(or q to quit)\n>>");
                    string userInput = Console.ReadLine();

                    {
                        if (userInput == "q")
                        {
                            running = false;
                            return;
                        }
                        else if (wordsList.Contains(userInput))
                        {
                            Console.Clear();
                            Console.WriteLine("BARK!!! You already inputed that word!\nTry Again.\n");

                        }
                        else
                        {
                            Console.Clear();
                            wordsList.Add(userInput);
                            Console.WriteLine("Good word.");
                        }

                    }
                }


            }


        }









    }

}
