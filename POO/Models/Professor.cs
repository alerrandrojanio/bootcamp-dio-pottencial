namespace POO.Models
{
    public class Professor : Pessoa {
        public decimal Salario { get; set; }
        
        public override void Apresentar() {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e meu salário é R$ {salario}");
            
        }
        
    }
}