using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_library
{
    public class PerfomanceUtils
    {
        public string LongRunningTask()
        {
            Thread.Sleep(3000);
            return "Completed";
        }
    }
}
