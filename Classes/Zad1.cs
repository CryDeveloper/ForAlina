using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAlina.Classes
{
    internal class Zad1
    {
        private int T;
        public Zad1(int T)
        {
            this.T = T;
        }
        public void sm()
        {
            int minut = T / 60;
            int second = T % 60;
            Console.WriteLine("{0} секунд = {1} минут {2} секунд", T, minut, second);
        }
    }
}
