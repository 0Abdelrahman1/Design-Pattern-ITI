using System;
using System.Collections.Generic;
using System.Text;

namespace DP01_Strategy.Strategy_DP
{
    public interface IFly
    {
        void PerformFly();
    }
    ///Encapsulate Behavior 
    public class FlyNormalSpeed:IFly
    {
        public void PerformFly() => Console.WriteLine("Fly Normal Speed");
    }
    public class NoFly : IFly
    {
        public void PerformFly() => Console.WriteLine("No Wings To Fly");
    }
    ///Open for Extensions
    public class FlyRocketSpeed :IFly
    {
        public void PerformFly() => Console.WriteLine("Fly Rocket Speeeeeeed....");
    }


}
