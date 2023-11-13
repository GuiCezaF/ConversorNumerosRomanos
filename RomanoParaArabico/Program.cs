
namespace RomanoParaArabico
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int arabic = 2004;
            string roman = ArabicToRoman.Convert(arabic);
            Console.WriteLine(roman);  


            string romanInput = "MMIV";
            int arabicOutput = RomanToArabic.Convert(romanInput);
            Console.WriteLine(arabicOutput); 


        }
    }
}
