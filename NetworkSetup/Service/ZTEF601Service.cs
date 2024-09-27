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
            
            if (model.DhcpOption82)
            {
                sb.AppendLine("  dhcp-option82 enable vport 1");
            }

            sb.AppendLine("!");

            return sb.ToString();
        }

        public string GenerateConfigRange(ZTEF601Model model)
        {
            string[] positionParts = model.Position.Split(':');
            string oltPosition = positionParts[0];  // "1/1/1"
            string onuId = positionParts.Length > 1 ? positionParts[1] : "1";  // "1"

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("!");
            sb.AppendLine($"interface gpon-onu_{oltPosition}:{onuId}");
            sb.AppendLine("  switchport mode hybrid vport 1");
            sb.AppendLine($"  service-port 1 vport 1 user-vlan {model.VlanId} vlan {model.VlanId}");
            sb.AppendLine("  port-location format ti vport 1");

            if (model.DhcpOption82)
            {
                sb.AppendLine("  dhcp-option82 enable vport 1");
            }

            return sb.ToString();
        }

        public string GenerateMultiConfig(string filePath, string position, string speedProfile, string vlanName, int vlanId, bool dhcpOption82)
        {
            StringBuilder sb = new StringBuilder();
            string[] positionParts = position.Split(':');
            string oltPosition = positionParts[0];
            string rangePart = positionParts[1];
            string[] rangeParts = rangePart.Split('-');
            int startId = int.Parse(rangeParts[0]);
            int endId = int.Parse(rangeParts[1]);

            sb.AppendLine($"interface gpon-olt_{oltPosition}");

            var serialNumbers = File.ReadAllLines(filePath);

            if (serialNumbers.Length < endId - startId + 1)
            {
                throw new InvalidOperationException("Not enough serial numbers provided in the file.");
            }

            for (int onuId = startId; onuId <= endId; onuId++)
            {
                string serialNumber = serialNumbers[onuId - startId];
                sb.AppendLine($"onu {onuId} type ZTE-F601 sn {serialNumber}");
                sb.AppendLine($"onu {onuId} profile line {speedProfile} remote {vlanName}");
            }

            for (int onuId = startId; onuId <= endId; onuId++)
            {
                string serialNumber = serialNumbers[onuId - startId];
                ZTEF601Model model = new ZTEF601Model
                {
                    Position = $"{oltPosition}:{onuId}",
                    SerialNumber = serialNumber,
                    SpeedProfile = speedProfile,
                    VlanName = vlanName,
                    VlanId = vlanId,
                    DhcpOption82 = dhcpOption82
                };

                sb.AppendLine(GenerateConfigRange(model));
            }

            return sb.ToString();
        }
    }
}