using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        public List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }
        public void Send(IMessageChannel messageChannel, Message message)
        {
            
            // creo que tengo que crear los objetos IMessageChannel y Message acá, pero no se como hacer para
            // que cumpla con creator

            messageChannel.Send(message);

        }
    }
}