namespace SMCS.Web.Models.Chat
{
    public class Chat
    {
        /*public int Id { get; set; } // ?*/
        public string Receiver { get; set; } // set all receiver's messages to be incoming ?
        public string Sender { get; set; } // set all receiver's messages to be outgoing ? 
        public List<Message> messages;
    }
}
