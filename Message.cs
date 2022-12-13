using Newtonsoft.Json;
using System;
using System.IO;


namespace Wypozyczalnia
{
    public class Message
    {
        public Message()
        {
            CreateClients();
            CreateCars();
        }

        public string user_answer { get; set; }


        public void WelcomeScreen()
        {
            Console.WriteLine();
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA KLIENTÓW I SAMOCHODÓW");
            Console.WriteLine("2 => WYPOŻYCZENIE SAMOCHODU");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3:");
            user_answer = Console.ReadLine();

        }
        public void IdClientScreen()
        {
            Console.Clear();
            Console.WriteLine("PROSZĘ PODAĆ ID KLIENTA, KTÓRY WYPOŻYCZA SAMOCHÓD:");
            user_answer = Console.ReadLine();
        }

        public void SegmentScreen()
        {
            Console.Clear();
            Console.WriteLine("1. mini");
            Console.WriteLine("2. kompakt");
            Console.WriteLine("3. premium");
            Console.WriteLine("PODAJ SEGMENT SAMOCHODU:");
            user_answer = Console.ReadLine();

        }
        public void FuelScreen()
        {
            Console.Clear();
            Console.WriteLine("1. benzyna");
            Console.WriteLine("2. elektryczny");
            Console.WriteLine("3. diesel");
            Console.WriteLine("PODAJ PREFEROWANY RODZAJ PALIWA:");
            user_answer = Console.ReadLine();


        }
        public void TermScreen()
        {
            Console.Clear();
            Console.WriteLine("PODAJ ILOŚĆ DNI WYNAJMU POJAZDU:");
            user_answer = Console.ReadLine();

        }
        public void AgreementScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("UMOWA WYNAJMU POJAZDU");
            Console.WriteLine("DATA ZAWARCIA: " + DateTime.Now.ToString());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WYNAJMUJĄCY: ");
            Console.WriteLine("RODZAJ POJAZDU: ");
            Console.WriteLine("RODZAJ PALIWA: ");
            Console.WriteLine("SEGMENT: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("DATA ZWROTU POJAZDU: ");
            Console.WriteLine("OPŁATA: ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public List<Car> AllCars { get; set; }
        public List<Client> AllClients { get; set; }

        private void CreateClients()
        {
            var path = $"{Directory.GetCurrentDirectory()}//clients.json";
            var json = File.ReadAllText(path);
            AllClients = JsonConvert.DeserializeObject<List<Client>>(json);
        }
        private void CreateCars()
        {
            var path = $"{Directory.GetCurrentDirectory()}//cars.json";
            var json = File.ReadAllText(path);
            AllCars = JsonConvert.DeserializeObject<List<Car>>(json);
        }
        public void DisplayLists()
        {
            Console.Clear();
            Console.WriteLine("LISTA KLIENTÓW:");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Id | Imię i nazwisko | Data wydania prawa jazdy");
            foreach (var clients in AllClients)
            {
                Console.WriteLine(clients.Id + " | " + clients.FirstName + " " + clients.LastName + " | " + clients.DateDrivingLicense);
            }
            Console.WriteLine("");
            Console.WriteLine("LISTA SAMOCHODÓW:");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Id | Model | Segment | Rodzaj paliwa | Cena za dobę");
            foreach (var cars in AllCars)
            {
                Console.WriteLine(cars.Id + " | " + cars.Marka + " | " + cars.Segment + " | " + cars.FuelType + " | " + cars.Price);
            }
        }
    }
}
