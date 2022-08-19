using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ping
    {
        public int HostAddress { get; set; }
        public int DestAddress { get; set; }
        public string Data { get; set; }

        public void SendPing()
        {
            Console.WriteLine("Pinging...Ping sent");
        }

    }
}
