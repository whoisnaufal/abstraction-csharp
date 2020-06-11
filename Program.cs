using Abstraction.Abstraction;
using Abstraction.Interface;
using System;

namespace Abstraction
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine();
            Console.WriteLine("Konsep Abstraksi Menggunakan Abstract Class. ");
            Console.WriteLine();
            hewanVertebrata jenis;

            jenis = new mamalia();
            jenis.jenisHewan();

            jenis = new reptilia();
            jenis.jenisHewan();

            jenis = new amphibia();
            jenis.jenisHewan();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Konsep Abstraksi Menggunakan Interface. ");
            Console.WriteLine();
            IHabitat habitat;

            habitat = new daratan();
            habitat.tempatTinggal();

            habitat = new laut();
            habitat.tempatTinggal();

            habitat = new hutan();
            habitat.tempatTinggal();

            Console.ReadKey();
        }
	}
}
