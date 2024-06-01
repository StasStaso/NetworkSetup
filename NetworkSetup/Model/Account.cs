using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkSetup.Model
{
    public class Account
    {
        public string UserName { get; set; } = "admin";
        public string Password { get; set; } = "admin";
        public int Privilege { get; set; } = 15;
    }
}
