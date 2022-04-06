using System;
using System.Collections.Generic;
using System.Text;

namespace Solve
{
	internal class Helper
	{
        public static bool CheckSequence(String a, String b)
        {

            //End of recursion sequence and all numbers matched .
            //Nothing more to compare
            if (b.Length == 0 && a.Length==0)
                return true;

            //Before comparing make sure pointer is at the number 
            //if not advance the string 'a' to next position
            if(a.Length > 0 && !char.IsNumber(a[0]))
			{
                return CheckSequence(a.Substring(1), b);
            }
            //Apply the same logic to string 'b'
            if (b.Length > 0 && !char.IsNumber(b[0]))
            {
                return CheckSequence(a, b.Substring(1));
            }
            // Verify the if anyone of the string reached end of sequence 
            if (a.Length <=0 || b.Length <=0)
            {
                return false;
            }
            //Compare. If the numbers are not equal return false
            if (a[0] != b[0])
                return false;
            else
                //Advance the pointer by 1 pos 
                return CheckSequence(a.Substring(1), b.Substring(1));
            
        }
    }
}
