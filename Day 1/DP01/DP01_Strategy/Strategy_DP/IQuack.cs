using System;
using System.Collections.Generic;
using System.Text;

namespace DP01_Strategy.Strategy_DP
{
    public abstract class Quack
    {
        public abstract void PerformQuack();
    }

    public class NormalQuack : Quack
    {
        public override void PerformQuack()
        {
            Console.WriteLine("Quacking");
            Console.Beep();
        }
    }

    public class Sqeek : Quack
    {
        public override void PerformQuack()
        {
            Console.WriteLine("Sqeeeeeek");
            Console.Beep(32767, 1500);
        }
    }
}
