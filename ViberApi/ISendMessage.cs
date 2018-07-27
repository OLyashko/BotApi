using System;
using System.Collections.Generic;
using System.Text;

namespace ViberApi
{
    public interface ISendMessage <T>
    {
        T SendMessage(string Receiver, string Text);
    }
}
