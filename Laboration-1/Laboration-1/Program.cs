using System.Runtime.ExceptionServices;
using static System.Net.Mime.MediaTypeNames;

string main = "1231b323";



void highlighter (string a)
{

    int mainLength = a.Length;
    char indexedChar = a[0];
    int value = indexedChar;

    for (int i = 1; i < mainLength; i++)
    { 
        int highlightLength = i - value + 1;
        

        if (char.IsLetter(a[i]))
        {
            indexedChar = a[i+1];
            i++;
        }
        else if (a[i] == (indexedChar))
        {

            Console.WriteLine(a.Substring(0, value - 1));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(a.Substring(value, highlightLength));

            Console.ResetColor();
            Console.WriteLine(a.Substring(i + 1, highlightLength - i));

            indexedChar++;
        }
        else
        {
            break;
        }

        
    }
}

highlighter(main);
    
