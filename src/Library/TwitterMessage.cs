namespace Library;

public class TwitterMessage : Message
{
    public TwitterMessage(string text, string from, Contact contact) : base(from, contact.TwitterID)
    {
        this.Text = text;
    }
    

}