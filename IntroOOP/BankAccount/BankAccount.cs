namespace IntroOOP.BankAccount;

public class BankAccount
{
    private int _ID; // поле "Номер счета"

    private decimal _Balance; // поле "Баланс"

    private AccType _Type; //поле "Тип банковского счета"

    public enum AccType //  перечисление видов аккаунтов
    { 
        current,
        credit,
        deposit,
        budget
    }; 
    
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
    /// Метод устанавливает значение поля Balance
    /// </summary>
    /// <param name="value">Значение</param>
    public void SetBalance(decimal value)
    {
        _Balance = value;
    }
    /// <summary>
    /// Метод возвращает текущее значение поля Type
    /// </summary>
    /// <returns>Тип</returns>
    public AccType GetType()
    {
        return _Type;
    }

    /// <summary>
    /// Метод устанавливает значение поля Type
    /// </summary>
    /// <param name="type">значение</param>
    public void SetType(AccType type)
    {
        _Type = type;
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
