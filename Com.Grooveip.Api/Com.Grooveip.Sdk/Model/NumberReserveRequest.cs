using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Grooveip.Sdk.Model
{
    public class NumberReserveRequest
    {
        public int CustomerId { get; set; }
        public string PhoneNumber { get; set; }
        public string AreaCode { get; set; }
        public string RequestId { get; set; }
        public string Hash { get; set; }
        public string Token { get; set; }
    }
}
