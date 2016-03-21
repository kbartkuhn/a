using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
   public class BMO
    {

        public void GetInstruction(string Instruction)
        {
            Console.WriteLine(Instruction);

        }
        ///Up, Down, Left, Left, Right, Right, Down, Spin, Down, Up, Left, Right, Left, Down, Spin, Up, Down, Jump.

        public void DisplayIntruction ()
        {
            GetInstruction("Up");
            GetInstruction("Down");
            GetInstruction("Left");
            GetInstruction("Left");
            GetInstruction("Right");
            GetInstruction("Right");
            GetInstruction("Down");
            GetInstruction("Spin");
            GetInstruction("Down");
            GetInstruction("Up");
            GetInstruction("Left");
            GetInstruction("Right");
            GetInstruction("Left");
            GetInstruction("Down");
            GetInstruction("Spin");
            GetInstruction("UP");
            GetInstruction("Down");
            GetInstruction("Jump");
        }
    }
}
