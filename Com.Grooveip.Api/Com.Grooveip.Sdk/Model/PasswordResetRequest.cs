using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Grooveip.Sdk.Model
{
    public class PasswordResetRequest
    {
        public string Email { get; set; }
        public string Hash { get; set; }
    }
}
