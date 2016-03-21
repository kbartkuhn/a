using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    public class RotateNumber
    {

        public void Rotate()
        {
            List<int> changespot = new List<int>();
            changespot.Add(1);
            changespot.Add(2);
            changespot.Add(3);


            for (int i = 0; i < changespot.Count; i++)
            {


                changespot.Add(changespot[0]);
                changespot.RemoveAt(0);
                changespot.Insert(1, 2);
                changespot.RemoveAt(1);
                changespot.Insert(2, 1);
                changespot.RemoveAt(2);
                i += 5;
            }
            foreach (int item in changespot)
            {
                Console.WriteLine(item + 5);
            }
            
        }

    }
}
