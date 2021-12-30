using NumbersToWords.Converter;
using System;
using System.Globalization;

namespace NumbersToWords
{
    public class NumberToWords
    {
        public static string Convert(decimal number)
        {
            return InternalConvert(number);
        }

        public static string Convert(decimal number, Currency currency)
        {
            return InternalConvert(number, currency);
        }

        public static string Convert(decimal number, CultureInfo cultureInfo)
        {
            return InternalConvert(number, null, cultureInfo);
        }

        public static string Convert(decimal number, Currency currency, CultureInfo cultureInfo)
        {
            return InternalConvert(number, currency, cultureInfo);
        }

        private static string InternalConvert(decimal number, Currency? currency = null, CultureInfo cultureInfo = null)
        {
            if (cultureInfo is null)
                cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;

            IConverter converter;

            switch (cultureInfo.TwoLetterISOLanguageName)
            {
                case "en":
                    converter = new EnglishConverter();
                    break;

                case "ar":
                    converter = new ArabicConverter();
                    break;

                default:
                    throw new NotSupportedException("Not supported culture");
            }

            return converter.Convert(number, currency.HasValue ? new CurrencyInfo(currency.Value) : null);
        }
    }
}