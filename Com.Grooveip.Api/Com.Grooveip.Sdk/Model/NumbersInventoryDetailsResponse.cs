using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Grooveip.Sdk.Model
{
    public class NumbersInventoryDetailsResponse
    {
        public string PhoneNumberId;
        public string PhoneNumber;
        public string CreationDate;
        public string UserId;
        public string Password;
        public Sip Sip;
        public Sip SipSecondary;
        public Usage Usage;
        public int NumberUserId;
        public int TotalPages;
        public string Email;
    }
}
