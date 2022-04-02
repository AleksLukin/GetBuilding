
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.Sum();
            var mySecondClass = new MySecondClass();
            mySecondClass.SumTwo();
            var myClassThird = new MyClassThird();
            myClassThird.SumThree();
        }
    }
    class MyClass
    {
        protected int a = 5;
        int b { get; set; }

        public void Sum()
        {
            
            this.b = b;
            
            b = 6;
            int c=a + b;
        }
    }
    class MySecondClass:MyClass
    {
        int e { get; set; }
        int d { get; set; }

        public void SumTwo()
        {
            
            this.d = d;
            this.e = e;
            e = 5;
            d = 6;
            int f = e + d+a;
        }

    }
    class MyClassThird:MyClass
    {
        int _X { get; set; }
        int _Y { get; set; }
        int _Z { get; set; }

        public void SumThree()
        {
            int X = _X;
            int Y = _Y;
            int Z = _Z;

            X = 88;
            Y = 99;
            Z = 111;

            int v = X + Y + Z+a;
            
        }
    }
}
