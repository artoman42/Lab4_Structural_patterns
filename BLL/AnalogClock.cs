using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AnalogClock : AbstractClock
    {
        public AnalogClock(IImplementation _implementation) : base(_implementation)
        {
        }

        public override void ShowTime()
        {
            Console.WriteLine("Годинник зi стрiлками :");
            Console.WriteLine(_implementation.GetTime());
        }
       
    }
}
