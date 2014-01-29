using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MDS.Serialization;

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
            get { return ControlMessageFactory.MessageTypeIdGetWaitingMessagesOfApplicationMessage; }
        }

        /// <summary>
        /// Name of target Application to list messages
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// Serializes this message.
        /// </summary>
        /// <param name="serializer">Serializer used to serialize objects</param>
        public override void Serialize(IMDSSerializer serializer)
        {
            base.Serialize(serializer);
            serializer.WriteStringUTF8(ApplicationName);
        }

        /// <summary>
        /// Deserializes this message.
        /// </summary>
        /// <param name="deserializer">Deserializer used to deserialize objects</param>
        public override void Deserialize(IMDSDeserializer deserializer)
        {
            base.Deserialize(deserializer);
            ApplicationName = deserializer.ReadStringUTF8();
        }

    }
}
