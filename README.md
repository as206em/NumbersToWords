[![Run Tests](https://github.com/as206em/NumbersToWords/actions/workflows/RunTests.yml/badge.svg)](https://github.com/as206em/NumbersToWords/actions/workflows/RunTests.yml)

# NumbersToWords
Simple helper to convert numbers and prices into words with multiple languages and currencies support.

Support languages:
- Arabic
- English

Supported currencies:
- SYP
- USD
- AUD

---

### Examples:
`NumberToWords.Convert(22);`
*Output*: Twinty Two.

`NumberToWords.Convert(22, new CultureInfo("ar"));`
*Output*: ÇËäÇä æÚÔÑæä.

`NumberToWords.Convert(22, Currency.USD);`
*Output*: Twinty Two USD.

`NumberToWords.Convert(22, Currency.SYP, new CultureInfo("ar"));`
*Output*: ÇËäÇ æÚÔÑæä áíÑÉ ÓæÑíÉ.

`NumberToWords.Convert(22, Currency.SYP, new CultureInfo("en"));`
*Output*: Twinty Two Syrian pounds.
