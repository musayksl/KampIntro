// See https://aka.ms/new-console-template for more information

string kurs1 = "yazılım geliştirici kampı";
string kurs2= "temel kurs";
string kurs3 = "Java";

//array - dizi []

string[] kurslar = new string[] { "yazılım geliştirici kampı", "temel kurs","Java","python","C#" }; 



for (int i = 0; i <kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("for bitti");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}


Console.WriteLine("sayfa sonu");
