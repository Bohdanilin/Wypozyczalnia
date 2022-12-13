using Wypozyczalnia;
var message = new Message();

while (true)
{
    message.WelcomeScreen();

    if (message.user_answer == "1")
    {
        message.DisplayLists();
    }
    if (message.user_answer == "2")
    {
        message.IdClientScreen();

        foreach (var y in message.AllClients) ;

        if (message.user_answer == y.Id)
        {
            Console.Clear();
            var y1 = y;
            System.Console.WriteLine(y.FirstName);

        }

    }


}