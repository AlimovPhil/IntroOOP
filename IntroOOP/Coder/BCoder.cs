using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP.Coder
{
    public class BCoder : Coder, ICoder
    {        
        private readonly int max_key = 33000;
        public string Encode(string str, int i)
        {
            int key = max_key - i;
            return MakeCoder(str, key);
        }
        public string Encode(string str)
        {
            return null;
        }

        public string Decode(string str, int i)
        {
            int key = max_key - i;
            return MakeCoder(str, -key);
        }
        public string Decode(string str)
        {
            throw new NotSupportedException("Декодирование не поддерживается");
        }
    }
}
