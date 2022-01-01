using System.ComponentModel;

namespace NumbersToWords
{
    public enum Currency
    {
        [Description("United States dollar")]
        USD,

        [Description("Euro")]
        EUR,

        [Description("Japanese yen")]
        JPY,

        [Description("Chinese yuan renminbi")]
        CNY,

        [Description("Syrian pound")]
        SYP,

        [Description("Australian dollar")]
        AUD,

        [Description("Canadian dollar")]
        CAD,

        [Description("Jordanian dinar")]
        JOD,

        [Description("United Arab Emirates dirham")]
        AED,

        [Description("Saudi riyal")]
        SAR,

        [Description("Egyptian pound")]
        EGP,

        [Description("Tunisian dinar")]
        TND,

        [Description("Gold")]
        GOLD,
    }
}