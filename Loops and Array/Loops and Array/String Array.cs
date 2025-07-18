using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_and_Array
{
    internal class String_Array
    {
        string[] Names = { "Abhay", "Annu", "Arpit", "Rugveda", "Shruti" };
        public void PrintNames()
        {
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
        }
        public string ConcatenateNames()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string name in Names)
            {
                sb.Append(name + " ");
            }
            sb.Append(" Go to Same College..");
            return sb.ToString().Trim();
        }


    }
}
