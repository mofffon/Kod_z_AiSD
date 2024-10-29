namespace Zestaw_01;

public class Zestaw_01_3
{
  public int Zadanie_01(double[] tablica) {

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

  public void Zadanie_02(int[] tablica){

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
}