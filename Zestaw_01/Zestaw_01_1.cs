namespace Zestaw_01;

public class Zestaw_01_1 
{
  public void Zadanie_01(int n = 50, bool wyswietlKod = false)
  {
    if(wyswietlKod)
    {
      Console.WriteLine("Jaka będzie wartość zmiennej wynik po wykonaniu następującego algorytmu dla n = 50?");
      Console.WriteLine("i = 1");
      Console.WriteLine("j = 0");
      Console.WriteLine("while i <= n");
      Console.WriteLine("  i = i * 2");
      Console.WriteLine("  j = j + 1");
      Console.WriteLine("wynik = i – j");
    }
    
    Console.WriteLine();

    int i = 1;
    int j = 0;

    while (i < n)
    {
      i = i * 2;
      j = j + 1;
    }

    Console.WriteLine($"Wynik: i - j = {i-j}" );
  }

  public void Zadanie_02(bool wyswietlKod = false)
  {
    if(wyswietlKod)
    {
      Console.WriteLine("Jaka będzie wartość zmiennej k po wykonaniu poniższego fragmentu programu?");
      Console.WriteLine("k = 1");
      Console.WriteLine("for i = 1 to 5");
      Console.WriteLine("  if i < 4 then");
      Console.WriteLine("    k = 3 * k");
      Console.WriteLine("  k = k – i");
    }
    Console.WriteLine();
    
    int k = 1;
    for(int i = 1; i <= 5; i++)
    {
      if(i < 4)
      {
        k = 3 * k;
      }
      k -= - i;
    }

    Console.WriteLine($"Wynik k = {k}");
  }

  public void Zadanie_03(int n = 5, bool wyswietlKod = false)
  {
    if(wyswietlKod)
    {
      Console.WriteLine("Jaka będzie wartość zmiennej wynik po wykonaniu następującego algorytmu dla n = 5?");
      Console.WriteLine("i = 1");
      Console.WriteLine("j = 1");
      Console.WriteLine("while j <= n");
      Console.WriteLine("  i = i + 3");
      Console.WriteLine("  j = j + 1");
      Console.WriteLine("wynik = j + i");
    }
    Console.WriteLine();
    
    int i = 1;
    int j = 1;

    while(j <= n)
    {
      i += + 3;
      j++;
    }

    Console.WriteLine($"Wynik j + i: {i+j}");
  }

  public void Zadanie_04(int n = 50, bool wyswietlKod = false)
  {
    if(wyswietlKod)
    {
      Console.WriteLine("Jaka będzie wartość zmiennej wynik po wykonaniu następującego algorytmu dla n = 50?");
      Console.WriteLine("i = 1");
      Console.WriteLine("j = 0");
      Console.WriteLine("while i <= n");
      Console.WriteLine("  i = i * 3");
      Console.WriteLine("  j = j + 1");
      Console.WriteLine("wynik = i div j");
    }
    Console.WriteLine();

    int i = 1;
    int j = 0;

    while (i <= n)
    {
      i *= 3;
      j++;
    }

    Console.WriteLine($"Wynik i div j = {i/j}");
  }

  public void Zadanie_05(int n = 5, bool wyswietlKod = false)
  {
    if(wyswietlKod)
    {
      Console.WriteLine("Jaka będzie wartość zmiennej k po wykonaniu następującego algorytmu dla n = 5?");
      Console.WriteLine("i = 1");
      Console.WriteLine("k = 0");
      Console.WriteLine("while i < n");
      Console.WriteLine("  j = i");
      Console.WriteLine("  repeat");
      Console.WriteLine("    k = k + 1");
      Console.WriteLine("    j = j – 1");
      Console.WriteLine("  until j = 0");
      Console.WriteLine("  i=i+1");
    }

    int i = 1;
    int k = 0;

    while (i < n)
    {
      int j = i;

      do
      {
        k++;
        j--;
      }while(j != 0);
      i++;
    }

    Console.WriteLine($"Wynik: k = {k}");
  }
}