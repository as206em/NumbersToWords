using System.Globalization;
using Xunit;

namespace Tests
{
    public class ArabicSYPCurrencyTest
    {
        [Fact]
        private void Convert_0_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(0, NumbersToWords.Currency.SYP, new CultureInfo("ar"));
            Assert.Equal("صفر", words);
        }

        [Fact]
        private void Convert_1_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(1, NumbersToWords.Currency.SYP, new CultureInfo("ar"));
            Assert.Equal("ليرة سورية", words);
        }

        [Fact]
        private void Convert_2_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(2, NumbersToWords.Currency.SYP, new CultureInfo("ar"));
            Assert.Equal("ليرتان سوريتان", words);
        }

        [Fact]
        private void Convert_3_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(3, NumbersToWords.Currency.SYP, new CultureInfo("ar"));
            Assert.Equal("ثلاث ليرات سورية", words);
        }

        [Fact]
        private void Convert_5_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(5, NumbersToWords.Currency.SYP, new CultureInfo("ar"));
            Assert.Equal("خمس ليرات سورية", words);
        }

        [Fact]
        private void Convert_10_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(10, NumbersToWords.Currency.SYP, new CultureInfo("ar"));
            Assert.Equal("عشر ليرات سورية", words);
        }

        [Fact]
        private void Convert_11_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(11, NumbersToWords.Currency.SYP, new CultureInfo("ar"));
            Assert.Equal("إحدى عشرة ليرة سورية", words);
        }

        [Fact]
        private void Convert_12_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(12, NumbersToWords.Currency.SYP, new CultureInfo("ar"));
            Assert.Equal("اثنتا عشرة ليرة سورية", words);
        }

        [Fact]
        private void Convert_35_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(35, NumbersToWords.Currency.SYP, new CultureInfo("ar"));
            Assert.Equal("خمس و ثلاثون ليرة سورية", words);
        }

        [Fact]
        private void Convert_100_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(100, NumbersToWords.Currency.SYP, new CultureInfo("ar"));
            Assert.Equal("مائة ليرة سورية", words);
        }

        [Fact]
        private void Convert_101_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(101, NumbersToWords.Currency.SYP, new CultureInfo("ar"));
            Assert.Equal("مائة و إحدى ليرة سورية", words);
        }

        [Fact]
        private void Convert_1491_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(1491, NumbersToWords.Currency.SYP, new CultureInfo("ar"));
            Assert.Equal("ألف و أربعمائة و إحدى و تسعون ليرة سورية", words);
        }

        [Fact]
        private void Convert_17491_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(17491, NumbersToWords.Currency.SYP, new CultureInfo("ar"));
            Assert.Equal("سبعة عشر ألفاً و أربعمائة و إحدى و تسعون ليرة سورية", words);
        }
    }
}