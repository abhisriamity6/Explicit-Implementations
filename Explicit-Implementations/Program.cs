using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Implementations
{

    interface IA
    {
        int math(int x);
        

    }
    interface IB
    {
        int math(int x);

    }

    class implementer: IA , IB
    {
        int IA.math(int x)
        {
            return (x+x);
        }
        int IB.math(int x)
        {
            return x * x;

        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            implementer O = new implementer();
            IA intA;
            IB intB;
            int result;

            intA = O;
            result = intA.math(7);
            Console.Write("Output of intA.math(7) :  ");
            Console.WriteLine(result);

            Console.Read();


        }
    }
}
