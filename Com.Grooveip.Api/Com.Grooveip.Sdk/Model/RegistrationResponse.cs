using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Grooveip.Sdk.Model
{
    public class RegistrationResponse
    {
        public string Token { get; set; }
        public string Key { get; set; }
        public int UserId { get; set; }
    }
}
