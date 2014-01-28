using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MDS.Communication.Messages.ControllerMessages
{
    /// <summary>
    /// This message is sent from MDS manager to MDS server to get list of messages waiting of a client application to handle it.
    /// </summary>
    public class GetWaitingMessagesOfApplicationMessage : ControlMessage
    {

        /// <summary>
        /// Gets MessageTypeId for GetApplicationListMessage.
        /// </summary>
        public override int MessageTypeId
        {
            get { return ControlMessageFactory.MessageTypeIdGetWaitingMessagesOfApplication; }
        }
    }
}
