class Calculator
{
	static void Main(string{} args)
		{
			int a = 10;
			int b = 6;
			
			Console.Writeline("Hasil penambahan: (0) + (1) = (2)"a, b, Penambahan(a, b));
			Console.Writeline("Hasil pengurangan: (0) - (1) = (2)"a, b, Pengurangan(a, b));
			
			Console.Writeline("\nTekan sembarang key untuk keluar");
			Console.ReadKey();
		}
		
		static int Penambahan(inta, int b)
		{
			return a + b;
		}
		
		static int Pengurangan(inta, int b)
		{
			return a - b;
		}
}
