using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2016_03_22
{
    public class EnterOnce

        
    { public static string userInput;
        
        public void   UsersInput()
           
        {   
            Console.WriteLine("Choose your words carefully.\nGive me a new word.(or q to quit)>\n");
            string usersInput = Console.ReadLine();
            
            

        }


        public List<string> wordsList = new List<string>();
        public void PutitontheList()
        {
                        
            string start = "     ";
            
            wordsList.Add(start);
            UsersInput();
                       
           
            for (int newWord = 0; newWord < wordsList.Count ; newWord++)
            {

                if (wordsList.Contains(userInput)) 
                {
                    Console.WriteLine("You already inputed that word! Try Again.\n");

                    UsersInput();
                    
                }
                else
                {
                    wordsList.Add(userInput);
                    UsersInput();
                }
                
            }
        }
       
        
    }
}
