using System;

namespace FundamentosCs.Common.Models
{
    public class Variavel {

        public string Texto { get; set; }
        public int Quantidade { get; set; }
        public double Altura { get; set; }
        public decimal Preco { get; set; }
        public Boolean Condicao { get; set; }
        public DateTime DataAtual { get; set; }
        
        
        
        public void Apresentar() {
            Texto = "Seja bem vindo";
            Quantidade = 1;
            Altura = 1.80;
            Preco = 1.80M;
            Condicao = true;
            DataAtual = DateTime.Now;

            Console.WriteLine("Texto: " + Texto);
            Console.WriteLine("Quantidade: " + Quantidade);
            Console.WriteLine("Altura Double: " + Altura);
            Console.WriteLine("Altura String: " + Altura.ToString("0.00"));
            Console.WriteLine("Preco: " + Preco);
            Console.WriteLine("Condicao: " + Condicao);
            Console.WriteLine("Data/Hora Atual: " + DataAtual);
            Console.WriteLine("Data Atual String: " + DataAtual.ToString("dd/MM/yyyy"));
            
        }

        public void Conversao(){
            string Texto = null;
            int Numero = Convert.ToInt32(Texto); // Valor null se torna 0
            Numero = int.Parse(Texto); // Erro ao usar Parse em null

            int Inteiro = 5;
            string StringInteiro = Inteiro.ToString();  

        }
        
    }
}