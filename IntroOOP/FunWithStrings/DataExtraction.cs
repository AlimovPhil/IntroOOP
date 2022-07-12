using System.Text;


namespace IntroOOP.FunWithStrings;

public class DataExtraction
{
    public static string SearchMail(ref string s)
    {
        var values = s.Split('\n');
       
        foreach (var value_str in values)
        {
            var vv = value_str.Split('&');
            s = vv[1].Trim('\r', ' ');
        }
        return s;   
    }
}