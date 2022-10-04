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

            Stack<char> stack = new Stack<char>();

            foreach (char c in toValidate)
            {
                if (IsOpeningBracket(c))
                    stack.Push(c);
                else
                {
                    if (stack.Count == 0)
                        return false;
                    char stackOpenBracket = stack.Pop();
                    if (MatchBracket(stackOpenBracket, c))
                        continue;
                    else
                        return false;
                }
            }
            if (stack.Count == 0)
                return true;
            return false;            
		}

        private static bool IsOpeningBracket(char c)
        {
            if (c.Equals('(') | c.Equals('[') | c.Equals('{'))
                return true;
            return false;
        }

        private static bool MatchBracket(char openBracket, char closedBracket)
        {
            if (closedBracket.Equals(')') && openBracket.Equals('('))
                return true;
            if (closedBracket.Equals(']') && openBracket.Equals('['))
                return true;
            if (closedBracket.Equals('}') && openBracket.Equals('{'))
                return true;
            return false;
        }
    }
}
