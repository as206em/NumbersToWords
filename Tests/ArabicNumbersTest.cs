using System.Globalization;
using Xunit;

namespace Tests
{
    public class ArabicNumbersTest
    {
        [Fact]
        private void Convert_0_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(0, new CultureInfo("ar"));
            Assert.Equal("صفر", words);
        }

        [Fact]
        private void Convert_1_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(1, new CultureInfo("ar"));
            Assert.Equal("واحد", words);
        }

        [Fact]
        private void Convert_2_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(2, new CultureInfo("ar"));
            Assert.Equal("اثنان", words);
        }

        [Fact]
        private void Convert_3_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(3, new CultureInfo("ar"));
            Assert.Equal("ثلاثة", words);
        }

        [Fact]
        private void Convert_5_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(5, new CultureInfo("ar"));
            Assert.Equal("خمسة", words);
        }

        [Fact]
        private void Convert_10_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(10, new CultureInfo("ar"));
            Assert.Equal("عشرة", words);
        }

        [Fact]
        private void Convert_11_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(11, new CultureInfo("ar"));
            Assert.Equal("أحد عشر", words);
        }

        [Fact]
        private void Convert_12_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(12, new CultureInfo("ar"));
            Assert.Equal("اثنا عشر", words);
        }

        [Fact]
        private void Convert_35_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(35, new CultureInfo("ar"));
            Assert.Equal("خمسة و ثلاثون", words);
        }

        [Fact]
        private void Convert_100_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(100, new CultureInfo("ar"));
            Assert.Equal("مائة", words);
        }

        [Fact]
        private void Convert_101_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(101, new CultureInfo("ar"));
            Assert.Equal("مائة و واحد", words);
        }

        [Fact]
        private void Convert_1491_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(1491, new CultureInfo("ar"));
            Assert.Equal("ألف و أربعمائة و واحد و تسعون", words);
        }

        [Fact]
        private void Convert_17491_toArabic()
        {
            var words = NumbersToWords.NumberToWords.Convert(17491, new CultureInfo("ar"));
            Assert.Equal("سبعة عشر ألفاً و أربعمائة و واحد و تسعون", words);
        }
    }
}