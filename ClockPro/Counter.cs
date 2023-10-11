using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockPro
{
    public class Counter
    {
        private int count;

        public Counter()
        {
            count = 0;
        }

        public void Increment()
        {
            count++;
        }

        public int GetCount()
        {
            return count;
        }

        public void Reset()
        {
            count = 0;
        }
    }

}
