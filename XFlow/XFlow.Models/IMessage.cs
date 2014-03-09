using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFlow.Models
{
    public interface IMessage
    {
        IMessageHeader Header { get; set; }
        IMessagePayload Payload { get; set; }
    }
}
