﻿using NetworkSetup.Model;

namespace NetworkSetup.Service
{
    public class VlanService
    {
        public List<Vlan> VlanList { get; private set; }

        public VlanService() 
        {
            VlanList = new List<Vlan>();
        }

        public void Add(string id, string description, string ipAddress) 
        {
            VlanList.Add(new Vlan
            { 
                Id = id, Description = description, IpAddress = ipAddress           
            });
        }
    }
}
