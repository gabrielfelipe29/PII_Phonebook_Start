using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact dueño = new Contact("Dueño");
            // Crear la lista de contactos
            Phonebook phonebook = new Phonebook(dueño);

            // Agregar contactos a la lista

            phonebook.persons.Add(dueño);

            // Enviar un correo a algunos contactos



            // Enviar un WhatsApp a algunos contactos

            //  no cumple con creator porque se crea por afuera el mensaje y no puedo preguntarle el tipo para
            //  ver dentro de phonebook cual crear.
            IMessageChannel messageChannel = new Whatsapp();
            Message msg = new WhatsappMessage("Hola!", null, dueño);
            phonebook.Send(messageChannel, msg);

            // Enviar un SMS a algunos contactos

            messageChannel = new Twitter();
            msg = new TwitterMessage("Hola!", null, dueño);
            phonebook.Send(messageChannel, msg);


        }
    }
}
