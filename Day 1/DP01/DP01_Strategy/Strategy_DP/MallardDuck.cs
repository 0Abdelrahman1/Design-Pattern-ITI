using System;
using System.Collections.Generic;
using System.Text;

namespace DP01_Strategy.Strategy_DP
{
    public class MallardDuck:Duck
    {
        public override void Display() => Console.Write("I am Mallard Duck");
        public MallardDuck():base(new FlyNormalSpeed() , new NormalQuack()) ///Initial Behavior
        {
            
        }

    }
}
