using Proyecyto1.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecyto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CConexion c = new CConexion();
            c.establecerConexion();
            Console.ReadLine();
        }
    }
}
