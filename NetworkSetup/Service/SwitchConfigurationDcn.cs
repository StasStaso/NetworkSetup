using NetworkSetup.Model;
using System.Text;

namespace NetworkSetup.Service
{
    public class SwitchConfigurationDcn
    {
        //Basic Info
        private string _hostName;
        private string _ntpServer;

        public string HostName
        {
            get => _hostName;
            set
            {
                if (string.IsNullOrEmpty(_hostName))
                {
                    _hostName = value;
                }
            }
        }

        public string NtpServer
        {
            get => _ntpServer;
            set
            {
                if (string.IsNullOrEmpty(_ntpServer))
                {
                    _ntpServer = value;
                }
            }
        }

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
            command.Add($"ip dhcp snooping vlan {GetSnoopingVlan}");
            command.Add($"ip dhcp snooping binding enable");

            command.Add($"loopback-detection interval-time 35 15");
            command.Add($"loopback-detection control-recovery timeout 600");

            AddVlan();


        }

        public void AddPortCommands(List<string> portCommands)
        {
            command.AddRange(portCommands);
        }

        private string GetSnmpHosts()
        {
            var sb = new StringBuilder();

            foreach (string host in SnmpHost)
            {
                sb.AppendLine($"snmp-server host {host} v2c private");
            }

            return sb.ToString();
        }

        private string GetSnoopingVlan()
        {
            var snoopingVlans = Vlans.Where(item => item.IsSnooping).Select(item => item.Id);
            return string.Join(";", snoopingVlans);
        }

        private void AddVlan()
        {
            foreach (var item in Vlans)
            {
                command.Add($"Vlan {item.Id}");
                command.Add($"name {item.Description}");
                command.Add($"exit");

                if (!string.IsNullOrEmpty(item.IpAddress))
                {
                    AddVlanInterface(item.Id, item.IpAddress);
                }
            }
        }

        private void AddVlanInterface(string id, string ip)
        {
            command.Add($"interface Vlan{id}");
            command.Add($"ip address {ip} 255.255.255.0");
            command.Add($"!");
        }
    }
}
