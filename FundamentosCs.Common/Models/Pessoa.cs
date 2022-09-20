using System;

namespace FundamentosCs.Common.Models
{
    public class Pessoa {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(){
            this.Nome = "";
            this.Idade = 0;
        }
        
        public void Apresentar() { 
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
        }

    }
}