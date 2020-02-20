using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class MathHelper
    {
        public static int square(int value)
        {
            return value * value;
        }

        public static int square_namedParameter(int aValue)
        {
            return aValue * aValue;
        }

        public static int Addition_Mathhelp(int number_1=20,int number_2=10)
        {
            return number_1 + number_2;
        }

        public static void OutKeyword(out int value)  // when ref method is called the corresponding variable used for calling this method does not need to be initialized with a certain value
        {
            value = 10;
        }

        public static void RefKeyword(ref int value) // when ref method is called the corresponding variable used for calling this method needs to be initialized with a certain value
        {
            value = 20;
        }
    }
}
