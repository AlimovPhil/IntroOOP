using IntroOOP.BankAccount;


Console.WriteLine("Аккаунт №4: ");

BankAccount acc4 = new(500, BankAccount.AccType.Credit);

acc4.GetInfo();

bool result = acc4.WithdrawMoney(500);

if (result != true)
     Console.WriteLine("Операция не выполнена! Недостаточно средств!\n");
else Console.WriteLine("Снятие средств выполнено!\n");

acc4.GetInfo();

result = acc4.WithdrawMoney(1000);
if (result != true)
    Console.WriteLine("Операция не выполнена! Недостаточно средств!\n");
else Console.WriteLine("Снятие средств выполнено!\n");

acc4.GetInfo();

acc4.AddMoney(9500);

acc4.GetInfo();


Console.ReadLine();
