namespace IntroOOP;


//Создать класс рациональных чисел. В классе два поля – числитель и
//знаменатель. Предусмотреть конструктор. Определить операторы ==, != (метод
//Equals()), <, >, <=, >=.Переопределить метод ToString() для вывода
//дроби. Определить операторы преобразования типов между типом дробь, float, int.
//Определить операторы %.
public class RatNum
{
    private int _Numerator;     // Числитель
    private int _Denominator;   // Знаменатель

    public int Numerator
    {
        get => _Numerator;
        set
        {
            if (value >= 0)
                _Numerator = value;
            else
                throw new InvalidDataException("Числитель должен быть неотрицательным!");
        }
    }

    public int Denominator
    {
        get => _Denominator;
        set
        {
            if (value > 0)
                _Denominator = value;
            else
                throw new InvalidDataException("Знаменатель должен быть натуральным числом!");
        }
    }

    public RatNum()
    {
        Numerator = 1;
        Denominator = 1;
    }
    public RatNum(int numerator, int denominator) : this(numerator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    // Если указан только числитель, то знаменателю устанавливается значение 1.
    public RatNum(int numerator)
    {
        Numerator = numerator;
        Denominator = 1;
    }

    // Возвращает Наибольший общий делитель (Алгоритм Евклида)
    private static int getCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    // Возвращает Наименьшее общее кратное
    private static int getCommonMultiple(int a, int b)
    {
        return a * b / getCommonDivisor(a, b);
    }
    // Возвращает сокращенную дробь
    public RatNum Reduce()
    {
        RatNum result = this;
        int greatestCommonDivisor = getCommonDivisor(this.Numerator, this.Denominator);
        result.Numerator /= greatestCommonDivisor;
        result.Denominator /= greatestCommonDivisor;
        return result;
    }
    // Операция сложения дробей
    private static RatNum performOperationAddition(RatNum a, RatNum b)
    {
        // Наименьшее общее кратное знаменателей
        int leastCommonMultiple = getCommonMultiple(a.Denominator, b.Denominator);
        // Дополнительный множитель к первой дроби
        int additionalMultiplierFirst = leastCommonMultiple / a.Denominator;
        // Дополнительный множитель ко второй дроби
        int additionalMultiplierSecond = leastCommonMultiple / b.Denominator;
        // Умножение числителей дробей А, В на доп множ
        int tempNumeratorA = a.Numerator * additionalMultiplierFirst;
        int tempNumeratorB = b.Numerator * additionalMultiplierSecond;
        // Вычисление нового знаменателя для итоговой дроби
        int CommonDenominator = a.Denominator * additionalMultiplierFirst;

        return new RatNum(tempNumeratorA + tempNumeratorB, CommonDenominator);
    }

    // Операция вычитания дробей
    private static RatNum performOperationSubtraction(RatNum a, RatNum b)
    {
        // Наименьшее общее кратное знаменателей
        int leastCommonMultiple = getCommonMultiple(a.Denominator, b.Denominator);
        // Дополнительный множитель к первой дроби
        int additionalMultiplierFirst = leastCommonMultiple / a.Denominator;
        // Дополнительный множитель ко второй дроби
        int additionalMultiplierSecond = leastCommonMultiple / b.Denominator;
        // Умножение числителей дробей А, В на доп множ
        int tempNumeratorA = a.Numerator * additionalMultiplierFirst;
        int tempNumeratorB = b.Numerator * additionalMultiplierSecond;
        // Вычисление нового знаменателя для итоговой дроби
        int CommonDenominator = a.Denominator * additionalMultiplierFirst;

        return new RatNum(tempNumeratorA - tempNumeratorB, CommonDenominator);
    }
    // Обратная дробь
    private RatNum ReverseNum()
    {
        return new RatNum(this.Denominator, this.Numerator);
    }
    // Метод сравнения.
    public bool Equals(RatNum x)
    {
        RatNum a = this.Reduce();
        RatNum b = x.Reduce();
        return a.Numerator == b.Numerator && a.Denominator == b.Denominator;
    }
    // Перегрузка оператора "+". Сложение двух дробей.
    public static RatNum operator +(RatNum a, RatNum b)
    {
        return performOperationAddition(a, b);
    }
    // Перегрузка оператора "+". Сложение дроби с числом.
    public static RatNum operator +(RatNum a, int b)
    {
        return a + new RatNum(b);
    }
    // Перегрузка оператора "+"Сложение. числа с дробью.
    public static RatNum operator +(int a, RatNum b)
    {
        return b + a;
    }
    // Перегрузка оператора "-". Вычитание двух дробей.
    public static RatNum operator -(RatNum a, RatNum b)
    {
        return performOperationSubtraction(a, b);
    }
    // Перегрузка оператора "-".Вычитание из дроби числа.
    public static RatNum operator -(RatNum a, int b)
    {
        return a - new RatNum(b);
    }
    // Перегрузка оператора "-".Вычитание из числа дроби.
    public static RatNum operator -(int a, RatNum b)
    {
        return b - a;
    }
    
    // Перегрузка оператора "*". Умножение дробей.
    public static RatNum operator *(RatNum a, RatNum b)
    {
        return new RatNum(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
    }

    // Перегрузка оператора "*". Произведение дроби и числа.
    public static RatNum operator *(RatNum a, int b)
    {
        return a * new RatNum(b);
    }
    // Перегрузка оператора "*". Произведение числа и дроби.
    public static RatNum operator *(int a, RatNum b)
    {
        return b * a;
    }

    // Перегрузка оператора "/". Деление двух дробей.
    public static RatNum operator /(RatNum a, RatNum b)
    {
        return a * b.ReverseNum();
    }
    
    // Перегрузка оператора "/". Деление дроби на число.
    public static RatNum operator /(RatNum a, int b)
    {
        return a / new RatNum(b);
    }
    // Перегрузка оператора "/". Деление числа на дробь.
    public static RatNum operator /(int a, RatNum b)
    {
        return new RatNum(a) / b;
    }
    // Перегрузка оператора "++"
    public static RatNum operator ++(RatNum a)
    {
        return a + 1;
    }
    // Перегрузка оператора "--"
    public static RatNum operator --(RatNum a)
    {
        return a - 1;
    }

    // Перегрузка оператора "==". Сравнение дробей с помощью созданого метода.
    public static bool operator ==(RatNum a, RatNum b)
    {
        return a.Equals(b);
    }
    // Перегрузка оператора "==". Дробь и число.
    public static bool operator ==(RatNum a, int b)
    {
        return a == new RatNum(b);
    }
    // Перегрузка оператора "==". Число и дробь.
    public static bool operator ==(int a, RatNum b)
    {
        return new RatNum(a) == b;
    }
    // Перегрузка оператора "!=". Дроби.
    public static bool operator !=(RatNum a, RatNum b)
    {
        return !(a == b);
    }
    // Перегрузка оператора "!=". Дробь и число.
    public static bool operator !=(RatNum a, int b)
    {
        return a != new RatNum(b);
    }
    // Перегрузка оператора "!=". Число и дробь.
    public static bool operator !=(int a, RatNum b)
    {
        return new RatNum(a) != b;
    }
    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}
