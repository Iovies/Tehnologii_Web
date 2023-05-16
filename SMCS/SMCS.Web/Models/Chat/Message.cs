using Microsoft.EntityFrameworkCore.Query.Internal;

namespace SMCS.Web.Models.Chat
{
    public class Message
    {
        /*public int Id { get; set; } // ? */
        // Every Message maybe should contain path to userFace img?
        public string Username { get; set; } // Name of the sender of the message (In general can be gained from chat model, but if this is a group chat then it is nedeed)
        public string Content { get; set; } // Text of the message
        public DateTime Timestamp { get; set; }
        /*
            It can be done differently :
            check if the message username is the same as chat Username of the person -> then it's incoming message ?
        */

        // test implementation
        public string MessageClass { get { return MType == MessageType.Incoming ? "incoming-chat" : "outgoing-chat"; } set { MessageClass = "incoming-chat"; } }

        public MessageType MType { get; set; }
        public enum MessageType
        {
            Incoming,
            Outgoing
        }
        
    }
}
