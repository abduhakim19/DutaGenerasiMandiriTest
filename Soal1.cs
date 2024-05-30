using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutaGenerasiMandiriTest
{
    class Soal1
    {
        public static void main()
        {
            var array = new object[] { 12, 9, 30, "A", "M", 99, 82, "J", "N", "B" };

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (isAlphabetBeforeNumber(array[j], array[j + 1]))
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("[ " + string.Join(", ", array) + " ]");
        }

        public static bool isAlphabetBeforeNumber<T>(T a, T b)
        {
            if (a is string && b is string)
            {
                CompareInfo compareInfo = CultureInfo.CurrentCulture.CompareInfo;
                int result = compareInfo.Compare(Convert.ToString(a), Convert.ToString(b), CompareOptions.StringSort);
                return result > 0;
            }
            else if (a is int && b is int)
            {
                return Convert.ToInt32(a) > Convert.ToInt32(b);
            }
            else if (a is string && b is int)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
