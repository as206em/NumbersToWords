namespace NumbersToWords.Converter
{
    /// <summary>
    /// per language converter interface
    /// </summary>
    internal interface IConverter
    {
        string Convert(decimal Number, CurrencyInfo Currency);
    }
}