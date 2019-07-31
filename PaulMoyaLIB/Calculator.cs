using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulMoyaLIB
{
    public class Calculator
    {
        public static int Calculate(string str)
        {
            if (str == null || str.Length == 0) return -1;
            int count=0, level=0,gbChr=0;
            bool isGarbage=false;

            for (int i = 0; i < str.Length; i++)
            {
                char chr=str[i];
                if (chr=='!') i++;
                else if (chr=='>') isGarbage=false;
                else if (isGarbage) gbChr++;
                else if (chr=='<') isGarbage=true;
                else if (!isGarbage && chr=='{') count += ++level;
                else if (!isGarbage && chr=='}') level--;
            }
            return count;
        }

    }
}
