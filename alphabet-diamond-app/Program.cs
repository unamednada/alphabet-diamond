using System.Net;
using System.Net.Mail;

Console.WriteLine("Welcome to the Diamond Printer!");

Console.WriteLine("Please enter a letter: ");
string input = (Console.ReadLine()).ToUpper();

char letter = input[0];
int letterValue = (int)letter;
int letterNumber =  letterValue - 65;

string[] diamond = new string[letterNumber + 1];

for (int i = 0; i < diamond.Length; i++)
{
    string line = "";
    for (int j = 0; j < letterNumber - i; j++)
    {
        line += " ";
    }
    line += (char)(65 + i);

    if (i > 0)
    {
        for (int j = 0; j < 2 * i - 1; j++)
        {
            line += " ";
        }
        line += (char)(65 + i);
    }
    diamond[i] = line;
}


for (int i = 0; i < diamond.Length; i++)
{
    Console.WriteLine(diamond[i]);
}

for (int i = diamond.Length - 2; i >= 0; i--)
{
    Console.WriteLine(diamond[i]);
}

Console.WriteLine("Would you like to receive this diamond as an email? (Y/N)");
string answer = Console.ReadLine().ToUpper();

Func<string, string, bool> sendEmail = (email, body) =>
{
    var smtpClient = new SmtpClient("smtp.gmail.com")
    {
        Port = 587,
        Credentials = new NetworkCredential(USERNAME, PASSWORD),
        EnableSsl = true,
    };

    smtpClient.Send(USERNAME, email, "Diamond", body);
    return true;
};

if (answer == "Y")
{
    Console.WriteLine("Please enter your email address: ");
    string email = Console.ReadLine();
    Console.WriteLine("Sending email to " + email);
    sendEmail(email, diamond.ToString());
    Console.WriteLine("Email sent!");
}
