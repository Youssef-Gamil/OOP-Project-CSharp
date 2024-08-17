using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ComplexNo_ConsoleApp
{
	//The Class here is achieving an OOP concept "Encapsulation".
	//All the related methods, variables and properties are all in one place.
	internal class Complex
	{
		#region Member Variables
		int real;
		int imag;
		static int count;
		#endregion

		#region Properties
		//Properties are used to achieve OOP concept "Abstraction" between member variables and the program.
		public int Real
		{
			get { return real; }
			set { real = value; }
		}
		public int Imag
		{
			get { return imag; }
			set { imag = value; }
		}
		//Static properties are related to the class itself not to an instance created from it.
		public static int Count
		{
			get { return count; }
			set { count = value; }
		}
		#endregion

		#region Constructor
		//Static consyructor contain variable that count the number of Complex objects created.
		static Complex()
		{
			count = 0;
		}
		private Complex(int real, int imag)
		{
			this.real = real;
			this.imag = imag;
			count++;
		}
		//this here referes to chaining that this function is calling the above one.
		private Complex(int No) : this(No, No)
		{ }
		private Complex() : this(0)
		{ }
		public Complex(Complex c)
		{
			this.real = c.Real;
			this.imag = c.Imag;
		}
		#endregion

		#region Static Methods
		//The following are the basic operations that can be done on a complex numbers.
		//Using static methods.
		public static Complex operator +(Complex a, Complex b)
		{
			return new Complex(a.real + b.real, a.imag + b.imag);
		}
		public static Complex operator -(Complex a, Complex b)
		{
			return new Complex(a.real - b.real, a.imag - b.imag);
		}
		public static Complex operator +(Complex a, int no)
		{
			return new Complex(a.real + no, a.imag);
		}
		public static Complex operator +(int no, Complex a)
		{
			return a + no;
		}
		public static bool operator >(Complex a, Complex b)
		{
			if (Math.Sqrt(Math.Pow(a.real, 2) + Math.Pow(a.imag, 2)) > Math.Sqrt(Math.Pow(b.real, 2) + Math.Pow(b.imag, 2)))
				return true;
			else
			{
				return false;
			}
		}
		public static bool operator <(Complex a, Complex b)
		{
			if (Math.Sqrt(Math.Pow(a.real, 2) + Math.Pow(a.imag, 2)) < Math.Sqrt(Math.Pow(b.real, 2) + Math.Pow(b.imag, 2)))
				return true;
			else
			{
				return false;
			}
		}
		public static bool operator <=(Complex a, Complex b)
		{
			if (!(a > b))
				return true;
			else
				return false;
		}
		public static bool operator >=(Complex a, Complex b)
		{
			if (!(a < b))
				return true;
			else
				return false;
		}
		public static explicit operator Complex(int no)
		{
			return new Complex(no);
		}
		public static Complex operator ++(Complex a)
		{
			return new Complex(a.real + 1, a.imag);
		}
		//This method is used to only create a new object of complex number,
		//Only create 3 objects 
		//else will not create any.
		//This done by making all the constructors private, and only one static method cal call them.
		public static Complex CreateComplex(int _real, int _imag)
		{
			Complex result = null;
			if (count < 3)
			{
				result = new Complex(_real, _imag);
			}
			return result;
		}
		#endregion

		#region Methods
		public Complex Clone()
		{
			return new Complex(this);
		}
		#endregion

		#region Override methods
		public override string ToString()
		{
			string result;
			if (imag>0) 
			{
				result = $"{real}+{imag}i";
			}
			else
			{
				result = $"{real}{imag}i";
			}
			return result;
		}
		#endregion
	}
}
