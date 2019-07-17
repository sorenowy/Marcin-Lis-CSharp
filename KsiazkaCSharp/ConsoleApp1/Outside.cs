using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Outside
    {
        public class Inside
        {
            public void g()
            {
                Console.WriteLine("Inside:g()");
            }

        }
        public Inside getInside()
        {
            return new Inside();
        }
    }
}
