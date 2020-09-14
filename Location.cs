using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsApp
{
    public class Location
    {
		public int line_number;
		public int position;
		public Location(int line_number, int position)
		{
			this.line_number = line_number;
			this.position = position;
		}
	}
}
