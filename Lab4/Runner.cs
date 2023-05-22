using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
namespace UIL
{
    public class Runner : IRunner
    {
        protected IMenuBuilder _menuBuilder;
        public Runner(IMenuBuilder menuBuilder)
        {
            _menuBuilder = menuBuilder;
        }
        public void Run()
        {
            
            while (true)
            {
               
                _menuBuilder.WriteMenu();
                string input = Console.ReadLine();
                string[] args = input.Split(' ');
                DateTime current = DateTime.Now;
                AbstractClock Clock;
                int[] int_args = new int[3];
                if(args.Length == 4)
                {
                    for(int i=1; i < args.Length; i++)
                    {
                        int.TryParse(args[i], out int_args[i-1]);
                    }
                }
                
                switch (args[0])
                {
                        case "1":
                        
                        if (args.Length == 4)
                        {
                            Clock = new AnalogClock(new AnalogClockImplementation(int_args[0], int_args[1], int_args[2]));
                        }
                        else
                        {
                            string to_parse = current.ToString("hh:mm:ss");
                            args = to_parse.Split(":");
                            for (int i = 0; i < args.Length; i++)
                            {
                                int.TryParse(args[i], out int_args[i]);
                            }
                            Clock = new AnalogClock(new AnalogClockImplementation(int_args[0], int_args[1], int_args[2]));
                        }

                        Clock.ShowTime();
                        Console.WriteLine();
                        break;
                        case "2":
                        if(args.Length == 4)
                        {
                            Clock = new DigitalClock(new DigitalClockImplementation(int_args[0], int_args[1], int_args[2]));
                        }
                        else
                        {
                            string to_parse = current.ToString("HH:mm:ss");
                            args = to_parse.Split(":");
                            for (int i = 0; i < args.Length; i++)
                            {
                                int.TryParse(args[i], out int_args[i]);
                            }
                            Clock = new DigitalClock(new DigitalClockImplementation(int_args[0], int_args[1], int_args[2]));
                        }
                        Clock.ShowTime();
                        Console.WriteLine();
                        break;
                }
                

                

                
            }

        }
    }
}
