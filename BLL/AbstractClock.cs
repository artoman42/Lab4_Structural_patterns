using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class AbstractClock
    {
        protected IImplementation _implementation;
        public AbstractClock(IImplementation implementation)
        {
            this._implementation = implementation;
        }
        public abstract void ShowTime();
    }
}
