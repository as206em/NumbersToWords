using System;

namespace NumbersToWords.Converter
{
    /// <summary>
    /// English converter
    /// </summary>
    internal class EnglishConverter : IConverter
    {
        #region Parameters & Fields

        private long _intergerValue;

        private int _decimalValue;

        private static string[] Ones = new string[]
        {
            "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
            "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };

        private static string[] Tens = new string[]
        {
            "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };

        private static string[] Group = new string[]
        {
            "Hundred", "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion", "Sextillian",
            "Septillion", "Octillion", "Nonillion", "Decillion", "Undecillion", "Duodecillion", "Tredecillion",
            "Quattuordecillion", "Quindecillion", "Sexdecillion", "Septendecillion", "Octodecillion", "Novemdecillion",
            "Vigintillion", "Unvigintillion", "Duovigintillion", "10^72", "10^75", "10^78", "10^81", "10^84", "10^87",
            "Vigintinonillion", "10^93", "10^96", "Duotrigintillion", "Trestrigintillion"
        };

        #endregion Parameters & Fields

        public string Convert(decimal Number, CurrencyInfo Currency)
        {
            Decimal tempNumber = Number;

            if (tempNumber == 0)
                return "Zero";

            string decimalString = ProcessGroup(_decimalValue);

            string retVal = String.Empty;

            int group = 0;

            if (tempNumber < 1)
            {
                retVal = Ones[0];
            }
            else
            {
                while (tempNumber >= 1)
                {
                    int numberToProcess = (int)(tempNumber % 1000);

                    tempNumber = tempNumber / 1000;

                    string groupDescription = ProcessGroup(numberToProcess);

                    if (groupDescription != String.Empty)
                    {
                        if (group > 0)
                        {
                            retVal = String.Format("{0} {1}", Group[group], retVal);
                        }

                        retVal = String.Format("{0} {1}", groupDescription, retVal);
                    }

                    group++;
                }
            }

            String formattedNumber = String.Empty;

            formattedNumber += (retVal != String.Empty) ? retVal : String.Empty;
            formattedNumber += (retVal != String.Empty)
                ? (_intergerValue == 1 ? (Currency?.EnglishCurrencyName ?? "") : (Currency?.EnglishPluralCurrencyName ?? ""))
                : String.Empty;
            formattedNumber += (decimalString != String.Empty) ? " and " : String.Empty;
            formattedNumber += (decimalString != String.Empty) ? decimalString : String.Empty;
            formattedNumber += (decimalString != String.Empty)
                ? " " + (_decimalValue == 1 ? (Currency?.EnglishCurrencyPartName ?? "") : (Currency?.EnglishPluralCurrencyPartName ?? ""))
                : String.Empty;

            return formattedNumber;
        }

        private string ProcessGroup(int groupNumber)
        {
            int tens = groupNumber % 100;

            int hundreds = groupNumber / 100;

            string retVal = String.Empty;

            if (hundreds > 0)
            {
                retVal = String.Format("{0} {1}", Ones[hundreds], Group[0]);
            }

            if (tens > 0)
            {
                if (tens < 20)
                {
                    retVal += ((retVal != String.Empty) ? " " : String.Empty) + Ones[tens];
                }
                else
                {
                    int ones = tens % 10;

                    tens = (tens / 10) - 2; // 20's offset

                    retVal += ((retVal != String.Empty) ? " " : String.Empty) + Tens[tens];

                    if (ones > 0)
                    {
                        retVal += ((retVal != String.Empty) ? " " : String.Empty) + Ones[ones];
                    }
                }
            }

            return retVal;
        }
    }
}