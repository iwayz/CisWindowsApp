using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CisWindowsFormsApp
{
    public static class SpellNumber
    {
        public static string Spell(int number)
        {
            bool isMinus = number < 0;
            number = Math.Abs(number);

            if (number > 999999999)
                return "### Nominal terlalu besar. Maksimal nominal adalah 999.999.999 ###";

            int n, m;
            string result = string.Empty;

            n = number / 1000000;
            m = number % 1000000;
            if (n > 0)
                result += SpellHundreds(n) + " Juta ";

            n = m / 1000;
            m = m % 1000;
            if (n > 0)
                result += SpellHundreds(n) + (n == 1 ? " Seribu " : " Ribu");
           
            result += SpellHundreds(m) + "Rupiah";

            result = isMinus ? $"(Minus) {result}" : result;
            return Regex.Replace(result, @"\s+", " ").Trim();
        }

        private static string SpellHundreds(int number)
        {
            string result = string.Empty;
            int n;
            n = number / 100;
            number = number % 100;
            result += GetHundreds(n);

            if (number >= 20)
            {
                n = number / 10;
                number = number % 10;
                result += GetTens(n);
            }
                
            result += GetTeensUnit(number);

            return result;
        }

        private static string GetHundreds(int number)
        {
            if (number <= 0) return string.Empty;

            return number == 1 ? " Seratus" : string.Concat(GetTeensUnit(number), " Ratus ");
        }

        private static string GetTens(int number)
        {
            string result = string.Empty;
            switch (number)
            {
                case 2:
                    result = "  Dua Puluh ";
                    break;
                case 3:
                    result = " Tiga Puluh ";
                    break;
                case 4:
                    result = " Empat Puluh ";
                    break;
                case 5:
                    result = " Lima Puluh ";
                    break;
                case 6:
                    result = " Enam Puluh ";
                    break;
                case 7:
                    result = " Tujuh Puluh ";
                    break;
                case 8:
                    result = " Delapan Puluh ";
                    break;
                case 9:
                    result = " Sembilan Puluh ";
                    break;
            }

            return result;
        }

        private static string GetTeensUnit(int number)
        {
            string result = string.Empty;
            switch (number)
            {
                case 1:
                    result = " Satu ";
                    break;
                case 2:
                    result = " Dua ";
                    break;
                case 3:
                    result = " Tiga ";
                    break;
                case 4:
                    result = " Empat ";
                    break;
                case 5:
                    result = " Lima ";
                    break;
                case 6:
                    result = " Enam ";
                    break;
                case 7:
                    result = " Tujuh ";
                    break;
                case 8:
                    result = " Delapan ";
                    break;
                case 9:
                    result = " Sembilan ";
                    break;
                case 10:
                    result = " SePuluh  ";
                    break;
                case 11:
                    result = " Sebelas ";
                    break;
                case 12:
                    result = " Dua Belas ";
                    break;
                case 13:
                    result = " Tiga Belas ";
                    break;
                case 14:
                    result = " Empat Belas ";
                    break;
                case 15:
                    result = " Lima Belas ";
                    break;
                case 16:
                    result = " Enam Belas ";
                    break;
                case 17:
                    result = " Tujuh Belas ";
                    break;
                case 18:
                    result = " Delapan Belas ";
                    break;
                case 19:
                    result = " Sembilan Belas ";
                    break;
                default:
                    result = " ";
                    break;
            }

            return result;
        }
    }
}
