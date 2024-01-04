// See https://aka.ms/new-console-template for more information
Console.Write("Masukan jumlah pembelian:");
int jumlah = int.Parse(Console.ReadLine());
if (jumlah > 10)
{
    Console.WriteLine("Anda mendapatkan diskon 10%");
}
Console.WriteLine("Terimakasih atas pembelian anda");
