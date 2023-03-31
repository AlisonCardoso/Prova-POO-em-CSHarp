using System;
using System.Globalization;

namespace Prova_POO
{
   class Veiculo_Pesado
	{
		string _fabricante;
		string _modelo;
		int _ano;
		string _especie; // passageiro, carga, misto, passeio,
		string _placa; 
		
		
		public Veiculo_Pesado (string modelo, string fabricante, int ano, string especie, string placa)
		{
			 _fabricante = fabricante;
			 _modelo = modelo;
			 _ano = ano;
			 _especie = especie;
			 _placa = placa;
		}
		public string Modelo
		{ 
			get { return _modelo;}
			set { _modelo = value;}
		}
		public string Fabricante
		{ 
			get { return _fabricante;}
			set { _fabricante = value;}
		}
		public string Especie
		{ 
			get { return _especie;}
			set { _especie = value;}
		}
		public string Placa
		{ 
			get { return _placa;}
			set { _placa = value;}
		}
		
		 
		
		
		public int SituaçãoVeicular(int Situacao)
		{if (Situacao == 1 ){
	System.Console.WriteLine("Veiculo encontra-se no patio da empresa  ");
} 
else if (Situacao == 2 ){
	Console.WriteLine("Veiculo encontra-se em rota de entrega  ");
}
else if (Situacao == 3 ){
	Console.WriteLine("Veiculo encontra-se em manutenção ");
}
else if (Situacao == 4 ){
	Console.WriteLine("ATENÇAO!!!! Veiculo Fora da Rota Autorizada - SOLICITAR BLOQUEIO DO VEICULO");
}
else{
   Console.WriteLine("Veiculo não localizado ou inexistente ");
}
			
			return Situacao;
		}
				public override string ToString() {
				return 
						"Modelo: "
						+ Modelo
						+ " Fabricante "
						+ Fabricante
						+" Especie: "
						+  Especie 
						+ " Placa: "
						+ Placa;
						
						
						
		}
		
		
	}
	
	
	
	
}

