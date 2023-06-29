// See https://aka.ms/new-console-template for more information
using Metotlar;



Product product1 = new Product();
product1.Adi = "Elma";
product1.Fiyati = 15;
product1.Aciklama = "Amasya Elması";


Product product2 = new Product();
product2.Adi = "Karpuz";
product2.Fiyati = 80;
product2.Aciklama = "Diyarbakır karpuzu";


Product[] products = new Product[] { product1, product2 };

 foreach (Product product in products)
{
    Console.WriteLine(product.Adi);
    Console.WriteLine(product.Fiyati);
    Console.WriteLine(product.Aciklama);
    
}
Console.WriteLine("-----------Metotlar--------------");
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(product1);
sepetManager.Ekle(product2);

sepetManager.Ekle2("Armut", "YeşilArmut", 12, 10);
sepetManager.Ekle2("elma", "Yeşil elma", 12, 9);
sepetManager.Ekle2("karpuz", "diyabakır karpuzu ", 12, 8);







