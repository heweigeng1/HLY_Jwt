using HLY_Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var token = new JwtUtils().GetToken();
            new JwtUtils().Parse(token, "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk");
            Console.ReadLine();
        }
    }
}
