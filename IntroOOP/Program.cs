using IntroOOP;
using IntroOOP.BankAccount;

Header.HwHeader("ООП", 6, "Алимов Филипп");

BankAccount test = new (77777, BankAccount.AccType.Credit);
BankAccount test1 = new (77777, BankAccount.AccType.Credit);
BankAccount test2 = new (6666, BankAccount.AccType.Deposit);

var is_accounts_equal = test.Equals(test1); // true

var is_test_equals_test1 = test == test1; // true
var is_test_not_equals_test1 = test != test1; // false

var is_test_equals_test2 = test == test2; //false
var is_test_not_equals_test2 = test != test2; //true

Console.WriteLine(test.GetHashCode()); // 85418522
Console.WriteLine(test1.GetHashCode()); // 85418522
Console.WriteLine(test2.GetHashCode()); // 64804292

Console.WriteLine($"{test}\n{test1}\n{test2}");


Console.ReadLine();