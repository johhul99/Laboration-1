using System.Runtime.ExceptionServices;
using static System.Net.Mime.MediaTypeNames;

string main = "12341b323";



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
        }
        else if (a[i] == (indexedChar))
        {
            string highLighted = a.Substring(value, highlightLength);
            string nonHighlighted = a.Substring(0, value);
            string nonHighlighted2 = a.Substring(i+1, highlightLength-i);
            Console.WriteLine(nonHighlighted);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(highLighted);

            Console.ResetColor();
            Console.WriteLine(nonHighlighted2);

            indexedChar++;
        }
        else
        {
            break;
        }

        
    }
}


highlighter(main);