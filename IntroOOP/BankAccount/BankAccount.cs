namespace IntroOOP.BankAccount;

public class BankAccount
{
    private int _ID; // поле "Номер счета"

    private decimal _Balance; // поле "Баланс"

    private AccType _Type; //поле "Тип банковского счета"

    public enum AccType //  перечисление видов аккаунтов
    { 
        nullType,
        current,
        credit,
        deposit,
        budget
    }; 

    public BankAccount()        // Конструктор по умолчанию
    {
        _ID = SetID();
    }
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
    /// Метод печатает состояние
    /// </summary>
    public void GetInfo() 
    {
        Console.WriteLine("Номер счета: {0}\nБаланс: {1}\nТип: {2}", GetID(), GetBalance(), GetType());
    }


    /// <summary>
    /// Метод возвращает текущее значение поля ID
    /// </summary>
    /// <returns>ID</returns>
    public int GetID()
    {
        return _ID;
    }

    static int defaultID = 1000; // Переменная, задающая начальное значение ID

    /// <summary>
    /// Метод устанавливает уникальное значение поля ID
    /// </summary>
    public int SetID()
    {
        defaultID++;
        _ID = defaultID;
        return defaultID;
    }

    /// <summary>
    /// Метод возвращает текущее значение поля Balance
    /// </summary>
    /// <returns>Balance</returns>
    public decimal GetBalance()
    {
        return _Balance;
    }

    /// <summary>
    /// Метод возвращает текущее значение поля Type
    /// </summary>
    /// <returns>Тип</returns>
    public AccType GetType()
    {
        return _Type;
    }

    // Свойства, созданые раньше чем было нужно.
    /*
    public AccType Type 
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
    public int ID 
    {
        get  {  return _ID; }
        set { _ID = value; }
    }

    public decimal Balance 
    {
        get => _Balance;            // лямбда-синтаксис
        set => _Balance = value;  
    }
    */

}
