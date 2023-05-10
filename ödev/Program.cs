using System;

class BinarySearchExample
{
    static int BinarySearch(int[] Dizi, int EnKucukSayi, int EnBuyukSayi, int x)
    {
        //While döngüsüne sokarak dizideki elemanları sıraladım
        while (EnKucukSayi <= EnBuyukSayi)
        {
            int islem = EnKucukSayi + (EnBuyukSayi - EnKucukSayi) / 2;
            if (Dizi[islem] == x)
                return islem;
            else if (Dizi[islem] < x)
                EnKucukSayi = islem + 1;
            else
                EnBuyukSayi = islem - 1;
        }
        return -1;
    }

    static void Main()
    {
        int[] Dizi = { 4, 8, 3, 84, 47, 76, 9, 24, 68 };

        // Verilen diziyi sıraladım
        Array.Sort(Dizi);

        // Aranacak elemanı kullanıcıdan istedim
        Console.Write("Aranacak elemanı girin: ");

        // Binary Search algoritmasıyla arama işlemini gerçekleştirdim
        int result = BinarySearch(Dizi, 0, Dizi.Length - 1, Convert.ToInt32(Console.ReadLine()));

        // Sonucu ekrana yazdırın
        if (result == -1)
            Console.WriteLine("Aranan eleman dizide bulunamadı.");
        else
            Console.WriteLine("Aranan eleman dizinin {0} indeksinde bulundu.", result);
    }
}
