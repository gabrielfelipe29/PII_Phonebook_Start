namespace Library;

public class WhatsappMessage : Message
{

    public WhatsappMessage(string text, string from, Contact contact) : base(from, contact.Phone)
    {

        this.Text = text;

    }

}