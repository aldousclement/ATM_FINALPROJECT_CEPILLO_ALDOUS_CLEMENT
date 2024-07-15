using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reviewer1
{
    internal class EvaluationPincode
    {
        private static int pinCode = 043004;

        public static bool PinCodeEvaluation(int enteredPin)
        {
            bool result = false;

            if (enteredPin == pinCode)
            {
                result = true;
            }
            return result;
        }
    }
}