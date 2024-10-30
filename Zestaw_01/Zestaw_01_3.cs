using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Zestaw_01;

public class Zestaw_01_3
{
  public int Zadanie_01(double[] tablica, bool wyswietlKod = true) {

    if(wyswietlKod)
    {
      Console.WriteLine("Zadanie_01(Var tablica[])");
      Console.WriteLine("  takieSame = True");
      Console.WriteLine("  malejace = True");
      Console.WriteLine("  rosnace = True");
      Console.WriteLine("  If Length(tablica) == 0");
      Console.WriteLine("    Print(\"Tablica jest pusta\")");
      Console.WriteLine("    return -1");
      Console.WriteLine("  If Length(tablica) == 1");
      Console.WriteLine("    Print(\"Elementy sa takie same.\")");
      Console.WriteLine("    return 1");
      Console.WriteLine("  For i = 1 to (Length(tablica) -1)");
      Console.WriteLine("    If tablica[i] != tablica[i + 1]");
      Console.WriteLine("      takieSame = False");
      Console.WriteLine("    If tablica[i] <= tablica[i + 1]");
      Console.WriteLine("      malejace = False;");
      Console.WriteLine("    If tablica[i] >= tablica[i + 1]");
      Console.WriteLine("      rosnace = False;");
      Console.WriteLine("  If takieSame == True");
      Console.WriteLine("    Print(Elementy sa takie same.)");
      Console.WriteLine("    return 1");
      Console.WriteLine("  If malejace == True");
      Console.WriteLine("    Print(Elementy sa malejace.)");
      Console.WriteLine("    return 2");
      Console.WriteLine("  If rosnace == True");
      Console.WriteLine("    Print(elementy sa rosnace.)");
      Console.WriteLine("    return 3");
      Console.WriteLine("  Print(Elementy nie sa takie same, nie sa malejace i nie sa rosnoce.)");
      Console.WriteLine("  return 0");
    }
    
    bool takieSame = true;
    bool malejace = true;
    bool rosnace = true;

    if(tablica.Length  == 0) 
    {
      Console.WriteLine("Tablica jest pusta.");
      return -1;
    }

    if(tablica.Length == 1)
    {
      Console.WriteLine("Tablica jest jednoelementowa. Elementy sa takie same.");
      return 1;
    }

    for(int i = 0; i < tablica.Length - 1; i++)
    {
      if(tablica[i] != tablica[i + 1])
      {
        takieSame = false;
      }

      if(tablica[i] <= tablica[i + 1])
      {
        malejace = false;
      }

      if(tablica[i] >= tablica[i + 1])
      {
        rosnace = false;
      }
    }

    if(takieSame)
    {
      Console.WriteLine("Elementy sa takie same.");
      return 1;
    }
    
    if(malejace)
    {
      Console.WriteLine("Elementy sa malejace.");
      return 2;
    }

    if(rosnace)
    {
      Console.WriteLine("Elementy sa rosnace.");
      return 3;
    }

    Console.WriteLine("Elementy nie sa takie same, nie sa malejace i nie sa rosnace.");
    return 0;
  }

  public void Zadanie_03(int[] tablica, bool wyswietlKod = true){

    if(wyswietlKod){
      Console.WriteLine("Zadanie_02(Var tablica[])");
      Console.WriteLine("  If Length(tablica) == 0 OR Length(tablica) == 1");
      Console.WriteLine("    return");
      Console.WriteLine("  While(True)");
      Console.WriteLine("    zamienione = False");
      Console.WriteLine("    For( i = 1 To (Length(tablica) -1))");
      Console.WriteLine("      If tablica[i + 1] < tablica[i]");
      Console.WriteLine("        temp = tablica[i]");
      Console.WriteLine("        tablica[i] = tablica[i + 1]");
      Console.WriteLine("        tablica[i + 1] = temp");
      Console.WriteLine("        zamienione = True");
      Console.WriteLine("    If zamienione == False");
      Console.WriteLine("      return");
    }
    
    if(tablica.Length == 0 || tablica.Length == 1)
    {
      return;
    }

    while(true){
      bool zamienione = false;
      for(int i = 0; i < (tablica.Length - 1); i++)
      {
        if(tablica[i + 1] < tablica[i])
        {
          int temp = tablica[i];
          tablica[i] = tablica[i + 1];
          tablica[i + 1] = temp;
          zamienione = true;
        }
      }

      if(!zamienione)
      {
        return;
      }
    }
  }

  public int Zadanie_04(int szukana, int[] dane, bool wyswietlKod = false)
  {
    if(wyswietlKod)
    {
      Console.WriteLine("Zadanie_04(szukana, Var dane[], wyswietlKod)");
      Console.WriteLine("  sortuj(dane)");
      Console.WriteLine("  poczatek=0");
      Console.WriteLine("  koniec=Length(dane)-1");
      Console.WriteLine("  while(poczatek <= koniec)");
      Console.WriteLine("    srodek = (koniec + poczatek) / 2");
      Console.WriteLine("     If dane[srodek] == szukana");
      Console.WriteLine("       return srodek");
      Console.WriteLine("     Else If dane[szukana] < dane[srodek]");
      Console.WriteLine("       koniec = srodek - 1");
      Console.WriteLine("     Else");
      Console.WriteLine("       poczatek = srodek + 1");
      Console.WriteLine("  return -1");
    }

    this.Zadanie_03(dane);
    
    int poczatek = 0;
    int koniec = dane.Length - 1;
    
    while(poczatek <= koniec)
    {
      int srodek = (koniec + poczatek) / 2;
      if(dane[srodek] == szukana)
      {
        return srodek;
      }else if(dane[szukana] < dane[srodek])
      {
        koniec = srodek - 1;
      }else
      {
        poczatek = srodek + 1;
      }
    }
    
    return -1;
  }

