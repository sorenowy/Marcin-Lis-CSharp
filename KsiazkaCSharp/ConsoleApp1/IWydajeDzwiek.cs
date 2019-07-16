using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IWydajeDzwiek
    {
        void Graj();
    }
    interface IPrezentujObraz: IWydajeDzwiek
    {
        void Wyswietl();
    }
    interface IWyswietlajObrazIWydajeDzwiek:IWydajeDzwiek,IPrezentujObraz
    {

    }


}
