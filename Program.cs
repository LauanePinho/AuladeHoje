using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Hello World!);
           Pessoa p1 =  new Pessoa();
            p1.nome = "Lauane";
            p1.Login();


            Console.WriteLine(p1.LerNome());
            p1.Nome = "Lauane";
            Console.WriteLine(p1.Nome);






        }
    }
}
