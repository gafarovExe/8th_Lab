using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Windows.Markup;

class HelloWorld
{
    static int Main()
    {
        //Ё = 1025
        //ё = 1105
        //а = 1072
        //я = 1103
        //А  = 1040
        //Я = 1071
        string text;
        double k = 0;
        Console.WriteLine("Enter the text:");
        text = Console.ReadLine();
        for (int i=0; i<text.Length; i++)
        {
            if (text[i] == 1025 || text[i] == 1105 || (text[i] >= 1040 && text[i] <= 1103)) k++;
        }
        double b = k/text.Length*100;
        Console.WriteLine("Count of russian letters: " + k);
        Console.WriteLine("Frequency of russian letters: " + b + "%.");
        return 0;
    }
}
