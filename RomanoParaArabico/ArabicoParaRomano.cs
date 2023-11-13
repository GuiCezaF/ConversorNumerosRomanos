using System.Text;

namespace RomanoParaArabico;
public class ArabicToRoman
{
    private static int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    private static string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

    public static string Convert(int number)
    {
        StringBuilder roman = new StringBuilder();

        for (int i = 0; i < values.Length && number > 0; i++)
        {
            while (values[i] <= number)
            {
                number -= values[i];
                roman.Append(symbols[i]);
            }
        }

        return roman.ToString();
    }
}


