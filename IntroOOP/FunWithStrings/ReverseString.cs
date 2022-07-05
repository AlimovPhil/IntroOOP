using System.Text;

namespace IntroOOP.FunWithStrings;


public class ReverseString
{
    /// <summary>
    /// "Ручной" метод реверсии строки
    /// </summary>
    /// <param name="str">Входная строка</param>
    /// <returns>Строка в обратном порядке</returns>
    public static string SimpleReverse(string str)
    {
        char[] chars = str.ToCharArray();

        for (int i = 0; i < str.Length / 2; i++)
        {
            char ch = chars[i];
            chars[i] = chars[str.Length - i - 1];
            chars[str.Length - i - 1] = ch;
        }

        string result = new (chars);

        return result;
    }

    /// <summary>
    /// Метод реверсии строки для тех кто не думает о памяти (или только начинает учить с#)
    /// </summary>
    /// <param name="str">Входная строка</param>
    /// <returns>Строка в обратном порядке</returns>
    public static string BadReverse(string str)
    {
        //Console.WriteLine("Input: {0}", str);
        char[] chars = str.ToCharArray();

        Array.Reverse(chars);

        var reversed = new string(chars);
        //foreach (char c in chars) { reversed += c; } <= Использовал на курсе "Введение в C#".

        return reversed;
    }

    
    /// <summary>
    /// Оптимизированный метод (уменьшение используемой памяти)
    /// </summary>
    /// <param name="str">Входная строка</param>
    /// <returns>Строка в обратном порядке</returns>
    public static string GoodReverse(string str)
    {
        StringBuilder builder = new();

        for (int i = str.Length - 1; i >= 0; i--)
        {
            builder.Append(str[i]);
        }

        var result = builder.ToString();

        return result;
    }

}
