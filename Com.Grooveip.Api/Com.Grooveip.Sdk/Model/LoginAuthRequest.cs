using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Grooveip.Sdk.Model
{
    public class LoginAuthRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string AuthHash { get; set; }
    }
}
