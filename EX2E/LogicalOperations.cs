using System;
using System.Collections.Generic;
using System.Text;

namespace EX2E
{
    class LogicalOperations
    {

        public static bool q01(decimal subtotal)
        {
            return subtotal >= 250 && subtotal < 500;
        }
        public static bool q02(int timeInService)
        {
            return timeInService <= 4 || timeInService >= 12;
        }

        public static bool q03(bool isValid, int years, int counter)
        {
            return isValid == true && counter++ < years;
        }

        public static bool q04(bool isValid, int years, int counter)
        {
            return isValid == true && counter++ < years;
        }

        public static bool q05(bool isValid, int years, int counter)
        {
            return isValid == true && counter++ < years;
        }

        public static bool q06(bool isValid, int years, int counter)
        {
            return isValid == true && counter++ < years;
        }

        public static bool q07(DateTime startDate, DateTime expeirationDate, DateTime date, bool isValid)
        {
            return date > startDate && date< expirationDate || isValid == true;
        }

        public static bool q08(decimal thisYTD, decimal lastYTD, string empType, int startYear, int currentYear)
        {
            return ((thisYTD > lastYTD) || empType == "Part time") && startYear < currentYear;
        }
        public static bool q09(int counter, int years)
        {
            return !(counter++ >= years);
        }
        public static bool q10(int a, int b, int c, int d)
        {
            return !(a > b && b < c || c < d);
        }
    }
}
