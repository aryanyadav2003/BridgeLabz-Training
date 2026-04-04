using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_library
{
    public class DataBaseConnection
    {
        public bool IsConnected { get; private set; }
        public void Connect()
        {
            // Simulate DB connection
            IsConnected = true;
        }
        public void Disconnect()
        {
            // Simulate closing DB connection
            IsConnected = false;
        }
    }
}
