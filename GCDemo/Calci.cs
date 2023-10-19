using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDemo
{
    internal class Calci
    {

        //~Calci() {
        //    Console.WriteLine("Destructor called.... ");
        //}

        //When finalize called ie. when destructor is called, finalize method is called, which is overriden and confirms that the object will surely be garbage collected.
        
        //suppress finalize means cancelling  the call of finalize is suppress finalize



        //public override void Finalize()
        //{
        //    base.Finalize();
        //}

        public int add(int i,int j)
        {

            return i + j;
        }
        public int multi(int i, int j)
        {

            return i * j;
        }
    }
}