  public void Zadanie_05(double a, double b, double c, bool wyswietlKod = false)
  {
    if(wyswietlKod)
    {
      Console.WriteLine("Zadanie_05(a, b, c)");
      Console.WriteLine("  Print(\"Funkcja ma postać  y = {a}*x^2 + {b}*x + {c}\")");
      Console.WriteLine("  If a == 0");
      Console.WriteLine("    Print(\"Miejsce zerowe to {-c/b}\")");
      Console.WriteLine("    return");
      Console.WriteLine("  delta = b*b - 4 * a* c");
      Console.WriteLine("  If delta == 0");
      Console.WriteLine("    x0 = -b / (2 * a)");
      Console.WriteLine("    Print(\"Miejsce zerowe funkcji to: {x0}\")");
      Console.WriteLine("  Else If delta > 0");
      Console.WriteLine("    x1 = (-b + Sqrt(delta))/(2 * a)");
      Console.WriteLine("    x2 = (-b - Sqrt(delta))/(2 * a); ");
      Console.WriteLine("    Print(\"Miejsca zerowe funkcji to: x1 = {x1} oraz x2 = {x2}\")");
      Console.WriteLine("  Else");
      Console.WriteLine("    Print(\"Funckja nie ma miejsc zerowych\")");
    }

    Console.WriteLine("Proszę zapisać algorytm wyznaczający dokładne rozwiązania dla zmiennej x równania ax2+bx+c=0.");
    Console.WriteLine($"Funkcja ma postać  y = {a}*x^2 + {b}*x + {c}");

    if(a == 0)
    {
      Console.WriteLine($"Miejsce zerowe to {-c/b}");
      return;
    }

    double delta = b*b - 4 * a* c;

    if(delta == 0)
    {
      double x0 = -b / (2 * a);
      Console.WriteLine($"Miejsce zerowe funkcji to: {x0}");
    }else if (delta > 0)
    {
      double x1 = (-b + Math.Sqrt(delta))/(2 * a);
      double x2 = (-b - Math.Sqrt(delta))/(2 * a);
      Console.WriteLine($"Miejsca zerowe funkcji to: x1 = {x1} oraz x2 = {x2}");
    }else if (delta < 0)
    {
      Console.WriteLine("Funckja nie ma miejsc zerowych");
    }
  }

  public void Zadanie_06(double a, double b, double c, double epsilon, bool wyswietlKod = false)
  {
    Console.WriteLine("Proszę zapisać algorytm wyznaczający rozwiązanie przybliżone metodą bisekcji dla zmiennej x równania ax2+bx+c=0.");
    Console.WriteLine($"Funkcja ma postać  y = {a}*x^2 + {b}*x + {c}");

    if(a == 0)
    {
      Console.Write("Podane parametry nie tworza funkcji kwadratowej.");
      return;
    }

    double srodek = -b / (2 * a);
    double delta = b * b - 4 * a*c;

    if(delta == 0)
    {
      Console.WriteLine($"Miejsce zerowe x0 = {srodek}");
    }
    else if (delta < 0){
      Console.WriteLine("Funkcja nie ma miejsc zerowych");
    }else
    {
      double xPrim = srodek - 10;
      while(WartoscKwadr(a, b, c, xPrim) * WartoscKwadr(a,b,c, srodek) > 0)
      {
        xPrim = xPrim - 10;
      }

      double xBis = srodek + 10;
      while(WartoscKwadr(a, b, c, xBis) * WartoscKwadr(a,b,c, srodek) > 0)
      {
        xBis = xBis + 10;
      }

      double x1 = this.Bisekcja(a,b,c, xPrim, srodek, epsilon);
      double x2 = this.Bisekcja(a,b,c, srodek, xBis, epsilon);

      Console.WriteLine($"Miejsca zaerowe funkcji to x1 = {x1} oraz x2 ={x2} dla epsilon = {epsilon}.");
    }
  }

  private double Bisekcja(double a, double b, double c, double start, double koniec, double epsilon)
  {
    double x = (start + koniec) / 2;
    double wartosc = WartoscKwadr(a,b,c,x);
    while(Math.Abs(wartosc) > epsilon){
      if(WartoscKwadr(a,b,c, x) * WartoscKwadr(a,b,c, start) < 0)
      {
        koniec = x;
      }
      else if(WartoscKwadr(a,b,c, x) * WartoscKwadr(a,b,c, koniec) < 0)
      {
        start = x;
      }
      x = (start + koniec) / 2;
      wartosc = WartoscKwadr(a,b,c,x);
    }

    return x;
  }

  private double WartoscKwadr(double a, double b, double c, double x)
  {
    return a*x*x + b*x + c;
  }
}