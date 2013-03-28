using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionLibrary
{
    public class ConversionService
    {
        public static int ConvertStringToInt(string _sInput)
        {
            int iResult = int.Parse(_sInput);

            return iResult; 
        }

        public static long ConvertStringToLong(string _sInput)
        {
            long lResult = long.Parse(_sInput);

            return lResult;
        }
    }
}
