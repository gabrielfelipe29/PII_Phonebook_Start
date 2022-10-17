namespace Library
{
    public class Contact
    {
        public Contact(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string TwitterID { get; set; }

        public string Email { get; set; }
    }
}