using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    public class Dance
    {
        public void ArmUp()
        {
            Console.WriteLine(@"    
                     *  * 
                   *      * 
                     *  *        * 
                       *      * 
                   *  *  * 
                 *    *     
               *      *       
                       * 
                   *      * 
                 *          * 
               *              * 
             *                  * 
           *                      * ");


        }
        public void ArmDown()
        {
            Console.WriteLine(@"    
                     *  * 
                   *      * 
                     *  *        
                       *      
                   *  *  * 
                 *    *     *
               *      *       *
                       * 
                   *      * 
                 *          * 
               *              * 
             *                  * 
           *                      * ");
        }

        public void Dancenstuff()
        {

            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Clear();
                    ArmUp();
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    ArmDown();
                    Console.ReadKey();
                }
            }

        }
    }
}

