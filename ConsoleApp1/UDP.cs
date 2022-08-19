using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UDP
    {
        public int HostAddress { get; set; }
        public int DestAddress { get; set; }
        public string Data { get; set; }

        public void SendUDP()
        {
            Console.WriteLine("Sending UDP...UDP sent");
        }
    }
}
