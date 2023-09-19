namespace metotlaruc
{

    class rekursifmetotlar
    {

        public static void Main(string[] args)
        {

            //Rekürsif fonksiyonlar

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;

            }
            Console.WriteLine(result);

            islemler instance = new();
            Console.WriteLine(instance.expo(2, 8));


            //Extension Konular


            string ifade = "Sefa Yeşilarslan";
            bool sonuc = ifade.boslukvarmi();
            if (sonuc)
            {
                Console.WriteLine(ifade.yazidegistir());
                Console.WriteLine(ifade.buyukharf());
                Console.WriteLine(ifade.kucukharf());
            }


            int[] dizi={98,84,55,32,43,47,23};
            dizi.siralidizi();

            dizi.ekranayazdir();

            
        }
    }

    public class islemler
    {
        public int expo(int sayi, int üs)
        {

            if (üs < 2)
            {
                return sayi;
            }
            return expo(sayi, üs - 1) * sayi;
        }

        // expo(2,8)
        // expo(2,7) * 2
        // expo(2,6) * 2 * 2
        // expo(2,5) * 2 * 2 * 2
        // expo(2,4) * 2 * 2 * 2 * 2
    }

    public static class Extension
    { // Extensions classlar static olmalı

        public static bool boslukvarmi(this string param)
        { // Extensions olması için this anahtar sözcügü kullanılır

            return param.Contains(" ");
        }

        public static string yazidegistir(this string param)
        {

            string[] dizi = param.Split(" "); //Split verilen karaktere göre ayırır.
            return string.Join("***", dizi); //Join birleştirir.
        }

        public static string buyukharf(this string param)
        {

            return param.ToUpper();
        }

        public static string kucukharf(this string param)
        {

            return param.ToLower();
        }

        public static int[] siralidizi(this int[] param){
            Array.Sort(param);
            return param;
        }

        public static void ekranayazdir(this int[] param){

            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }

    }

}
