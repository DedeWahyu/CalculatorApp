using System;

namespace CalculatorApp
{
  class Program
  {
    static void Main(string[] args)
    {
      float menu, a, b;

      menu_calculator:
      Console.WriteLine();
      Console.WriteLine("PILIH MENU CALCULATOR : ");
      Console.WriteLine();

      Console.WriteLine("1.Penambahan");
      Console.WriteLine("2.Pengurangan");
      Console.WriteLine("3.Perkalian");
      Console.WriteLine("4.Pembagian");
      Console.WriteLine();

      Console.Write("Masukkan Pilihan : ");
      menu = int.Parse(Console.ReadLine());
      Console.WriteLine();

      if (menu == 1)
      {
        Console.Write("Inputkan nilai a : ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Inputkan nilai b : ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Hasil Penambahan nilai " + a + " dan " + b + " adalah " + (a + b));
        Console.WriteLine();

        Console.WriteLine("PROGRAM SELESAI!");
        Console.ReadKey();
        Environment.Exit(0);
      }

      if (menu == 2)
      {
        Console.Write("Inputkan nilai a : ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Inputkan nilai b : ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Hasil Pengurangan nilai " + a + " dan " + b + " adalah " + (a - b));
        Console.WriteLine();

        Console.WriteLine("PROGRAM SELESAI!");
        Console.ReadKey();
        Environment.Exit(0);
      }

      if (menu == 3)
      {
        Console.Write("Inputkan nilai a : ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Inputkan nilai b : ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Hasil Perkalian nilai " + a + " dan " + b + " adalah " + (a * b));
        Console.WriteLine();

        Console.WriteLine("PROGRAM SELESAI!");
        Console.ReadKey();
        Environment.Exit(0);
      }

      if (menu == 4)
      {
        Console.Write("Inputkan nilai a : ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Inputkan nilai b : ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Hasil Pembagian nilai " + a + " dan " + b + " adalah " + (a / b));
        Console.WriteLine();

        Console.WriteLine("PROGRAM SELESAI!");
        Console.ReadKey();
        Environment.Exit(0);
      }

      else
      {
        Console.WriteLine("PILIHAN YANG DIMASUKKAN SALAH !");
        goto menu_calculator;
        Console.Clear();
      }


    }
  }
}
