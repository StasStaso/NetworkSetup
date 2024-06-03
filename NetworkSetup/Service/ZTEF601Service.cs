using NetworkSetup.Model;
using System.Text;

namespace NetworkSetup.Service
{
    public class ZTEF601Service
    {
        public string GenerateConfig(ZTEF601Model model)
        {
            string[] positionParts = model.Position.Split(':');
            string oltPosition = positionParts[0];  // "1/1/1"
            string onuId = positionParts.Length > 1 ? positionParts[1] : "1";  // "1"

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"interface gpon-olt_{oltPosition}");
            sb.AppendLine($"onu {onuId} type ZTE-F601 sn {model.SerialNumber}");
            sb.AppendLine($"onu {onuId} profile line {model.SpeedProfile} remote {model.VlanName}");
            sb.AppendLine("!");
            sb.AppendLine($"interface gpon-onu_{oltPosition}:{onuId}");
            sb.AppendLine("  switchport mode hybrid vport 1");
            sb.AppendLine($"  service-port 1 vport 1 user-vlan {model.VlanId} vlan {model.VlanId}");
            sb.AppendLine("  port-location format ti vport 1");
            sb.AppendLine("!");

            if (model.DhcpOption82)
            {
                sb.AppendLine("  dhcp-option82 enable vport 1");
            }

            return sb.ToString();
        }
    }
}