using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MonolithProject1
{
	public class Triangle
	{
		private int side1;
		private int side2;
		private int side3;

		public Triangle(int s1, int s2, int s3)
		{
			side1 = s1;
			side2 = s2;
			side3 = s3;
		}

		public int GetSide1()
		{
			return side1;
		}

		public string Useless()
		{
			return "this is useless";
		}

		public string Useless2()
		{
			return "this is also useless";
		}
	}
}
