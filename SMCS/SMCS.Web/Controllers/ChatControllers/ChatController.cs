using Microsoft.AspNetCore.Mvc;
using SMCS.Web.Models.Chat;
using SMCS.Web.Models.Lodging;

namespace SMCS.Web.Controllers.ChatControllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
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
                    Receiver="Ion",
                    Sender="NotIon",
                    messages = new List<Message>()
                    { // Username = Receiver >??
                        new Message() {Username="Ion", MType=Message.MessageType.Outgoing, Body="Hello World from Ion"},
                        new Message() {Username="NotIon", MType=Message.MessageType.Incoming, Body="Hello to you too"}
                    }
                },
                new Chat() {
                    Receiver="Sanea",
                    Sender="Gheorhe",
                    messages = new List<Message>()
                    {
                        new Message() {Username="Sanea", MType=Message.MessageType.Incoming, Body="Hello World from Sanea"},
                        new Message() {Username="Gheorhe", MType=Message.MessageType.Outgoing, Body="Hello To you Gheorhe"}
                    }
                },
                new Chat() {
                    Receiver="Ion",
                    Sender="Feghea",
                    messages = new List<Message>()
                    {
                        new Message() {Username="Ion", MType=Message.MessageType.Outgoing, Body="Maine Ore nu avem"},
                        new Message() {Username="Feghea", MType=Message.MessageType.Incoming, Body="De ce?"}
                    }
                }
            };

            return View(model);
        }
    }
}
