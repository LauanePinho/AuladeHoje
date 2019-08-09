using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoProjeto
{
    class Pessoa
    {
        private string nome;
        private string cpf;
        private int idade; // Bem Novinha
        private bool solteiro; //Muito Solteira 


        public string Nome { get; set; }
        public void Login()

        {

        }
        public void AlterarCadastro()
        {

        }
        public void ConsultarNotas()
        {

        }

        public string LerNome()
        {
            if (nome == null )
            {
                Console.WriteLine(" O nome ainda não foi cadastrado.");

            }
        return nome;
        }
        public void GravarNome(string valor)
        {
        if (valor.Lenght > 10)
        {
            Console.WriteLine("O nome deve conter no máximo 10 caracteres.");
        }
        else
        {
        nome  = valor; 
        }
}
