namespace Library;
using System;
using TwitterUCU;

public class Twitter : IMessageChannel
{

    public void Send(Message msg)
    {
        
        var twitter = new TwitterUCU.TwitterMessage();
        twitter.SendMessage(msg.Text, msg.To);

    }

}