using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2016_03_22
{
    public class ShapMaker
    {
        public int ListSize = 4;
        public string userInput;
        public List<List<string>> OuterList = new List<List<string>>();
        public List<string> InnerList = new List<string>();


        public void MakeShape()
        {

            OuterList.Add(InnerList);            
            

            for (int index = 0; index < ListSize -1 ; index++)
            {
                OuterList.Add(new List<string>(ListSize));

                for (int innerIndex = 0; innerIndex < ListSize ; innerIndex++)
                {
                    OuterList[index].Add(".");

                }
                
            }
            foreach (List<string> outerList in OuterList)
            {
                Console.WriteLine();
                foreach (string innerList in InnerList)
                {
                    Console.Write(innerList);
                                       
                }
            }
            Console.ReadKey();
        }

        
        public void MakeTriangle()
        {
            OuterList.Add(InnerList);


            for (int index = 0; index < ListSize - 1; index++)
            {
                OuterList.Add(new List<string>(ListSize));

                for (int innerIndex = 0; innerIndex < ListSize; innerIndex++)
                {
                    OuterList[index].Add(".");

                }

            }
            foreach (List<string> outerList in OuterList)
            {
                Console.WriteLine();
                foreach (string innerList in InnerList)
                {
                    Console.Write(innerList);
                    Console.ReadKey();

                }
            }
        }


        
    }
}
