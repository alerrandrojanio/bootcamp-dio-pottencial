namespace FundamentosCs.Common.Models
{
    public class Tupla {

        public Tupla() {
            
        }

        public void CriarTupla(){
            (int, string, string, decimal) tupla = (7, "Alerrandro", "Janio", 1.80M);

            Console.WriteLine($"Id: {tupla.Item1}");
            Console.WriteLine($"Nome: {tupla.Item2}");
            Console.WriteLine($"Sobrenome: {tupla.Item3}");
            Console.WriteLine($"Altura: {tupla.Item4}");

            ValueTuple<int, string, string, decimal> tupla2 = (8, "Elane", "MENV", 0.90M);

            Console.WriteLine($"Id: {tupla2.Item1}");
            Console.WriteLine($"Nome: {tupla2.Item2}");
            Console.WriteLine($"Sobrenome: {tupla2.Item3}");
            Console.WriteLine($"Altura: {tupla2.Item4}");
        }
        
        
        
    }
}