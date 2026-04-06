using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsFirewallHelper;
using WindowsFirewallHelper.FirewallRules;

namespace pocFirewall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rule443 = FirewallManager.Instance.CreatePortRule(
            @"Block Port 443 - HTTPS",
            FirewallAction.Block,
            443,
            FirewallProtocol.Any
            );

            rule443.Direction = FirewallDirection.Outbound; // Add this!

            FirewallManager.Instance.Rules.Add(rule443);
        }
    }
}
