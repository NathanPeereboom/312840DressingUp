/*Nathan Peereboom
 *April 21, 2020
 *Problem J1: Dressing Up
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _312840DressingUp
{
    class Program
    {
        //Global variables
        static int h; //Height
        static int v; //Vertex (Value of i for which a is the greatest)
        static string tie = ""; //Bowtie printed to console

        static void Main(string[] args)
        {
            //Input
            Console.WriteLine("Enter Height");
            int.TryParse(Console.ReadLine(), out h);


            //Process
            v = (h - 1) / 2;
            for (int i = 0; i < h; i++)
            {
                string line = "";
                int a = -2 * Math.Abs(i - v) + h; //Number of asterics (per side)
                int s = (h - a) * 2; //Number of spaces (total)
                //Left side
                for (int j = 0; j < a; j++)
                {
                    line += "*";
                }
                //Center
                for (int j = 0; j < s; j++)
                {
                    line += " ";
                }
                //Right side
                for (int j = 0; j < a; j++)
                {
                    line += "*";
                }

                tie += line + Environment.NewLine;
            }

            //Output
            Console.Write(tie);

            //End program
            Console.ReadLine();
        }
    }
}
