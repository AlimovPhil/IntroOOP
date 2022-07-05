using IntroOOP;
using IntroOOP.BankAccount;

Header.HwHeader("ООП",3, "Алимов Филипп");

BankAccount acc1 = new(1500, BankAccount.AccType.credit);
BankAccount acc2 = new(500, BankAccount.AccType.deposit);

acc1.GetInfo();
acc2.GetInfo();

acc1.TransferMoney(acc2, 300);
acc2.TransferMoney(acc1, 2000);

acc1.GetInfo();
acc2.GetInfo();


Console.ReadLine();
