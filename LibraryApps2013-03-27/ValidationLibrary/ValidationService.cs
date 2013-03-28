using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationLibrary
{
    public class ValidationService
    {
        public static bool ValidateInt(string _sInput)
        {
            int iResult = -1;
            bool bParsed = int.TryParse(_sInput, out iResult);
         
            return bParsed;
        }

        public static bool ValidateLong(string _sInput)
        {
            long longResult = 0L; 
            bool bParsed = long.TryParse(_sInput, out longResult);
            return bParsed; 
        }
    }
}
