namespace RomanoParaArabico;
public class RomanToArabic
{
    private static Dictionary<char, int> map = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    public static int Convert(string roman)
    {
        int number = 0;
        for (int i = 0; i < roman.Length; i++)
        {
            if (i + 1 < roman.Length && map[roman[i]] < map[roman[i + 1]])
            {
                number -= map[roman[i]];
            }
            else
            {
                number += map[roman[i]];
            }
        }
        return number;
    }
}
