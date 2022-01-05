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
*Output*: ����� ������.

`NumberToWords.Convert(22, Currency.USD);`
*Output*: Twinty Two USD.

`NumberToWords.Convert(22, Currency.SYP, new CultureInfo("ar"));`
*Output*: ���� ������ ���� �����.

`NumberToWords.Convert(22, Currency.SYP, new CultureInfo("en"));`
*Output*: Twinty Two Syrian pounds.
