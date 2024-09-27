namespace NetworkSetup.Model
{
    public class Vlan
    {
        public string Id { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string IpAddress { get; set; } = string.Empty;
        public bool IsSnooping { get; set; }
    }
}
