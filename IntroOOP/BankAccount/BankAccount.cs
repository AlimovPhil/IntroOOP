namespace IntroOOP.BankAccount;

public class BankAccount
{
    private int _ID; // поле "Номер счета"

    private decimal _Balance; // поле "Баланс"

    private AccType _Type; //поле "Тип банковского счета"

    private static int defaultID = 1000; // Переменная, задающая начальное значение ID

    public enum AccType //  перечисление видов аккаунтов
    {
        NullType,
        Current,
        Credit,
        Deposit,
        Budget
    };

    public BankAccount() => _ID = SetID(); // Конструктор по умолчанию

    public BankAccount(decimal balance) // Конструктор для заполнения поля Баланс
    {
        _ID = SetID();
        _Balance = balance;
    }
    public BankAccount(AccType type)    // Конструктор для заполнения поля Тип
    {
        _ID = SetID();
        _Type = type;
    }
    public BankAccount(decimal balance, AccType type) // Конструктор для заполнения полей Баланс и Тип
    {
        _ID = SetID();
        _Balance = balance;
        _Type = type;
    }

    /// <summary>
    /// Метод устанавливает уникальное значение поля ID
    /// </summary>
    private int SetID()
    {
        defaultID++;
        _ID = defaultID;
        return defaultID;
    }

    // Наконец-то! Настало время свойств!
    public AccType Type // Развернутый вариант написания свойств
    {
        get
        {
            return _Type;
        }
        set
        {
            _Type = value;
        }
    }
    public int ID // Сокращенное написание свойства
    {
        get { return _ID; }
        private set { _ID = value; } // Приватное свойство, чтобы номер счета нельзя было поменять
    }

    public decimal Balance  // you're my butterfly, SUGAR baby!
    {
        get => _Balance;            // лямбда-синтаксис
        set => _Balance = value;
    }


    //public ArgumentException validValue = new("gdgdgdhdh");
    /// <summary>
    /// Метод для пополнения счета
    /// </summary>
    /// <param name="value">Сумма пополнения</param>
    /// <exception cref="ArgumentException">Пополнение не может быть отрицательным!</exception>
    public void AddMoney(decimal value)
    {
        if (value < 0)
            throw new ArgumentException("Размер пополняемой суммы не может быть отрицательным!");
        else
            Balance += value;
    }

    /// <summary>
    /// Метод для снятия денег со счета
    /// </summary>
    /// <param name="value">Сумма снятия</param>
    /// <exception cref="ArgumentException">Снятие не может быть отрицательным!</exception>
    public bool WithdrawMoney(decimal value)
    {
        if (value < 0)
        {
            return false;
            throw new ArgumentException("Размер снимаемой суммы не может быть отрицательным!");
        }
        else
        {
            if (Balance - value >= 0)
            {
                Balance -= value;
                return true;
            }
            else
                return false;
        }
    }



    /// <summary>
    /// Метод печатает состояние
    /// </summary>
    public void GetInfo()
    {
        Console.WriteLine("Номер счета: {0}\nБаланс: {1}\nТип: {2}\n", ID, Balance, Type);
    }
}
