namespace IntroOOP.RationalNumbers;

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
    private static int GetCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    // Возвращает Наименьшее общее кратное (наименьший общий знаменатель)
    private static int GetCommonMultiple(int a, int b)
    {
        return a * b / GetCommonDivisor(a, b);
    }
    // Приведение к общему знаменателю
    private static void CommonDenominator(RatNum a, RatNum b, out RatNum x, out RatNum y)
    {
        // Наименьшее общее кратное знаменателей
        int leastCommonMultiple = GetCommonMultiple(a.Denominator, b.Denominator);
        // Дополнительный множитель к первой дроби
        int additionalMultiplierFirst = leastCommonMultiple / a.Denominator;
        // Дополнительный множитель ко второй дроби
        int additionalMultiplierSecond = leastCommonMultiple / b.Denominator;
        // Умножение числителей дробей А, В на доп множ
        x = new RatNum(a.Numerator * additionalMultiplierFirst, a.Denominator * additionalMultiplierFirst);
        y = new RatNum(b.Numerator * additionalMultiplierSecond, b.Denominator * additionalMultiplierSecond);
    }
    // Возвращает сокращенную дробь
    public RatNum Reduce()
    {
        RatNum result = this;
        int greatestCommonDivisor = GetCommonDivisor(this.Numerator, this.Denominator);
        result.Numerator /= greatestCommonDivisor;
        result.Denominator /= greatestCommonDivisor;
        return result;
    }
    // Операция сложения дробей
    private static RatNum PerformOperationAddition(RatNum a, RatNum b)
    {
        // Наименьшее общее кратное знаменателей
        int leastCommonMultiple = GetCommonMultiple(a.Denominator, b.Denominator);
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
    private static RatNum PerformOperationSubtraction(RatNum a, RatNum b)
    {
        // Наименьшее общее кратное знаменателей
        int leastCommonMultiple = GetCommonMultiple(a.Denominator, b.Denominator);
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
        if (x is null) return false;
        RatNum a = this.Reduce();
        RatNum b = x.Reduce();
        return a.Numerator == b.Numerator && a.Denominator == b.Denominator;
    }
    // Метод сравнения двух дробей
    // 0, если дроби равны
    // 1, если А дробь больше В
    // -1, если А меньше В
    private int CompareTo(RatNum x)
    {
        if (this.Equals(x))
        {
            return 0;
        }
        RatNum a = this.Reduce();
        RatNum b = x.Reduce();
        if (a.Numerator / a.Denominator > b.Numerator / b.Denominator)
            return 1;
        else return -1;
    }
    // Перегрузка оператора "+". Сложение двух дробей.
    public static RatNum operator +(RatNum a, RatNum b)
    {
        return PerformOperationAddition(a, b);
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
        return PerformOperationSubtraction(a, b);
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
        return Equals(a, b);
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
    // Перегрузка оператора ">" для дробей.
    public static bool operator >(RatNum a, RatNum b)
    {
        return a.CompareTo(b) > 0;
    }
    // Перегрузка оператора ">" для дроби и числа.
    public static bool operator >(RatNum a, int b)
    {
        return a > new RatNum(b);
    }
    // Перегрузка оператора ">" для числа и дроби.
    public static bool operator >(int a, RatNum b)
    {
        return new RatNum(a) > b;
    }
    // Перегрузка оператора "<" для дробей.
    public static bool operator <(RatNum a, RatNum b)
    {
        return a.CompareTo(b) < 0;
    }
    // Перегрузка оператора "<" для дроби и числа.
    public static bool operator <(RatNum a, int b)
    {
        return a < new RatNum(b);
    }
    // Перегрузка оператора "<" для числа и дроби.
    public static bool operator <(int a, RatNum b)
    {
        return new RatNum(a) < b;
    }
    // Перегрузка оператора ">=" для двух дробей.
    public static bool operator >=(RatNum a, RatNum b)
    {
        return a.CompareTo(b) >= 0;
    }
    // Перегрузка оператора ">=" для дроби и числа.
    public static bool operator >=(RatNum a, int b)
    {
        return a >= new RatNum(b);
    }
    // Перегрузка оператора ">=" для числа и дроби.
    public static bool operator >=(int a, RatNum b)
    {
        return new RatNum(a) >= b;
    }
    // Перегрузка оператора "<=" для двух дробей.
    public static bool operator <=(RatNum a, RatNum b)
    {
        return a.CompareTo(b) <= 0;
    }
    // Перегрузка оператора "<=" для дроби и числа.
    public static bool operator <=(RatNum a, int b)
    {
        return a <= new RatNum(b);
    }
    // Перегрузка оператора "<=" для числа и дроби
    public static bool operator <=(int a, RatNum b)
    {
        return new RatNum(a) <= b;
    }
    // Перегрузка оператора "%" для дробей.
    public static RatNum operator %(RatNum a, RatNum b)
    {
        CommonDenominator(a, b, out RatNum x, out RatNum y);
        while (x.Numerator >= y.Numerator)
        {
            x.Numerator -= y.Numerator;
        }
        return new RatNum(x.Numerator, x.Denominator);
    }
    // Перегрузка оператора "%" для дроби и числа.
    public static RatNum operator %(RatNum a, int b)
    {
        return a % new RatNum(b);
    }
    // Перегрузка оператора "%" для числа и дроби.
    public static RatNum operator %(int a, RatNum b)
    {
        return new RatNum(a) % b;
    }
    // Явное преобразование в тип float
    public static explicit operator float(RatNum a)
    {
        return (float)a.Numerator / (float)a.Denominator;
    }
    // Явное преобразование в тип int
    public static explicit operator int(RatNum a)
    {
        return (int)a.Numerator / (int)a.Denominator;
    }
    // Явное преобразование в тип double
    public static explicit operator double(RatNum a)
    {
        return (double)a.Numerator / (double)a.Denominator;
    }
    public override string ToString()
    {
        if (this.Numerator == 0)
        {
            return "0";
        }
        string result = "";
        if (this.Numerator == this.Denominator)
        {
            return "1";
        }
        if (this.Denominator == 1)
        {
            return result + this.Numerator;
        }
        return $"{result + Numerator}/{Denominator}";
    }
}