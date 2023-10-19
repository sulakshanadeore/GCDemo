using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDemo
{
    public class Demo1
    {
        public void Display()
        {
            Console.WriteLine("Display called....");
        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Firstexample();
            Calci cobj = new Calci();
            Console.WriteLine("Generation of calci " + GC.GetGeneration(cobj));
            Console.WriteLine("0th Genration  count= " + GC.CollectionCount(0));

            
            Console.WriteLine("1st Genration  count= " + GC.CollectionCount(1));

            Console.WriteLine("2nd Genration  count= " + GC.CollectionCount(2));

            GC.Collect(0);
            Console.WriteLine("0th Genration  count= " + GC.CollectionCount(0));



            Console.ReadLine();

        }

        private static void Firstexample()
        {
            //Console.WriteLine(GC.MaxGeneration);

            Console.WriteLine("Total Memory " + GC.GetTotalMemory(false));
            Demo1 obj = new Demo1();
            Console.WriteLine("Generation of obj object= " + GC.GetGeneration(obj));
            Console.WriteLine("Total Memory " + GC.GetTotalMemory(false));
        }
    }
}
