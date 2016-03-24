using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2016_03_22
{
    class Program
    {
        static void Main(string[] args)
        {   // Working
            // OnlyOnceEntered startGame = new OnlyOnceEntered();
            // startGame.PutitontheList();


            /*  Not Working
            EnterOnce enterYourWords = new EnterOnce();
            enterYourWords.PutitontheList();
            */

            ShapMaker makeShape = new ShapMaker();
            makeShape.MakeShape();
        }
    }
}
