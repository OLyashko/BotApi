using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace ViberApi
{
    public class ViberMessageSender : ISendMessage<ViberMessageResponse>
    {
        #region private fields
        private static readonly HttpClient httpClient = new HttpClient();
        private ViberMessage _message;
        #endregion

        #region ctor
        public ViberMessageSender()
        {
            _message = new ViberMessage()
            {
                MinApiVersion = 1,
                Sender = new Sender { Name = Constans.BotName },
                Type = Enums.ViberMessageType.Text,
            };
        }
        #endregion

        #region public methods
        public ViberMessageResponse SendMessage(string Receiver, string Text)
        {
            this._message.Receiver = Receiver;
            this._message.Text = Text;

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("X-Viber-Auth-Token", Constans.XViberAuthToken);

            var jsonData = JsonConvert.SerializeObject(this._message);
            StringContent content2send = new StringContent(jsonData, Encoding.UTF8, "application/json");

            try
            {
                var stringTask = httpClient.PostAsync(Constans.ViberSendMessageUrl, content2send);

                if (stringTask.Result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<ViberMessageResponse>(stringTask.Result.Content.ReadAsStringAsync().Result);
                }
                else
                {
                    throw new Exception($"Error retriving data from outbounding service");
                }
            }
            catch
            {
                throw new Exception($"Error retriving data from outbounding service");
            }

           

        }

        #endregion

    }

}
