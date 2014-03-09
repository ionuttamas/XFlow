using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using XFlow.Checkpointing;
using XFlow.Infrastructure.OperationProcessing;

namespace XFlow.Bus
{
    /// <summary>
    /// Defines a contract that will be implemented by any underlying ESB used for messaging.
    /// </summary>
    public interface IBus
    {
        /// <summary>
        /// Gets or sets the in-transit messages. 
        /// </summary>
        /// <value>
        /// The in transit messages.
        /// </value>
        IEnumerable<IMessage> InTransitMessages { get; set; }

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

        /// <summary>
        /// Takes immediately a checkpoint of the messages in the bus, by locking the bus and persisting the messages to a stable-storage layer.
        /// </summary>
        /// <returns></returns>
        OperationResult ExecuteCheckpoint();
         
        /// <summary>
        /// Takes immediately a checkpoint of the messages in the bus, by locking the bus and persisting the messages to a stable-storage layer.
        /// </summary>
        /// <returns></returns>
        OperationResult ExecuteCheckpoint(CheckpointingContext context);
    }
}
