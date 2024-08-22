using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Complement
{
    internal class Solution
    {

        public static int getComplement(int x)
        {
            String final = "";
            String output = Convert.ToString(x, 2);

            for (int i = 0; i < output.Length; i++)
            {
                if (output[i]=='1')
                {
                    final += "0";
                }
                else
                {
                    final += "1";
                }
                
            }
            int answer = Convert.ToInt32(final, 2);
            return answer;
        }
    }
}
