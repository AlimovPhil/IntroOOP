using IntroOOP.BankAccount;

//BankAccount acc1 = new BankAccount(); (старый синтаксис) 
BankAccount acc1 = new();

acc1.SetID(123456789);
acc1.SetBalance(100000);
acc1.SetType(BankAccount.AccType.credit);


Console.WriteLine("Аккаунт №1: ");

Console.WriteLine($"Номер счета: {acc1.GetID()}");
Console.WriteLine("Баланс: {0} $", acc1.GetBalance());
Console.WriteLine("Тип счета: {0} ", acc1.GetType());

Console.ReadLine();
