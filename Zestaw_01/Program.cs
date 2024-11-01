﻿namespace Zestaw_01;
using System;

class Program
{
  private static readonly int[] _A = [-1,5,-3,2,7,-2,0,1,-7,9];
  static void Main(string[] args)
  {
    Console.WriteLine("Witam w Zestawie 01 cwiczen z Algorytmow i struktur danych.");
    Console.WriteLine("Wybierz podzestaw, liczbe od 1 do 3 (1 - podzestawzestaw_1a, 2 - podzestawzestaw_2, 3 - podzestaw_3_dodatkowe_zadania):" );
    string input = Console.ReadLine()!;

    if(!int.TryParse(input, out int parsedInput) || parsedInput <= 0 || parsedInput > 3)
    {
      Console.WriteLine("Wpisano znaki inne niż int.");
    }

    string wejscie;
    int parsedWejscie;

    switch(parsedInput)
    {
      case 1:
        Console.WriteLine("Wybrano podzestaw 1");
        Console.WriteLine("Wybierz zadanie z zakresu 1 - 5");
        wejscie = Console.ReadLine()!;

        if(!int.TryParse(wejscie, out parsedWejscie))
        {
            Console.WriteLine("Wpisano znaki inne niż int.");
            return;
        }

        Zestaw_01_1 zadania1 = new();

        switch(parsedWejscie)
        {
          case 1:
            zadania1.Zadanie_01(50);
            break;
          case 2:
            zadania1.Zadanie_02(true);
            break;
          case 3:
            zadania1.Zadanie_03(5, true);
            break;
          case 4:
            zadania1.Zadanie_04(50, true);
            break;
          case 5:
            zadania1.Zadanie_05(5, true);
            break;
          default:
            Console.WriteLine("Wybrano liczbe z poza zakresu 1 - 5. Program zaknoczy sie.");
            break;
          }
        break;

      case 2:
        Console.WriteLine("Wybrano podzestaw 2.");
        Console.WriteLine("Wybierz zadanie z zakresu 1 - 7:");
        wejscie = Console.ReadLine()!;

        if(!int.TryParse(wejscie, out parsedWejscie))
        {
            Console.WriteLine("Wpisano znaki inne niż int.");
            return;
        }

        Zestaw_01_2 zadania2 = new();

        switch(parsedWejscie)
        {
          case 1:
            Console.WriteLine($"Wynik = {zadania2.dziel(25,5, true)}");
            break;
          case 2:
            Console.WriteLine($"Wynik = {zadania2.Min(true)}");
            break;
          case 3:
            int indeks = 2;
            Console.WriteLine("indeks = " + indeks);
            Console.WriteLine($"Tablica przed = [{string.Join(",", _A)}]");
            zadania2.zamien2(indeks, _A, true);
            Console.WriteLine($"Tablica po = [{string.Join(",", _A)}]");
            break;
          case 4:
            int liczba1 = 10;
            int liczba2 = 5;
            Console.WriteLine($"Liczba1 = {liczba1}, liczba2 = {liczba2}");
            Console.WriteLine($"Wynik = {zadania2.NWD(liczba1, liczba2, true)}.");
            break;
          case 5:
            int dzielna = 10;
            int dzielnik = 7;
            Console.WriteLine($"Dzielna = {dzielna}, dzielnik = {dzielnik}");
            Console.WriteLine($"Wynik = {zadania2.Mod(dzielna, dzielnik, true)}.");
            break;
          case 6:
            double podstawa = 6;
            int wykladnik = 3;
            Console.WriteLine($"Podstawa = {podstawa}, wykladnik = {wykladnik}");
            Console.WriteLine($"Wynik = {zadania2.power(podstawa, wykladnik, true)}");
            break;
          case 7:
            int podstawaLogarytmu = 2;
            double logarytmowana = 8;
            Console.WriteLine($"Podstawa logarytmu = {podstawaLogarytmu}, liczba logarytmowana = {logarytmowana}.");
            Console.WriteLine($"Wynik = {zadania2.logn(podstawaLogarytmu, logarytmowana, true)}");
            break;
          default:
            Console.WriteLine("Nie wybrano liczby z zakresu 1 - 7. Program zakonczy sie.");
            break;
        } 

        break;
      case 3:
        Console.WriteLine("Wybrano podsestaw 3");
        Console.WriteLine("Wybierz zadanie (liczbe) z zakresu 1 - 6");

        wejscie = Console.ReadLine()!;
        
        if(!int.TryParse(wejscie, out parsedWejscie))
        {
          Console.WriteLine("Wpisano znaki inne niż liczba calkowita.");
        }

        Zestaw_01_3 zadania3 = new();

        switch(parsedWejscie){
          case 1:
            double[] tablica = [1,2,1];
            Console.WriteLine($"Tablica = {string.Join(",", tablica, true)}");
            zadania3.Zadanie_01(tablica);
            break;
          case 2:
            Console.WriteLine("Under construction... Be patient");
            break;
          case 3:
            int[] babelkowa = [1,2,1,3,5,6,1,2,4,9,0];
            Console.WriteLine($"Tablica przed sortowaniem = {string.Join(",", babelkowa)}");
            zadania3.Zadanie_03(babelkowa, true);
            Console.WriteLine($"Tablica po sortowaniu = {string.Join(",", babelkowa)}");
            break;
          case 4:
            int[] bisekcja = [1,2,1,3,5,6,1,2,4,9,0];
            Console.WriteLine($"Tablica przed sortowaniem = {string.Join(",",bisekcja)}");
            int szukana = 5;
            Console.WriteLine($"Szukana = {szukana}");
            int indeks = zadania3.Zadanie_04(szukana, bisekcja, true);
            Console.WriteLine($"Indeks szukanej = {szukana} w tablicy = {string.Join(",",bisekcja)} jest równy = {indeks}");
            break;
          case 5:
            zadania3.Zadanie_05(1,5,6, true);
            break;
          case 6:
            zadania3.Zadanie_06(1,5,6,0.001);
            break;
        }
      break;
    }
  }
}
