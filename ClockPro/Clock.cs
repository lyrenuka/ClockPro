using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockPro
{
    public class Clock
    {
        private Counter hours;
        private Counter minutes;
        private Counter seconds;

        public Clock()
        {
            hours = new Counter();
            minutes = new Counter();
            seconds = new Counter();
        }

        public void Tick()
        {
            seconds.Increment();
            if (seconds.GetCount() == 60)
            {
                seconds.Reset();
                minutes.Increment();
                if (minutes.GetCount() == 60)
                {
                    minutes.Reset();
                    hours.Increment();
                    if (hours.GetCount() == 24)
                    {
                        hours.Reset();
                    }
                }
            }
        }

        public string GetTime()
        {
            return $"{hours.GetCount():00}:{minutes.GetCount():00}:{seconds.GetCount():00}";
             return $"{hours.GetCount():00}:{minutes.GetCount():00}:{seconds.GetCount():00}";
        }

        public void Reset()
        {
            hours.Reset();
            minutes.Reset();
            seconds.Reset();
        }
    }
}
