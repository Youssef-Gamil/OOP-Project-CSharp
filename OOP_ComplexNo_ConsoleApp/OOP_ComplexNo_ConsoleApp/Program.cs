namespace OOP_ComplexNo_ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Complex b = new Complex(5);  //create an object using constructor

			//Creating objects using static methods.
			Complex a = Complex.CreateComplex(5, 5);
			Complex b = Complex.CreateComplex(2, 3);
			Complex c = a + 10;
			Complex d = Complex.CreateComplex(0, 0); ; //This should be NULL.


			Console.WriteLine($"c = {c.Real}, {c.Imag}, Complex objects created = {Complex.Count}");

			if (a >= b)
				Console.WriteLine("a bigger or equal than b");
			else
				Console.WriteLine("a smaller than b");

			if (d == null) Console.WriteLine("d is equal null");

			Complex h = new Complex(c);
			h.Real = h.Real + 1;
			Console.WriteLine($"{c.Real}, {h.Real}");
            Console.WriteLine(h); //as implemented in the overrided method.

        }
	}
}