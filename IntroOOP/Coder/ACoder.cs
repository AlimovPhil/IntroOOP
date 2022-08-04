namespace IntroOOP.Coder;

public class ACoder: Coder, ICoder
{
    /// <summary>
    /// Дешифровка строки
    /// </summary>
    /// <param name="str">Введенная строка</param>
    /// <returns>Дешифрованная строка</returns>
    public string Decode(string str)
    {
        return MakeCoder(str, 1);
    }
    /// <summary>
    /// Шифрование
    /// </summary>
    /// <param name="str">Введенная строка</param>
    /// <returns>Зашифрованная строка</returns>
    public string Encode(string str)
    {
        return MakeCoder(str, -1);
    }
}