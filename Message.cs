using System;
namespace Wypozyczalnia
{
    public class Message
    {
        public void WelcomeScreen()
        {
            Console.WriteLine();
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA KLIENTÓW I SAMOCHODÓW");
            Console.WriteLine("2 => WYPOŻYCZENIE SAMOCHODU");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3:");
        }
        public void IdClientScreen()
        {
            Console.Clear();
            Console.WriteLine("PROSZĘ PODAĆ ID KLIENTA, KTÓRY WYPOŻYCZA SAMOCHÓD:");
        }

        public void SegmentScreen()
        {
            Console.Clear();
            Console.WriteLine("1. mini");
            Console.WriteLine("2. kompakt");
            Console.WriteLine("3. premium");
            Console.WriteLine("PODAJ SEGMENT SAMOCHODU:");
        }
        public void FuelScreen()
        {
            Console.Clear();
            Console.WriteLine("1. benzyna");
            Console.WriteLine("2. elektryczny");
            Console.WriteLine("3. diesel");
            Console.WriteLine("PODAJ PREFEROWANY RODZAJ PALIWA:");

        }
        public void TermScreen()
        {
            Console.Clear();
            Console.WriteLine("PODAJ ILOŚĆ DNI WYNAJMU POJAZDU:");
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
    }
}
