using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace XFlow.Models
{
    public interface IMessagePayload
    {
        IEnumerable<object> Payload { get; set; }
    }
}
