using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionality_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //R1>(R2/(R3/R4)>((R5/R6)/(R7/(R8/R9))>R10>R11))
            //Rv = 10*Rn R1 = 10Ω, R2 = 20Ω ...
            string testCircuit = "10>(20/(30/40)>((50/60)/(70/(80/90))>100>110))";
        }
    }
}
