using BotApi.Interfaces;
using BotApi.Models;
using ViberApi;

namespace BotApi.Services
{
    public class MessageSender : IMessageSender
    {
        public string Send(Message message)
        {
            ISendMessage<ViberMessageResponse> viberSender = new ViberMessageSender();
            var response = viberSender.SendMessage(message.Msisdn,message.Text);
            return response.ToString();
            //throw new NotImplementedException();
        }
    }
}
