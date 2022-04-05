using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasOfFigures
{
	internal interface ITriangle
	{
		double EdgeA { get; }
		double EdgeB { get; }
		double EdgeC { get; }

		bool IsRightTriangle { get; }
	}
}
