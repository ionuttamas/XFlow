using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace XFlow.Bus
{
    /// <summary>
    /// Defines a contract that will be implemented by any underlying ESB used for messaging.
    /// </summary>
    public interface IBus
    {
        /// <summary>
        /// Sends the specified IMessage message on the bus.
        /// </summary>
        /// <param name="message">The message.</param>
        void Send(IMessage message);

        /// <summary>
        /// Sends the specified generic message on the bus.
        /// </summary>
        /// <param name="message">The message.</param>
        void Send(object message);

        /// <summary>
        /// Subscribes the specified handler to handle the IMessage message that is received on the bus.
        /// </summary>
        /// <param name="handler">The handler.</param>
        void Subscribe(Action<IMessage> handler);

        /// <summary>
        /// Subscribes the specified handler to handle the generic message that is received on the bus.
        /// </summary>
        /// <param name="handler">The handler.</param>
        void Subscribe(Action<object> handler);

    }
}
