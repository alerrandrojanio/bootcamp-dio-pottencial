using System;

namespace FundamentosCs.Common.Models {
public class Pessoa
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    
    
    public int Idade { get; set; }

    public Pessoa() {

    }

    public Pessoa(string nome, string sobrenome) {
            Nome = nome;
            Sobrenome = sobrenome;
        }

    public void Deconstruct(out string nome, out string sobrenome) {
            nome = Nome;
            sobrenome = Sobrenome;
        }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
    }

}
}