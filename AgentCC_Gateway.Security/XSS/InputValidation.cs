using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgentCC_Gateway.Security.XSS
{
    public static class InputValidation
    {
        /// <summary>
        /// walidacja danych wejsciowych w celu zapobieganiu atakom XSS
        /// </summary>
        /// <param name="input"> dane wejsciowe w formie stringu</param>
        /// <returns></returns>
        public static bool IsSafeInput<T>(T input) where T : IConvertible
        {
            if (typeof(T) == typeof(string))
            {
                if (String.IsNullOrEmpty(input.ToString()))
                    return false;
            }

            var regex = new Regex(@"^[a-zA-Z0-9 .,]+$");
            return regex.IsMatch(input.ToString()!);
        }
    }
}
