using System.Numerics;

static void lab1()
{

    Console.WriteLine("Mata in en text");
    string text = Console.ReadLine();
    double total = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if (!char.IsDigit(text[i]))
            continue;
        for (int j = i + 1; j < text.Length; j++)
        {
            if (!char.IsDigit(text[j]))
                break;
            if (text[i] == text[j])
            {
                string tal = text.Substring(i, j - i + 1);
 
                Console.Write(text.Substring( 0, i));
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(tal);
                Console.ResetColor();


                Console.WriteLine(text.Substring(j+1));

                total += double.Parse(tal);
               
                break;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("total = "+ total);
}
         
   

lab1();