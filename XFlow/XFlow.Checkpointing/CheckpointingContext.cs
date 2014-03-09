using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFlow.Checkpointing
{
    /// <summary>
    /// Defines the context in which a checkpoint will be made either for a BPC or a bus.   
    /// </summary>
    public class CheckpointingContext
    {
        //TODO: Extend this class to include various techniques to analyze the workload & traffic and make decisions that minimize the checkpointing overhead.
        /// <summary>
        /// Gets or sets the maximum delay to wait until checkpointing will start locking the bus.
        /// </summary>
        /// <value>
        /// The maximum delay.
        /// </value>
        public TimeSpan MaximumDelay { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to force making a checkpoint, discarding in-transit messages for a bus or current execution for a BPC. 
        /// </summary>
        /// <value>
        /// </value>
        public bool ForceCheckpoint { get; set; }
    }
}
