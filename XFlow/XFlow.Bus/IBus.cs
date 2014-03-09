using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFlow.Bus
{
    public interface IBus
    {
        void Send<T>(T message);

        void Send(object message);

        void Subscribe<T>(Action<T> handler);

        void Subscribe(Action<object> handler);

    }
}
