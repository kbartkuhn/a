using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class inputstring
    {
        public void whatsthelength()
        {
            Console.WriteLine("Enter a word or string of characters ");
            string inputString = Console.ReadLine();
            Console.WriteLine(inputString.Length);
        }

        public List<int> superList()
        {
            List<int> listlength = new List<int>();
            listlength.Add(4);
            listlength.Add(6);
            listlength.Add(9);
            listlength.Add(13);
            return listlength;
        }
        public void printThatStuff()
        {
            Console.WriteLine("Length of list is: " + superList().Count);

        }
    }
}         