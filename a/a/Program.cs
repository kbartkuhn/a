using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    public class Program
    {
        static void Main(string[] args)
        {
            //problem 1
            inputstring input = new inputstring();
            input.whatsthelength();
            Console.ReadLine();

            input.printThatStuff();
            Console.ReadLine();


            //problem 2
            showpi pi = new showpi();
            pi.showpie();
          

            //problem 3 
            BMO bmo = new BMO();
            bmo.DisplayIntruction();

            //problem 4 
            RotateNumber rotate = new RotateNumber();
            rotate.Rotate();

            //problem 5 
            Dance dance = new Dance();
            dance.Dancenstuff();

        }
    }
}
