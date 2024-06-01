using NetworkSetup.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkSetup.Service
{
    public class SwitchConfigurationDcn
    {
        //Basic Info
        public string HostName { get; set; } = string.Empty;
        public string NtpServer { get; set; } = string.Empty;
        
        //Account
        public List<Account> Accounts { get; set; } = new List<Account>();

        public List<string> SnmpHost { get; set; } = new List<string>();
        public List<Vlan> Vlans { get; set; } = new List<Vlan>();

        public List<string> command { get; set; } = new List<string>();

        public void AddToCommand(string com) 
        {
            command.Add(com);
        }

        private void CommandForStart() 
        {
            command.Add($"enable");
            command.Add($"config");
            Accounts.ForEach(account => command.Add($"username {account.UserName} privilege {account.Privilege} password 0 {account.Password}"));

            command.Add($"snmp-server enable");
            command.Add($"snmp-server securityip disable");
            command.Add(GetSnmpHosts());
            command.Add($"snmp-server community ro 0 public");
            command.Add($"snmp-server community rw 0 private");

            command.Add("service dhcp");

            command.Add($"ip forward-protocol udp bootps");
            command.Add($"ip dhcp server relay information enable");
            command.Add($"ip dhcp relay information option");
            command.Add($"ip dhcp relay information option subscriber-id format hex");

            command.Add($"ip dhcp snooping enable");
            command.Add($"ip dhcp snooping vlan ");
            command.Add($"ip dhcp snooping binding enable");

        }

        private string GetSnmpHosts() 
        {
            var sb = new StringBuilder();

            foreach(string host in SnmpHost) 
            {
                sb.AppendLine($"snmp-server host {host} v2c private");
            }

            return sb.ToString();
        }

        private string GetSnoopingVlan() 
        {
            return null;
        }
    }
}
