using System;
using System.Collections.Generic;
using System.Text;

namespace DP01_Strategy.No_DP
{
    public class RubberDuck : Duck
    {
        public override void Display() => Console.WriteLine("Rubber Duck");

        public new void Fly() => Console.WriteLine("No Wings to Fly");

        public new void Quack()
        {
            Console.WriteLine("Sqeeeeeek");
            Console.Beep(32767, 1500);
        }
    }
}
