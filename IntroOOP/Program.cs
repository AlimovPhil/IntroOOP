using IntroOOP.BankAccount;


Console.WriteLine("Аккаунт №1: ");
BankAccount acc1 = new();
acc1.GetInfo();

Console.WriteLine(" ");

Console.WriteLine("Аккаунт №2: ");
BankAccount acc2 = new(BankAccount.AccType.current);
acc2.GetInfo();
Console.WriteLine(" ");

Console.WriteLine("Аккаунт №3: ");
BankAccount acc3 = new(9999999);
acc3.GetInfo();
Console.WriteLine(" ");

Console.WriteLine("Аккаунт №4: ");
BankAccount acc4 = new(322, BankAccount.AccType.credit);
acc4.GetInfo();

Console.ReadLine();
