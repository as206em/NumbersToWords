using System.Globalization;
using Xunit;

namespace Tests
{
    public class EnglishNumbersTest
    {
        [Fact]
        private void Convert_0_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(0, new CultureInfo("en"));
            Assert.Equal("Zero", words);
        }

        [Fact]
        private void Convert_1_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(1, new CultureInfo("en"));
            Assert.Equal("One", words);
        }

        [Fact]
        private void Convert_2_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(2, new CultureInfo("en"));
            Assert.Equal("Two", words);
        }

        [Fact]
        private void Convert_3_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(3, new CultureInfo("en"));
            Assert.Equal("Three", words);
        }

        [Fact]
        private void Convert_5_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(5, new CultureInfo("en"));
            Assert.Equal("Five", words);
        }

        [Fact]
        private void Convert_10_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(10, new CultureInfo("en"));
            Assert.Equal("Ten", words);
        }

        [Fact]
        private void Convert_11_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(11, new CultureInfo("en"));
            Assert.Equal("Eleven", words);
        }

        [Fact]
        private void Convert_12_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(12, new CultureInfo("en"));
            Assert.Equal("Twelve", words);
        }

        [Fact]
        private void Convert_35_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(35, new CultureInfo("en"));
            Assert.Equal("Thirty Five", words);
        }

        [Fact]
        private void Convert_100_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(100, new CultureInfo("en"));
            Assert.Equal("One Hundred", words);
        }

        [Fact]
        private void Convert_101_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(101, new CultureInfo("en"));
            Assert.Equal("One Hundred One", words);
        }

        [Fact]
        private void Convert_1491_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(1491, new CultureInfo("en"));
            Assert.Equal("One Thousand Four Hundred Ninety One", words);
        }

        [Fact]
        private void Convert_17491_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(17491, new CultureInfo("en"));
            Assert.Equal("سبعة عشر ألفاً و أربعمائة و واحد و تسعون", words);
        }
    }
}