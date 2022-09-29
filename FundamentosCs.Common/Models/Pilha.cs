namespace FundamentosCs.Common.Models
{
    public class Pilha {
        
        public Pilha() {
            
        }

        public void CriarPilha() {
            Stack<int> pilha = new Stack<int>();

            pilha.Push(2);
            pilha.Push(4);
            pilha.Push(6);
            pilha.Push(8);

            ImprimePilha(pilha);

            Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");
            
            ImprimePilha(pilha);

        }

        public void ImprimePilha(Stack<int> pilha) {
            foreach(int item in pilha){
                Console.WriteLine($"{item}");
            }
        }
    }
}