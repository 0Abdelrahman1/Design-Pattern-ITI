using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace DP01_Strategy.No_DP
{
    public abstract class Duck
    {
        public abstract void Display();
        public void Swim() => Console.WriteLine("Duck is Swimming ....");
        public void Fly() => Console.WriteLine("Fly Normal Speed");
        public void Quack()
        {
            Console.WriteLine("Quacking");
            Console.Beep();
        }

    }
}
