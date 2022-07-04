namespace IntroOOP.BankAccount;

public class BankAccount
{
    private int _ID; // поле "Номер счета"

    private decimal _Balance; // поле "Баланс"

    private AccType _Type; //поле "Тип банковского счета"
    static int defaultID = 1000; // Переменная, задающая начальное значение ID

    public enum AccType //  перечисление видов аккаунтов
    { 
        nullType,
        current,
        credit,
        deposit,
        budget
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
    public int SetID()
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
        private set { _ID = SetID(); } // Приватное свойство, чтобы номер счета нельзя было поменять
    }

    public decimal Balance  // you're my butterfly, SUGAR baby!
    {
        get => _Balance;            // лямбда-синтаксис
        set => _Balance = value;
    }

    /// <summary>
    /// Метод печатает состояние
    /// </summary>
    public void GetInfo() 
    {
        Console.WriteLine("Номер счета: {0}\nБаланс: {1}\nТип: {2}", ID, Balance, Type);
    }

    


}
