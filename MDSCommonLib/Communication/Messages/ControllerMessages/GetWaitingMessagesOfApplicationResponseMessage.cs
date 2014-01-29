using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MDS.Communication.Messages.ControllerMessages
{
    public class GetWaitingMessagesOfApplicationResponseMessage : ControlMessage
    {
        /// <summary>
        /// Gets MessageTypeId for GetApplicationListResponseMessage.
        /// </summary>
        public override int MessageTypeId
        {
            get { return ControlMessageFactory.MessageTypeIdGetApplicationListResponseMessage; }
        }

        /// <summary>
        /// List of messages of an application
        /// </summary>
        public List<MDSMessageRecord> Messages { get; set; }

    }

    
}
