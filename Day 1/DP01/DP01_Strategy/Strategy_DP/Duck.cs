using System;
using System.Collections.Generic;
using System.Text;

namespace DP01_Strategy.Strategy_DP
{
    /// <summary>
    /// Closed for Modifications 
    /// </summary>
    public abstract class Duck
    {
        public abstract void Display();
        public void Swim() => Console.WriteLine("Duck is Swiminng .....");


        ///1.Composition is More Powerfull than Inheritance
        ///Child classes get Fly Behavior through Composition not through Inheritance
        public IFly FlyBehavior { get; set;  }
        ///2.Develop Against Abstraction Not Concrete Implementation 
        ///QuackBehavior is of Base Type (Quack) no Derived Types (NormalQuack or Sqeek)
        public Quack QuackBehavior { get; set;  }

        ///Ctor Assign Initial behavior
        public Duck(IFly fly , Quack  quack)
        {
            FlyBehavior = fly;
            QuackBehavior = quack;
        }

        ///3. Delegation
        public void Fly() => FlyBehavior.PerformFly();
        public void Quack() => QuackBehavior.PerformQuack();

    }
}
