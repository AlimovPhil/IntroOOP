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
    /// Перевод денег с одного счета на другой
    /// </summary>
    /// <param name="source">Счет-донор</param>
    /// <param name="amount">Сумма перевода</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">Проверка</exception>
    public bool TransferMoney(BankAccount source, decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Размер перевода не может быть отрицательным!");
        }
        else
        {
            if (source.Balance < amount)
            {
                return false;
            }
            else
            {
                source.Balance -= amount;
                Balance += amount;
                return true;
            }

        }

    }

    /// <summary>
    /// Метод печатает состояние
    /// </summary>
    public void GetInfo() { Console.WriteLine("Номер счета: {0}\nБаланс: {1:N} RUB\nТип: {2}\n", ID, Balance, Type); }


    public static bool operator ==(BankAccount a, BankAccount b) => Equals(a, b);
    public static bool operator !=(BankAccount a, BankAccount b) => !(a == b);

    public override bool Equals(object? obj)
    {
        //if (obj == null) return false;
        //if(obj.GetType() != typeof(BankAccount)) return false;
        //var other = (BankAccount)obj;
        //return Balance == other.Balance && Type == other.Type;

        //Можно воспользоваться "сопоставлением с образцом"

        if (obj is not BankAccount other)
            return false;
        return _ID == other._ID;  // если Id уникален, то остальное можно не проверять.
    }

    public override int GetHashCode()
    {
        //return HashCode.Combine(Balance, Type);
        var hash = 397;
        unchecked
        {
            hash = (hash * 397) ^ Balance.GetHashCode();
            hash = (hash * 397) ^ Type.GetHashCode();
        }
        return hash;
    }

    public override string ToString()
    {
        return $"Счет № { ID} Баланс: { Balance}RUB Тип: { Type}";
    }
}
