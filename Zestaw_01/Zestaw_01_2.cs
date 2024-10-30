namespace Zestaw_01;

public class Zestaw_01_2 
{
  private readonly int[] _A = [-1,5,-3,2,7,-2,0,1,-7,9];
  
  public int dziel(int dzielna = 12, int dzielnik = 3, bool wyswietlKod = true)
  {
    if(wyswietlKod)
    {
      Console.WriteLine("Proszę zapisać funkcję dziel, która wyznaczy wynik z dzielenia dwóch liczb naturalnych bez użycia operatora div, wykorzystując jedynie instrukcje pętli i operator odejmowania.");
      Console.WriteLine("dziel(dzielna, dzielnik)");
      Console.WriteLine("  licznik = 0;");
      Console.WriteLine("  if(dzielna - dzielnik < 0)");
      Console.WriteLine("    return 0;");
      Console.WriteLine("  while(dzielna > 0)");
      Console.WriteLine("    licznik = licznik + 1;");
      Console.WriteLine("    dzielna = dzielna - dzielnik;");
      Console.WriteLine("  return licznik;");
      Console.WriteLine();
      Console.WriteLine($"dzielna = {dzielna}, dzielnik = {dzielnik}.");
    }
    
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

  public int Min(bool wyswietlKod = false)
  {
    if(wyswietlKod)
    {
      Console.WriteLine("Zapisać funkcję Min, która zwraca największą ujemną liczbę w tablicy A.");
      Console.WriteLine($"Tablica A = [{string.Join(",", _A)}]." );
      Console.WriteLine("Min()");
      Console.WriteLine("  wynik = 0;");
      Console.WriteLine("  for liczba in A");
      Console.WriteLine("    if(liczba < 0)");
      Console.WriteLine("      if(wynik == 0)");
      Console.WriteLine("        wynik = liczba;");
      Console.WriteLine("      else if(wynik < liczba)");
      Console.WriteLine("        wynik = liczba; ");
      Console.WriteLine("  return wynik;");
    }
    
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

  public void zamien2(int index, int[] tablica, bool wyswietlKod = false)
  {
    if(wyswietlKod)
    {
      Console.WriteLine("Proszę zapisać procedurę Zamien2, która zamienia miejscami ostatni i wskazany w argumencie funkcji elementy tablicy.");
      Console.WriteLine("zamien2(index, var tablica[])");
      Console.WriteLine("  if(index < 0 || index >= Length(tablica))");
      Console.WriteLine("    Print(\"Indeks elementu jest poza zakresem tablicy\")");
      Console.WriteLine("  temp = tablica[index]");
      Console.WriteLine("  tablica[index] = tablica[Length(tablica)]");
      Console.WriteLine("  tablica[Length(tablica)] = temp");
    }
    

    if(index < 0 || index >= tablica.Length)
    {
      Console.WriteLine("Indeks elementu jest poza zakresem tablicy");
      return;
    }

    int temp = tablica[index];
    tablica[index] = tablica[tablica.Length - 1];
    tablica[tablica.Length - 1] = temp;
  }

  public int NWD(int liczba1, int liczba2, bool wyswietlKod= false)
  {
    if(wyswietlKod) 
    {
      Console.WriteLine("Zapisać funkcję, która zwraca największy wspólny dzielnik dwóch liczb naturalnych (np. algorytm Euklidesa).");
      Console.WriteLine("Zrodlo: https://pl.wikipedia.org/wiki/Algorytm_Euklidesa");
      Console.WriteLine();
      Console.WriteLine("NWD(int liczba1, int liczba2)");
      Console.WriteLine("  while(liczba2 != 0)");
      Console.WriteLine("    reszta = liczba1 % liczba2");
      Console.WriteLine("    liczba1 = liczba2");
      Console.WriteLine("    liczba2 = reszta");
      Console.WriteLine("  return liczba1");
    }
    
    Console.WriteLine();

    while(liczba2 != 0)
    {
      int reszta = liczba1 % liczba2;
      liczba1 = liczba2;
      liczba2 = reszta;
    }

    return liczba1;
  }

  public int Mod(int dzielna, int dzielnik, bool wyswietlKod = false)
  {
    if(wyswietlKod)
    {
      Console.WriteLine("Zapisać funkcję Mod, która zwraca resztę z dzielenia dwóch liczb całkowitych bez użycia operatora mod, wykorzystując operatory mnożenia, odejmowania i div.");
      Console.WriteLine("Mod(dzielna, dzielnik)");
      Console.WriteLine("  if (dzielnik == 0)");
      Console.WriteLine("    Print(\"Nie mozna wykonac dzielenia przez 0.\")");
      Console.WriteLine("    exit(0)");
      Console.WriteLine("  czescCalkowia = dzielna / dzielnik");
      Console.WriteLine("  if(dzielna * dzielnik >= 0)");
      Console.WriteLine("    return dzielna - czescCalkowia * dzielnik");
      Console.WriteLine("  else");
      Console.WriteLine("    return dzielna + czescCalkowia * dzielnik");
    }
    

    if (dzielnik == 0)
    {
      Console.WriteLine("Nie mozna wykonac dzielenia przez 0.");
      return -1000;
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

  public double power(double podstawa, int wykladnik, bool wyswietlKod = false)
  {
    if(wyswietlKod)
    {
      Console.WriteLine("Zapisać funkcję power, która dla dwóch argumentów zwraca x^y.");
      Console.WriteLine("power(podstawa, wykladnik)");
      Console.WriteLine("  IF podstawa < 0");
      Console.WriteLine("    Print(Podstawa musi byc > 0.)");
      Console.WriteLine("    exit(-1000)");
      Console.WriteLine("  If wykladnik < 0");
      Console.WriteLine("    podstawa = 1 / podstawa");
      Console.WriteLine("    wykladnik = -wykladnik");
      Console.WriteLine("  wynik = 1");
      Console.WriteLine("  while(wykladnik > 0)");
      Console.WriteLine("    wynik = wynik * podstawa");
      Console.WriteLine("    wykladnik = wykladnik - 1");
      Console.WriteLine("  return wynik");
    }
    
    if (podstawa < 0)
    {
      Console.WriteLine("Podstawa musi byc > 0.");
      return -1000;
    }

    if(wykladnik < 0)
    {
      podstawa = 1 / podstawa;
      wykladnik = -wykladnik;
    }

    double wynik = 1;
    while(wykladnik > 0)
    {
      wynik = wynik * podstawa;
      wykladnik--;
    }

    return wynik;
  }

  public int logn(int podstawa, double liczbaLogarytmowana, bool wyswietlKod = false)
  {
    if(wyswietlKod)
    {
      Console.WriteLine("logn(podstawa, logarytmowana)");
      Console.WriteLine("  If podstawa <= 0 OR logarytmowana <= 0");
      Console.WriteLine("    Print(Podstawa i liczba logarytmowana musza byc > 0.)");
      Console.WriteLine("    exit(-1000)");
      Console.WriteLine("  wynik = 0");
      Console.WriteLine("  while(podstawa ^ wynik < logarytmowana)");
      Console.WriteLine("    wynik = wynik + 1");
      Console.WriteLine("  return wynik");
    }
    

    if(podstawa <= 0 || liczbaLogarytmowana < 1)
    {
      Console.WriteLine("Podstawa musi byc > 0, a liczba logarytmowa > 1.");
      return -1000;
    }
    //podstawa ^ wynik = liczbaLogarytmowa
    int wynik = 0;
    while(Math.Pow(podstawa, wynik) < liczbaLogarytmowana){
      wynik++;
    }

    return wynik;
  }
}