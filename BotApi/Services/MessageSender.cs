using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViberApi;

namespace BotApi
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
