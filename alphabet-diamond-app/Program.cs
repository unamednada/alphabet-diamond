// See https://aka.ms/new-console-template for more information
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

Console.WriteLine("Press any key to exit!");
