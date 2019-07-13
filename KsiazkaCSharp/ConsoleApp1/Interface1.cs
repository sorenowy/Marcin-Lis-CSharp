using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IDrawable
    {
        void Draw();
    }
    public abstract class Rysowanie : IDrawable
    {
        public abstract void Draw();
    }
}


