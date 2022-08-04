namespace IntroOOP.Coder;


public interface ICoder
{
    string Encode(string str);
    string Decode(string str);
}
public class Coder
{
    protected string MakeCoder(string str, int key)
    {
        char[] code = new char[str.Length];
        for (int i = 0; i < code.Length; i++)
        {
            char c = str[i];
            if (!Char.IsLetter(c))
            {
                code[i] = c;
            }
            else if (Char.IsLower(c))
            {
                code[i] = (char)(c - key);
            }
            else
            {
                code[i] = (char)(c - key);
            }
        }
        return new string(code);
    }
}
