using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DigitalClockImplementation : IImplementation
    {

        private int hour;
        private int minute;
        private int second;
        public DigitalClockImplementation(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public string GetTime()
        {
            return $"{hour.ToString("00"):D2}:{minute.ToString("00"):D2}:{second.ToString("00"):D2}\n";
        }
    }
}
