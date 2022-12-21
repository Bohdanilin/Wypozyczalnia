namespace Wypozyczalnia
{
    public class Client
    {
        public List<Client> Clients { get; set; }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        public DateTime DateDrivingLicense { get; set; }
    }
}