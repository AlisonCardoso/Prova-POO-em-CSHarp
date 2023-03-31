using System;

namespace Prova_POO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine(" Insira os Dados do Veiculo de Carga Pesada( Caminhao): ");
			
			Console.Write("Modelo: ");
			string modelo = Console.ReadLine();
			
			Console.Write("Fabricante: ");
			string fabricante = Console.ReadLine();
			Console.Write("Ano de Fabricação:  ");
			int ano = int.Parse(Console.ReadLine());
			
			Console.Write("Especie:  ");
			string especie = Console.ReadLine();
			
			Console.Write("Placa:  ");
			string placa = Console.ReadLine();


			Veiculo_Pesado Feneme = new Veiculo_Pesado(modelo, fabricante, ano,especie, placa );
			Console.WriteLine();
			
			Console.WriteLine("Modelo  " + Feneme);
			Console.WriteLine();
			Console.Write("Digite a Situação que o veiculo se encontra: ");
			int situacao  = int.Parse(Console.ReadLine());
			
			Feneme.SituaçãoVeicular(situacao);
			Console.WriteLine(	);
			Console.WriteLine("Dados Atualizados " + Feneme);
			Console.WriteLine(	);
			
			Veiculo_Leve Pampa = new Veiculo_Leve(modelo, fabricante, ano,especie, placa );
			Console.WriteLine();
			Console.WriteLine(" Insira os Dados do Veiculo de Carga leve(Pickup):   ");
			
			Console.Write("Modelo: ");
			modelo = Console.ReadLine();
			
			Console.Write("Fabricante: ");
			 fabricante = Console.ReadLine();
			Console.Write("Ano de Fabricação:  ");
			ano = int.Parse(Console.ReadLine());
			
			Console.Write("Especie:  ");
			 especie = Console.ReadLine();
			
			Console.Write("Placa:  ");
			placa = Console.ReadLine();

			
			Console.WriteLine("Modelo  " + Pampa);
			Console.WriteLine();
			Console.Write("Digite a Situação que o veiculo se encontra: ");
			situacao  = int.Parse(Console.ReadLine());
			
			Pampa.SituaçãoVeiculo(situacao);
			Console.WriteLine(	);
			Console.WriteLine("Dados Atualizados " + Pampa);
			Console.WriteLine(	);
		
		}
	}
}
	