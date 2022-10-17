namespace Library;
using WhatsAppApiUCU;
using System;
public class Whatsapp : IMessageChannel
{

    public void Send(Message msg)
    {

        var whatsApp = new WhatsAppApi();
        whatsApp.Send("+598" + msg.To, msg.Text);

    }

}