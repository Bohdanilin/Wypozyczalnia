using Newtonsoft.Json;
using System;


namespace Wypozyczalnia
{
    public class Message
    {
        public string? user_answer { get; set; }

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

        //    List<string>? Clients = new List<string>; 
        public List<Clients>? AllClients { get; set; }

        private void CreateClients()
        {
            var path = $"{Directory.GetCurrentDirectory()}\\clients.json";
            var json = File.ReadAllText(path);
            AllClients = JsonConvert.DeserializeObject<List<Clients>>(json);
        }
        public void DisplayClients()
        {
            Console.WriteLine("Id | Imię i nazwisko | Data wydania prawa jazdy");
            foreach (var c in AllClients!)
            {
                Console.WriteLine(c.Id + " | " + c.FirstName + c.LastName + " | " + c.DateDrivingLicense);
            }
        }



    }
}
