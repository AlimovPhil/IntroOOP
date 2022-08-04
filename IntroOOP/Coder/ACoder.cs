namespace IntroOOP.Coder;

public class ACoder: Coder, ICoder
{
    public string Decode(string str)
    {
        return MakeCoder(str, 1);
    }

    public string Encode(string str)
    {
        return MakeCoder(str, -1);
    }
}