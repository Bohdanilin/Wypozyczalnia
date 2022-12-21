using Wypozyczalnia;
var message = new Message();


while (true)
{
    message.WelcomeScreen();

    if (message.answer == "1")
    {
        message.DisplayLists();
    }

    else if (message.answer == "2")
    {
        message.IdClientScreen();


        foreach (var y in message.AllClients)
        {

            if (message.answer_id == y.Id)
            {
                message.SegmentScreen();

                if (int.TryParse(message.answer_seg, out int x) && x > 0 && x < 4)
                {
                    if (message.answer_seg == "1")
                    {
                        message.answer_seg = "mini";

                    }
                    if (message.answer_seg == "2")
                    {
                        message.answer_seg = "kompakt";

                    }
                    if (message.answer_seg == "3")
                    {
                        message.answer_seg = "premium";
                    }
                    message.FuelScreen();
                    if (int.TryParse(message.answer_fuel, out int z) && z > 0 && z < 4)
                    {
                        if (message.answer_fuel == "1")
                        {
                            message.answer_fuel = "benzyna";
                        }
                        if (message.answer_fuel == "2")
                        {
                            message.answer_fuel = "elektryczny";
                        }
                        if (message.answer_fuel == "3")
                        {
                            message.answer_fuel = "diesel";
                        }
                        message.TermScreen();
                        if (message.time_rent > 0)
                        {

                            message.AgreementScreen();

                        }
                        else
                        {
                            message.Screen();
                        }
                    }
                    else
                    {
                        message.Screen();
                    }
                }
                else
                {
                    message.Screen();
                }
            }
            // else if (message.answer_id != y.Id)
            // {
            //     message.Screen();
            // }
        }
    }
    else if (message.answer == "3")
    {
        break;

    }
    else
    {
        message.Screen();
    }
}










