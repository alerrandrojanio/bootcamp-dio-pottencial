namespace FundamentosCs.Common.Models
{
    public class Fila {

        public Fila() {
            
        }

        public void CriarFila() {
            Queue<int> fila = new Queue<int>();

            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);
            fila.Enqueue(5);

            ImprimeFila(fila);

            Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

            ImprimeFila(fila);

        }

        public void ImprimeFila(Queue<int> fila) {
            foreach(int item in fila){
                Console.WriteLine($"{item}");
            }
        }
        
    }
}