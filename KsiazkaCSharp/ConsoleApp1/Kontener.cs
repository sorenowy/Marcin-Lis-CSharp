﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void WyswietlDelegacje(Kontener obj);
    class Kontener
    {
        public int w1
        {
            get
            {
                return 100;
            }
        }
        public double w2
        {
            get
            {
                return 2.14;
            }
        }
        public void CallBackWyswietl(WyswietlDelegacje del)
        {
            del(this);
        }
    }
}
