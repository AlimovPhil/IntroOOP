using IntroOOP;
using IntroOOP.BankAccount;
using IntroOOP.FunWithStrings;

Header.HwHeader("ООП",3, "Алимов Филипп");

string test_str = "short string";
string test_str2 = "longer and bigger string";
string test_str3 = "very super, very duper, very puper long string";

Console.WriteLine($"Simple reverse => {ReverseString.SimpleReverse(test_str)}");

Console.WriteLine($"Bad reverse => {ReverseString.BadReverse(test_str2)}");

Console.WriteLine($"Good reverse => {ReverseString.GoodReverse(test_str3)}");


Console.ReadLine();
