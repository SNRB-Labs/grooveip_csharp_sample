using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Grooveip.Sdk.Model
{
    public class PasswordChangeRequest
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordConfirm { get; set; }
        public string Hash { get; set; }

        public bool DoPasswordsMatch()
        {
            return NewPassword == NewPasswordConfirm;
        }
    }
}
