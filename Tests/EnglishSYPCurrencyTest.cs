using System.Globalization;
using Xunit;

namespace Tests
{
    public class EnglishSYPCurrencyTest
    {
        [Fact]
        private void Convert_0_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(0, NumbersToWords.Currency.SYP, new CultureInfo("en"));
            Assert.Equal("Zero", words);
        }

        [Fact]
        private void Convert_1_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(1, NumbersToWords.Currency.SYP, new CultureInfo("en"));
            Assert.Equal("One Syrian Pounds", words);
        }

        [Fact]
        private void Convert_2_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(2, NumbersToWords.Currency.SYP, new CultureInfo("en"));
            Assert.Equal("Two Syrian Pounds", words);
        }

        [Fact]
        private void Convert_3_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(3, NumbersToWords.Currency.SYP, new CultureInfo("en"));
            Assert.Equal("Three Syrian Pounds", words);
        }

        [Fact]
        private void Convert_5_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(5, NumbersToWords.Currency.SYP, new CultureInfo("en"));
            Assert.Equal("Five Syrian Pounds", words);
        }

        [Fact]
        private void Convert_10_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(10, NumbersToWords.Currency.SYP, new CultureInfo("en"));
            Assert.Equal("Ten Syrian Pounds", words);
        }

        [Fact]
        private void Convert_11_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(11, NumbersToWords.Currency.SYP, new CultureInfo("en"));
            Assert.Equal("Eleven Syrian Pounds", words);
        }

        [Fact]
        private void Convert_12_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(12, NumbersToWords.Currency.SYP, new CultureInfo("en"));
            Assert.Equal("Twelve Syrian Pounds", words);
        }

        [Fact]
        private void Convert_35_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(35, NumbersToWords.Currency.SYP, new CultureInfo("en"));
            Assert.Equal("Thirty Five Syrian Pounds", words);
        }

        [Fact]
        private void Convert_100_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(100, NumbersToWords.Currency.SYP, new CultureInfo("en"));
            Assert.Equal("One Hundred Syrian Pounds", words);
        }

        [Fact]
        private void Convert_101_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(101, NumbersToWords.Currency.SYP, new CultureInfo("en"));
            Assert.Equal("One Hundred One Syrian Pounds", words);
        }

        [Fact]
        private void Convert_1491_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(1491, NumbersToWords.Currency.SYP, new CultureInfo("en"));
            Assert.Equal("ألف و أربعمائة و إحدى و تسعون ليرة سورية", words);
        }

        [Fact]
        private void Convert_17491_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(17491, NumbersToWords.Currency.SYP, new CultureInfo("en"));
            Assert.Equal("سبعة عشر ألفاً و أربعمائة و إحدى و تسعون ليرة سورية", words);
        }
    }
}