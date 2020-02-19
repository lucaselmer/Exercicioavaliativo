using System;
using Classes;

namespace Locadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente(1, "Adriano Medeiros Sá", "21/01/1978", "123.123.123-12", 3);

            Console.WriteLine("----------------CLIENTE----------------");
		    Console.WriteLine("-> Nº ID DO CLIENTE: " + cliente1.idCliente);
		    Console.WriteLine("-> NOME COMPLETO: " + cliente1.nome);
		    Console.WriteLine("-> DATA DE NASCIMENTO: " + cliente1.dataNasc);
		    Console.WriteLine("-> CPF: " + cliente1.cpf);
		    Console.WriteLine("-> DIAS P/ DEVOLUÇÃO: " + cliente1.diaDev);
		    Console.WriteLine("-> QTDE TOTAL DE LOCAÇÕES: " + cliente1.filmesLocados);
		    Console.WriteLine("----------------------------------------");


            Filme filme1 = new Filme(10, "Vingadores Ultimato", "16/07/2019",
				"Após Thanos eliminar metade das criaturas vivas, os Vingadores têm de lidar com a perda de amigos e entes queridos.\n   Com Tony Stark vagando perdido no espaço sem água e comida, Steve Rogers e Natasha Romanov lideram a resistência contra o titã louco.",
				4.5, 8);

            Console.WriteLine("----------------------------FILME----------------------------------------------------------------------");
            Console.WriteLine("--> Nº ID DO FILME: " + filme1.idFilme);
            Console.WriteLine("-> TÍTULO: " + filme1.titulo);
            Console.WriteLine("-> DATA DE LANÇAMENTO: " + filme1.dataLanc); 
            Console.WriteLine("-> SINOPSE: " + filme1.sinopse);
            Console.WriteLine("-> VALOR DA LOCAÇÃO: R$ " + filme1.valorLoc);
            Console.WriteLine("-> QTDE EM ESTOQUE: " + filme1.estoque);
            Console.WriteLine("-> QTDE LOCAÇÕES: " + filme1.locado);
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

        }
    }
}
