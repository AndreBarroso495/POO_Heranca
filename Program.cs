using System;
using POO_Heranca.Classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando uma subclasse
            PessoaFisica pf = new PessoaFisica();
            //Atribuindo um valor para a propriedade disponível na superclasse
            Console.WriteLine("Digite o seu nome");
            pf.nome = Console.ReadLine();
            
            Console.WriteLine("Digite o seu CPF");
            pf.cpf = Console.ReadLine();

            //Mostrando no console o método de saudação da superclasse
            Console.WriteLine( pf.DarBoasVindas(pf.nome ) );

            //Mostrar no console o método de validação de subclasse
            Console.WriteLine( pf.ValidarCPF(pf.cpf ) );

        //     PessoaJuridica pj = new PessoaJuridica();
        //     pj.nome = "Andre";

        //     Console.WriteLine("Digite o seu CNPJ");
        //     pj.cnpj = Console.ReadLine();
            
        //     Console.WriteLine(pj.DarBoasVindas(pj.nome));

        //     Console.WriteLine( pj.ValidarCNPJ(pj.cnpj));
        
        }
    }
}
