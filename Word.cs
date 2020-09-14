using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsApp
{
    public class Word
    {
		public string word;
		public int count;
		public LinkedList<Location> locations;

		public Word(string word, Location location)
		{
			this.word = word;
			this.count = 1;
			locations = new LinkedList<Location>();
			locations.AddLast(location);
		}
	}
}
