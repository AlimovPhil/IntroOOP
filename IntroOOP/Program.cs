using IntroOOP.BankAccount;


Console.WriteLine("Аккаунт №4: ");
BankAccount acc4 = new(322, BankAccount.AccType.credit);
acc4.GetInfo();
acc4.WithdrawMoney(500);
acc4.AddMoney(9500);
acc4.WithdrawMoney(822);

Console.ReadLine();
