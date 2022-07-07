
using System.Text;


namespace IntroOOP.FunWithStrings;

public class DataExtraction
{
    public static void SetFilePath(string path)
    {
        Directory.SetCurrentDirectory(path);
    }
    public static string ReadFile(string path, string file)
    {
        SetFilePath(path);
        var data = File.ReadAllText(file);
        return data;
    }

    public static void SearchMail(ref string s)
    {
        var values = s.Split('\n');
        string newfile = @"D:\Phil_docs\GB\HomeWork\IntroOOP\IntroOOP\Mails.txt";
        foreach (var value_str in values)
        {
            var vv = value_str.Split('&');
            var mail = vv[1].Trim('\r', ' ');
            Console.WriteLine(mail); //удалить

            File.AppendAllText(newfile, mail); //перенести в метод записи чтения
            File.AppendAllText(newfile, Environment.NewLine);

        }
    }
}