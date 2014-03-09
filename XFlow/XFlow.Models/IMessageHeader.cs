using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace XFlow.Models
{
    public interface IMessageHeader
    {
        Guid Id { get; set; }
        object Metadata { get; set; }
        IEnumerable<Type> PayloadTypes { get; set; }
    }
}
