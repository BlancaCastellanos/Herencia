﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
	abstract class Figura
	{
		public string Color { get; set; }


		//Todas las figuras deben de ser capaces de calcular su area
		public abstract double calcularArea();


		public string toString()
		{
			return "Soy una figura: " + Color;

		}
	}
}
