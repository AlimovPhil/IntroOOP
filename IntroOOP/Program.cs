using System.Text;
using IntroOOP;
using IntroOOP.BankAccount;
using IntroOOP.FunWithStrings;

Header.HwHeader("ООП", 3, "Алимов Филипп");

string path = @"D:\Phil_docs\GB\HomeWork\IntroOOP\IntroOOP\DataFile.txt"; 
string emailsfile = @"D:\Phil_docs\GB\HomeWork\IntroOOP\IntroOOP\Mails.txt";

using (StreamReader reader = new(path))
using (StreamWriter writer = new(emailsfile))
{
    //string? line;
    //while ((line = reader.ReadLine()) != null)
    while (reader.ReadLine() is { } line)
    {
        DataExtraction.SearchMail(ref line);
        writer.WriteLine(line);
    }
}

Console.WriteLine("Программа выполнена.");
Console.ReadLine();
