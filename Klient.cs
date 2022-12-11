namespace Wypozyczalnia
{
    public class Klient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get { return FirstName + LastName; } }

        public DateTime DateDrivingLicense { get; set; }


    }
}