using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Com.Grooveip.Sdk.Model
{
    [DataContract]
    public class LoginAuthResponse
    {
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember(Name = "Sip")]
        public LoginAuthResponseSip Sip { get; set; }
        [DataMember(Name = "ExternalSip")]
        public LoginAuthResponseSip ExternalSip { get; set; }
        [DataMember(Name = "User")]
        public LoginAuthResponseCredentials Credentials { get; set; }
        [DataMember(Name = "verificationCode")]
        public int VerificationCode { get; set; }
    }
}
