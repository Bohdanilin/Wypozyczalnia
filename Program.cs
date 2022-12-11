using Wypozyczalnia;
var message = new Message();
message.WelcomeScreen();
if (message.user_answer == "1")
    message.DisplayClients();
