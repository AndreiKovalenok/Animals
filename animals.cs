using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.One.Ierarhy.Animals
{
    //interface
    interface IFly
    {
        void IFly();
    }

    interface IVoice
    {
        void ISpeac();
    }

    // иерархия
    class Animal
    {
        
    }

    class Fish:Animal
    {
        
    }

    class Bird:Animal
    {
        
    }

    class Cat : Animal, IVoice
    {
        public void ISpeac()
        {
            Console.WriteLine("Nyaaaaoooo .."); ;
        }
    }

    class Eagle : Bird, IFly, IVoice
    {
        public void IFly()
        {
            Console.WriteLine("I Eagle and i flying"); ;
        }

        public void ISpeac()
        {
            Console.WriteLine("Kar kar kar wshuh"); ;
        }
    }

    class Pingwin : Bird, IVoice
    {
        public void ISpeac()
        {
            Console.WriteLine("Kar kar");
        }
    }

    class GoldFish:Fish
    {
        
    }

    class Helicopter : IFly
    {
        public void IFly()
        {
            Console.WriteLine("Chuh Chuh, motherf**ker !!"); ;
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<object> MyObjects = new List<object>() { new Cat(), new GoldFish(), new Eagle(), new Pingwin(),new Helicopter()};

            foreach(var x in MyObjects)
            {
                if(x is IFly)
                {
                    ((IFly)x).IFly();
                }
                if (x is IVoice)
                {
                    ((IVoice)x).ISpeac();
                }
            }
        }
    }
}
