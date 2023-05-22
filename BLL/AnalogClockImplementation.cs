using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AnalogClockImplementation : IImplementation
    {
        private decimal hour_Angle;
        private decimal minute_Angle;
        private decimal second_Angle;

        public AnalogClockImplementation(int hour, int minute, int second)
        {
            this.hour_Angle = (360 / 12) * (hour + (minute / 60) + (second / 3600));
            this.minute_Angle = (360 / 60) * (minute + (second / 60));
            this.second_Angle = (360 / 60) * second;
        }
       
        public string GetTime()
        {
            decimal hour = (hour_Angle * 12) / 360 ;
            decimal minute = (minute_Angle * 60) / 360;
            decimal second = (second_Angle * 60) / 360;
            StringBuilder sb = new StringBuilder();
            sb.Append($"Оберт годинникової стрiлки : {hour_Angle.ToString():D2}\n");
            sb.Append($"Оберт хвилинної стрiлки : {minute_Angle.ToString():D2}\n");
            sb.Append($"Оберт секудної стрiлки : {second_Angle.ToString():D2} \n");
            sb.Append($"{hour.ToString("00"):D2}:{minute.ToString("00"):D2}:{second.ToString("00"):D2}\n");
            return sb.ToString();
        }
    }
}
