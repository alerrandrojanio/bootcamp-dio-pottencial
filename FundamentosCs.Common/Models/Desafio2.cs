namespace FundamentosCs.Common.Models
{
    public class Desafio2 {

        public Desafio2() {
            
        }

        public void Desafio() {
            List<string> listaResultados = new List<string>();
            int qt = int.Parse(Console.ReadLine());

            for (int i = 0; i < qt; i++){

                string[] v = Console.ReadLine().Split(' ');

                string a = v[0];
                string b = v[1];

                int tamanhoMaior = a.Length;
                int tamanhoMenor = b.Length;

                if (tamanhoMenor > tamanhoMaior) {
                    listaResultados.Add("nao encaixa");
                    //Console.WriteLine("nao encaixa");
                    continue;
                }

                int posicao = tamanhoMaior - tamanhoMenor;
                string aux = a.Substring(posicao, tamanhoMenor);

                if(b.Equals(aux)) {
                listaResultados.Add("encaixa");
                //Console.WriteLine("encaixa");
                }
                    
                else {
                    listaResultados.Add("nao encaixa");
                    //Console.WriteLine("nao encaixa");
                }
                    
            }

            foreach(var item in listaResultados) {
                Console.WriteLine($"{item}");
            
            }
        }
        
    }
}