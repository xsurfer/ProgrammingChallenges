using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ValidateString
{
	public class Solution
	{
		/// <summary>
		/// Given a string S consisting of N characters, returns true if S is properly nested and false otherwise.
		/// A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:
		/// <list type="bullet">
		/// <item>S is empty;</item>
		/// <item>S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;</item>
		/// <item>S has the form "VW" where V and W are properly nested strings.</item>
		/// </list>
		/// For example, given S = "{[()()]}", the function should return true and given S = "([)()]", the function should return false, as explained above.
		/// Write an efficient algorithm for the following assumptions:
		/// <list type="bullet">
		/// <item>N is an integer within the range[0..200,000];</item>
		/// <item>string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")".</item>
		/// </list>
		/// </summary>
		/// <param name="toValidate"></param>
		public static bool ValidateString(String toValidate)
		{
            throw new NotImplementedException();
        }

        private static bool IsOpeningBracket(char c)
        {
            throw new NotImplementedException();
        }

        private static bool MatchBracket(char openBracket, char closedBracket)
        {
            throw new NotImplementedException();
        }
    }
}