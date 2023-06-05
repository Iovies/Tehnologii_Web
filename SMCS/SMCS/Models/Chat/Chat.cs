namespace SMCS.Web.Models.Chat
{
    public class Chat
    {
        /*public int Id { get; set; } // ?*/
        public string Receiver { get; set; } // set all receiver's messages to be incoming ?
        public string Sender { get; set; } // set all receiver's messages to be outgoing ? 
        public List<Message> messages;
        public string ChatID { get; set; }
        // Remove messages list and use only the ChatID,
        // create a new model for getting messages? model-> ChatItem, it will store 2 vars :
        // 1. ChatID
        // 2. Messages list
        // When using : Get chatID, find the model with the same chatID, and get messages to display from it 
    }
}
