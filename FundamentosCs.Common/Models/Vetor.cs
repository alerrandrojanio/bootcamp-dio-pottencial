namespace FundamentosCs.Common.Models
{
    public class Vetor {

        public void CriarVetor() {
            int[] vetor = new int[5];
            vetor[0] = 12;
            vetor[1] = 13;
            vetor[2] = 14;
            vetor[3] = 15;
            vetor[4] = 16;
            
            int[] vetor2 = {1, 2, 3, 4, 5};

            Console.WriteLine($"Percorrendo com For");
            for(int i = 0; i < vetor.Length; i++) {
                Console.WriteLine($"Posicao Nº {i} - {vetor[i]}");
            }

            Console.WriteLine($"Percorrendo com Foreach");
            int iForeach = 0;
            foreach(int valor in vetor2) {
                Console.WriteLine($"Posicao Nº {iForeach} - {valor}");
                iForeach++;
            }

            Array.Resize(ref vetor, vetor.Length * 2); // redimensina o array

        }

        public void CriarLista() {
            List<string> listaString = new List<string>();

            listaString.Add("CE");
            listaString.Add("SP");
            listaString.Add("BA");

            Console.WriteLine($"Percorrendo com For");
            for(int i = 0; i < listaString.Count; i++) {
                Console.WriteLine($"Posicao Nº {i} - {listaString[i]}");
            }

            Console.WriteLine($"Percorrendo com Foreach");
            int iForeach = 0;
            foreach(string item in listaString) {
                Console.WriteLine($"Posicao Nº {iForeach} - {item}");
                iForeach++;
            }
        }
        
    }
}