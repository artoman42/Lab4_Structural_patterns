using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIL
{
    public class MenuBuilder : IMenuBuilder
    {
        public void WriteMenu()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("1 - AnalogClock(with params hh:mm:ss, without - time now\n");
            stringBuilder.Append("2 - DigitalClock(with params HH: mm:ss, without - time now\n");
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
