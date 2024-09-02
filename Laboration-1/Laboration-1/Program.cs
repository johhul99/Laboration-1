using System.Runtime.ExceptionServices;
using static System.Net.Mime.MediaTypeNames;

string main = "29535123p48723487597645723645";



void highlighter (string a) //Highlighta alla tal som börjar och slutar på samma siffra
{
    int value = 0;

    for (int i = 1; i < a.Length; i++)
    { 
        int highlightLength = i - value + 1;

        if (char.IsLetter(a[i]))
        {
            value++;
            i = value;

        }
        else if (char.IsLetter(a[value]))
        {
            value++;
            i = value;
        }
        else if (a[i] == a[value])
        {

            Console.Write(a.Substring(0, value));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(a.Substring(value, highlightLength));

            Console.ResetColor();
            Console.Write(a.Substring(i + 1, a.Length - i - 1));

            Console.WriteLine("");

            value++;
            i = value;
        }
        else if (i == a.Length-1)
        {
            value++;
            i = value;
        }
        else
        {

        }
        
    }
}

highlighter(main);


Console.WriteLine(""); //Mellanrum mellan resultaten


void sum(string a) //Addera alla tal som börjar och slutar på samma siffra
{
    int value = 0;
    long sum = 0;

    for (int i = 1; i < a.Length; i++)
    {
        int highlightLength = i - value + 1;

        if (char.IsLetter(a[i]))
        {
            value++;
            i = value;

        }
        else if (char.IsLetter(a[value]))
        {
            value++;
            i = value;
        }
        else if (a[i] == a[value])
        {
            string temp = a.Substring(value, highlightLength);
            long add = long.Parse (temp);
            sum += add;

            value++;
            i = value;
        }
        else if (i == a.Length - 1)
        {
            value++;
            i = value;
        }
        else
        {

        }
        
    }
    Console.WriteLine(sum);
}

sum(main);
