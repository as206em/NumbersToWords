using NumbersToWords.Converter;
using System;
using System.Globalization;

namespace NumbersToWords
{
    /// <summary>
    /// convert any given positive number or a price into string word
    /// </summary>
    public class NumberToWords
    {
        /// <summary>
        /// convert number into words
        /// </summary>
        /// <param name="number">positive number to convert</param>
        /// <returns>number words as string</returns>
        public static string Convert(decimal number)
        {
            return InternalConvert(number);
        }

        /// <summary>
        /// convert a price value for a currency
        /// </summary>
        /// <param name="number">positive number to convert</param>
        /// <param name="currency">currency to use, check supported currencies on NumbersToWords.Currency</param>
        /// <returns>number words as string</returns>
        public static string Convert(decimal number, Currency currency)
        {
            return

                InternalConvert(number, currency);
        }

        /// <summary>
        /// convert number into words in a specific culture
        /// </summary>
        /// <param name="number">positive number to convert</param>
        /// <param name="cultureInfo"> culture to use</param>
        /// <returns>number words as string</returns>
        public static string Convert(decimal number, CultureInfo cultureInfo)
        {
            return InternalConvert(number, null, cultureInfo);
        }

        /// <summary>
        /// convert a price value for a currency in a specific language
        /// </summary>
        /// <param name="number">positive number to convert</param>
        /// <param name="currency">currency to use, check supported currencies on NumbersToWords.Currency</param>
        /// <param name="cultureInfo"> culture to use</param>
        /// <returns>number words as string</returns>
        public static string Convert(decimal number, Currency currency, CultureInfo cultureInfo)
        {
            return InternalConvert(number, currency, cultureInfo);
        }

        private static string InternalConvert(decimal number, Currency? currency = null, CultureInfo cultureInfo = null)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException("number must be a positive number");

            var threadCultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;

            IConverter converter;

            if ((cultureInfo == null && threadCultureInfo.TwoLetterISOLanguageName == "ar") || (cultureInfo != null && cultureInfo.TwoLetterISOLanguageName == "ar"))
                converter = new ArabicConverter();
            else if (cultureInfo == null || (cultureInfo != null && cultureInfo.TwoLetterISOLanguageName == "en"))
                converter = new EnglishConverter();
            else
                throw new NotSupportedException("Not supported culture");

            if (currency == null)
                return converter.Convert(number, null).Trim();
            else
                return converter.Convert(number, new CurrencyInfo(currency.Value)).Trim();
        }
    }
}