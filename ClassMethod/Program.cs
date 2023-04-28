// See https://aka.ms/new-console-template for more information
using ClassMethod;

Produk produk1 = new Produk("Baju", "Baju design simplicity", 2.3);
Produk produk2 = new Produk("Celana", "Denim good product", 4.3);
Console.WriteLine(produk1.CariHarga());
Console.WriteLine(produk2.CariHarga());

Console.ReadLine();