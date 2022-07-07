using System.Text;
using IntroOOP;
using IntroOOP.BankAccount;
using IntroOOP.FunWithStrings;

Header.HwHeader("ООП", 3, "Алимов Филипп");

//    3.Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail адрес.
//    Разделителем между ФИО и адресом электронной почты является символ &
//    Сформировать новый файл, содержащий список адресов электронной почты.
//    Предусмотреть метод, выделяющий из строки адрес почты.
//    Методу в качестве параметра передается символьная строка s, e-mail возвращается в той же строке s: public void SearchMail(ref string s).

string path = @"D:\Phil_docs\GB\HomeWork\IntroOOP\IntroOOP";
var file = "DataFile.txt";

string data = DataExtraction.ReadFile(path, file);
Console.WriteLine(data);

DataExtraction.SearchMail(ref data);


Console.WriteLine("Программа выполнена.");
Console.ReadLine();
