using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fluqi.Tests
{

	public static class Utils
	{
		public static int NumberOfMatches(string s, string find) 
		{
			if (string.IsNullOrEmpty(s))
				// naturally no matches
				return 0;

			int pos = 0;
			int matches = 0;

			do 
			{
				pos = s.IndexOf(find, pos);

				if (pos > -1) {
					// found a match, so inc the result
					matches++;
					// and move onto next location
					pos++;
				}

			} while (pos > 0 && pos < s.Length);

			return matches;
		} // NumberOfMatches

	}
}
