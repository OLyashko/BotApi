using System;
using Xunit;
using ViberApi;

namespace IntegratedTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ViberApi.ISendMessage<ViberMessageResponse> viberSender = new ViberMessageSender();

            var receiver = viberSender.SendMessage("J2VIe2JbUrN0IkoSbomoww==", "tesst");

            //string ttt = receiver.status_message;
            Assert.Matches(receiver.StatusMessage.ToString(), "ok");
        }
    }
}
