using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firewall_shared
{
    internal class AddRuleRequest
    {
        public string Name { get; set; }
        public string RemoteIp { get; set; }   // null = any
        public int? RemotePort { get; set; }   // null = any
        public string Protocol { get; set; }   // "TCP", "UDP", "Any"
        public string Action { get; set; }     // "Block" or "Allow"

        public AddRuleRequest(string name, string remoteip, int? remoteport, string protocol, string action) { 
            Name = name;
            RemoteIp = remoteip;
            RemotePort = remoteport;
            Protocol = protocol;
            Action = action;
        }

    }
}
