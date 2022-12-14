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
        public string answer { get; set; }
        public string answer_id { get; set; }
        public string answer_seg { get; set; }
        public string answer_fuel { get; set; }
        public int time_rent { get; set; }






        public void WelcomeScreen()
        {
            Console.WriteLine();
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA KLIENTÓW I SAMOCHODÓW");
            Console.WriteLine("2 => WYPOŻYCZENIE SAMOCHODU");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3:");
            answer = Console.ReadLine();

        }
        public void IdClientScreen()
        {
            Console.Clear();
            Console.WriteLine("PROSZĘ PODAĆ ID KLIENTA, KTÓRY WYPOŻYCZA SAMOCHÓD:");
            answer_id = Console.ReadLine();
        }

        public void SegmentScreen()
        {
            Console.Clear();
            Console.WriteLine("1. mini");
            Console.WriteLine("2. kompakt");
            Console.WriteLine("3. premium");
            Console.WriteLine("PODAJ SEGMENT SAMOCHODU:");
            answer_seg = Console.ReadLine();

        }
        public void FuelScreen()
        {
            Console.Clear();
            Console.WriteLine("1. benzyna");
            Console.WriteLine("2. elektryczny");
            Console.WriteLine("3. diesel");
            Console.WriteLine("PODAJ PREFEROWANY RODZAJ PALIWA:");
            answer_fuel = Console.ReadLine();


        }
        public void TermScreen()
        {
            Console.Clear();
            Console.WriteLine("PODAJ ILOŚĆ DNI WYNAJMU POJAZDU:");
            time_rent = Convert.ToInt32(Console.ReadLine());

        }
        public void AgreementScreen()
        {
            foreach (var y1 in AllClients)
                foreach (var y2 in AllCars)
                {
                    if (answer_id == y1.Id && answer_seg == y2.Segment && answer_fuel == y2.FuelType)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("UMOWA WYNAJMU POJAZDU");
                        Console.WriteLine("DATA ZAWARCIA: " + date_rent);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-----------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("WYNAJMUJĄCY: " + y1.FullName);
                        Console.WriteLine("RODZAJ POJAZDU: " + y2.Marka);
                        Console.WriteLine("RODZAJ PALIWA: " + answer_fuel);
                        Console.WriteLine("SEGMENT: " + answer_seg);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-----------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("DATA ZWROTU POJAZDU: " + date_rent.AddDays(time_rent));
                        Console.WriteLine("OPŁATA: " + (y2.Price * time_rent));
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
        }
        public void Screen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIEPRAWIDŁOWY SYMWOL");
            Console.ForegroundColor = ConsoleColor.White;
        }

        DateTime date_rent = DateTime.Now;
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
