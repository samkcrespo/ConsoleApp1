using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PingIPV6 : BasePing
    {
       
        //If ping boots, return true SAME
        public bool Init()

        {
            return true;
        }
        //Different implementation
        public bool SendPing()
        {
            return true;
        }

    }
}
