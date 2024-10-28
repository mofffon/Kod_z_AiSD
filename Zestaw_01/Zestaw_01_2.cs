using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Zestaw_01;

public class Zestaw_01_2 
{
  private readonly int[] _A = [-1,5,-3,2,7,-2,0,1,-7,9];
  
  public int dziel(int dzielna = 12, int dzielnik = 3)
  {
    Console.WriteLine("Proszę zapisać funkcję dziel, która wyznaczy wynik z dzielenia dwóch liczb naturalnych bez użycia operatora div, wykorzystując jedynie instrukcje pętli i operator odejmowania.");

    Console.WriteLine("public int dziel(int dzielna = 12, int dzielnik = 3)");
    Console.WriteLine("{");
    Console.WriteLine("  int licznik = 0;");
    Console.WriteLine("  if(dzielna - dzielnik < 0)");
    Console.WriteLine("  {");
    Console.WriteLine("    return 0;");
    Console.WriteLine("  }");
    Console.WriteLine("  while(dzielna > 0)");
    Console.WriteLine("  {");
    Console.WriteLine("    licznik++;");
    Console.WriteLine("    dzielna -= dzielnik;");
    Console.WriteLine("  {");
    Console.WriteLine("  return licznik;");
    Console.WriteLine("}");
    Console.WriteLine();
    Console.WriteLine($"Dzielna = {dzielna}, dzielnik = {dzielnik}.");
    int licznik = 0;

    if(dzielna - dzielnik < 0)
    {
      return 0;
    }

    while(dzielna > 0)
    {
      licznik++;
      dzielna -= dzielnik;
    }

    return licznik;    
  }

  public int Min()
  {
    Console.WriteLine("Zapisać funkcję Min, która zwraca największą ujemną liczbę w tablicy A.");
    Console.WriteLine($"Tablica A = [{string.Join(",", _A)}]." );
    
    Console.WriteLine("public int Min()");
    Console.WriteLine("  int wynik = 0;");
    Console.WriteLine("  foreach(int liczba in this._A)");
    Console.WriteLine("  {");
    Console.WriteLine("    if(liczba < 0)");
    Console.WriteLine("    {");
    Console.WriteLine("      if(wynik == 0)");
    Console.WriteLine("      {");
    Console.WriteLine("        wynik = liczba;");
    Console.WriteLine("      }");
    Console.WriteLine("      else if(wynik < liczba)");
    Console.WriteLine("      {");
    Console.WriteLine("        wynik = liczba; ");
    Console.WriteLine("      }");
    Console.WriteLine("    }");
    Console.WriteLine("  }");
    Console.WriteLine("  return wynik;");
    Console.WriteLine("}");
    Console.WriteLine();

    int wynik = 0;
    foreach(int liczba in this._A)
    {
      if(liczba < 0)
      {
        if(wynik == 0)
        {
          wynik = liczba;
        }
        else if(wynik < liczba)
        {
          wynik = liczba;    
        }
      }
    }

    return wynik;
  }

  public void zamien2(int index, int[] tablica)
  {
    Console.WriteLine("Proszę zapisać procedurę Zamien2, która zamienia miejscami ostatni i wskazany w argumencie funkcji elementy tablicy.");
    Console.WriteLine("public void zamien2(int index, int[] tablica)");
    Console.WriteLine("{");
    Console.WriteLine("  if(index < 0 || index >= tablica.Length)");
    Console.WriteLine("  {");
    Console.WriteLine("    Console.WriteLine(\"Indeks elementu jest poza zakresem tablicy\");");
    Console.WriteLine("  }");
    Console.WriteLine("  int temp = tablica[index];");
    Console.WriteLine("  tablica[index] = tablica[tablica.Length - 1];");
    Console.WriteLine("  tablica[tablica.Length - 1] = temp;");
    Console.WriteLine("}");

    if(index < 0 || index >= tablica.Length)
    {
      Console.WriteLine("Indeks elementu jest poza zakresem tablicy");
      return;
    }

    int temp = tablica[index];
    tablica[index] = tablica[tablica.Length - 1];
    tablica[tablica.Length - 1] = temp;
  }

  public int NWD(int liczba1, int liczba2)
  {
    Console.WriteLine("Zapisać funkcję, która zwraca największy wspólny dzielnik dwóch liczb naturalnych (np. algorytm Euklidesa).");
    Console.WriteLine("Zrodlo: https://pl.wikipedia.org/wiki/Algorytm_Euklidesa");
    Console.WriteLine();
    Console.WriteLine("public int NWD(int liczba1, int liczba2)");
    Console.WriteLine("{");
    Console.WriteLine("  while(liczba2 != 0)");
    Console.WriteLine("  {");
    Console.WriteLine("    int reszta = liczba1 % liczba2;");
    Console.WriteLine("    liczba1 = liczba2;");
    Console.WriteLine("    liczba2 = reszta;");
    Console.WriteLine("  }");
    Console.WriteLine("  return liczba1;");
    Console.WriteLine("}");
    Console.WriteLine();

    while(liczba2 != 0)
    {
      int reszta = liczba1 % liczba2;
      liczba1 = liczba2;
      liczba2 = reszta;
    }

    return liczba1;
  }

  public int Mod(int dzielna, int dzielnik)
  {
    Console.WriteLine("Zapisać funkcję Mod, która zwraca resztę z dzielenia dwóch liczb całkowitych bez użycia operatora mod, wykorzystując operatory mnożenia, odejmowania i div.");
    Console.WriteLine("public int Mod(int dzielna, int dzielnik)");
    Console.WriteLine("{");
    Console.WriteLine("  if (dzielnik == 0)");
    Console.WriteLine("  {");
    Console.WriteLine("    Console.WriteLine(\"Nie mozna wykonac dzielenia przez 0.\");");
    Console.WriteLine("    return 0;");
    Console.WriteLine("  }");
    Console.WriteLine("  int czescCalkowia = dzielna / dzielnik;");
    Console.WriteLine("  if(dzielna * dzielnik > 0)");
    Console.WriteLine("  {");
    Console.WriteLine("    return dzielna - czescCalkowia * dzielnik;");
    Console.WriteLine("  }");
    Console.WriteLine("  else");
    Console.WriteLine("  {");
    Console.WriteLine("    return dzielna + czescCalkowia * dzielnik;");
    Console.WriteLine("  }");
    Console.WriteLine("}");

    if (dzielnik == 0)
    {
      Console.WriteLine("Nie mozna wykonac dzielenia przez 0.");
      return 0;
    }

    int czescCalkowia = dzielna / dzielnik;

    if(dzielna * dzielnik > 0)
    {
      return dzielna - czescCalkowia * dzielnik;
    }
    else
    {
      return dzielna + czescCalkowia * dzielnik;
    }
  }
}