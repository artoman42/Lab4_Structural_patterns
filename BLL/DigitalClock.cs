using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DigitalClock : AbstractClock
    {
        public DigitalClock(IImplementation _implementation) : base(_implementation)
        {
        }

        public override void ShowTime()
        {
            Console.WriteLine("Цифровий годинник");
            Console.WriteLine(_implementation.GetTime());
        }
    }
}
