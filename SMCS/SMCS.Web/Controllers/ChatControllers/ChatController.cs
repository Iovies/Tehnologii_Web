using Microsoft.AspNetCore.Mvc;
using SMCS.Web.Models.Chat;

namespace SMCS.Web.Controllers.ChatControllers
{
    public class ChatController : SMCSController
    {
        public IActionResult Index() // To Do : Make the message input (the chat itself) stay as the same size, (make a scrollbar for chat, and put it in a wrapper)
        {
            /*
                The idea is this -> we send a list of chats (List<Chat>) in view
                when the user chooses one of the chats from the list, then in _chat its model is used to display the list of messages Chat.messageList[0-over9999] (messageList<message>)
                message must contain information about the type of message (incoming or outgoing) in order to mark the respective message
            */
            var model = new Chats();
            model.chats = new List<Chat>()
            {
                new Chat() {
                    ChatID="12i13w", // required
                    Receiver="Ion",
                    Sender="Not_Ion",
                    messages = new List<Message>()
                    { // Username = Receiver >??
                        new Message() {Username="Ion", MType=Message.MessageType.Outgoing, Content="Hello World from Ion", Timestamp=new DateTime(2022, 12, 22, 22, 22, 1)},
                        new Message() {Username="Not_Ion", MType=Message.MessageType.Incoming, Content="Hello to you too", Timestamp=new DateTime(2022, 12, 22, 22, 22, 1)}
                    }
                },
                new Chat() {
                    ChatID="65546ww",
                    Receiver="Sanea",
                    Sender="Gheorhe",
                    messages = new List<Message>()
                    {
                        new Message() {Username="Sanea", MType=Message.MessageType.Incoming, Content="Hello World from Sanea", Timestamp = new DateTime(2022, 12, 22, 22, 22, 1)},
                        new Message() {Username="Gheorhe", MType=Message.MessageType.Outgoing, Content="Hello To you Gheorhe", Timestamp = new DateTime(2022, 12, 22, 22, 22, 1)}
                    }
                },
                new Chat() {
                    ChatID="i9899",
                    Receiver="Ion",
                    Sender="Feghea",
                    messages = new List<Message>()
                    {
                        new Message() {Username="Ion", MType=Message.MessageType.Outgoing, Content="Maine Ore nu avem", Timestamp = new DateTime(2022, 12, 22, 22, 22, 1)},
                        new Message() {Username="Feghea", MType=Message.MessageType.Incoming, Content="De ce?", Timestamp = new DateTime(2022, 12, 22, 22, 22, 1)}
                    }
                }
            };

            return View(model);
        }
    }
}
