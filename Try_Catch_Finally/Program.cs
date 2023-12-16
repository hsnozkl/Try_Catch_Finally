namespace HataYonetimi;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Bir sayi giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmis oldugunuz sayi :" + sayi);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Hata: "+ ex.Message.ToString());
        }
        finally
        {
           Console.Write("Islem tamamlandi.");
        }

        try
        {
            int a = int.Parse(null);
            int b = int.Parse("test");
            int c = int.Parse("-20000000000");
        }
        catch(ArgumentNullException ex)
        {
            Console.WriteLine("Bos deger girdiniz.");
            Console.Write(ex);
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Veri tipi uygun degil.");
            Console.Write(ex);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Cok kucuk yada cok buyuk bir deger girdiniz.");
            Console.Write(ex);
        }
        finally
        {
            Console.WriteLine("Islem tamamlandi.");
        }
       
    }
}
