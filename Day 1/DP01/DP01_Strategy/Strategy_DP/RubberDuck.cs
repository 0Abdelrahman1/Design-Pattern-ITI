using System;
using System.Collections.Generic;
using System.Text;

namespace DP01_Strategy.Strategy_DP
{
    public class RubberDuck:Duck
    {
        public override void Display() => Console.Write("I am Rubber Duck");

        public RubberDuck():base(new NoFly() , new Sqeek())
        {
            
        }
    }
}
