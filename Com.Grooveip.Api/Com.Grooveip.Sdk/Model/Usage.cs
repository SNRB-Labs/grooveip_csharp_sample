using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Grooveip.Sdk.Model
{
    public class Usage
    {
        public int IncomingCalls { get; set; }
        public int OutgoingCall { get; set; }
        public int IncomingMinutes { get; set; }
        public int OutgoingMinutes { get; set; }
        public int IncomingSms { get; set; }
        public int OutgoingSms { get; set; }
    }
}
