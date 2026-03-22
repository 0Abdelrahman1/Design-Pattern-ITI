
using DP01_Strategy.Strategy_DP;

MallardDuck mallardDuck = new MallardDuck();
mallardDuck.Display();
mallardDuck.Swim();
mallardDuck.Fly();///Normal Speed
mallardDuck.Quack();


RubberDuck rubberDuck = new RubberDuck();
rubberDuck.Display();
rubberDuck.Swim();
rubberDuck.Fly();
rubberDuck.Quack();

Console.WriteLine("Hunting Mode");
mallardDuck.FlyBehavior = new FlyRocketSpeed();
mallardDuck.Fly(); ///Rocket Speed
