using IntroOOP.BankAccount;

//BankAccount acc1 = new BankAccount(); (старый синтаксис) 
BankAccount acc1 = new(); // Объект 1
BankAccount acc2 = new(); // Объект 2

Console.WriteLine("Аккаунт №1: "); 

acc1.SetBalance(100000);
acc1.SetType(BankAccount.AccType.credit);

acc1.SetID();                                       // Тестирование работы метода создания уникального номера счета
Console.WriteLine($"Номер счета: {acc1.GetID()}"); //1001
acc1.SetID();
Console.WriteLine($"Номер счета: {acc1.GetID()}"); //1002

Console.WriteLine("Баланс: {0} $", acc1.GetBalance());
Console.WriteLine("Тип счета: {0} ", acc1.GetType());

Console.WriteLine(" ");

Console.WriteLine("Аккаунт №2: ");

acc2.SetBalance(999);
acc2.SetType(BankAccount.AccType.deposit);

acc2.SetID();                                       // Дополнительный тест
Console.WriteLine($"Номер счета: {acc2.GetID()}");  //1003
acc2.SetID();
Console.WriteLine($"Номер счета: {acc2.GetID()}"); //1004

Console.WriteLine("Баланс: {0} $", acc2.GetBalance());
Console.WriteLine("Тип счета: {0} ", acc2.GetType());

Console.ReadLine();
