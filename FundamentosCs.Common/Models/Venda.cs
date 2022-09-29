using Newtonsoft.Json;

namespace FundamentosCs.Common.Models
{
    public class Venda {

        public Venda() {
            
        }

        public Venda(int id, string produto, decimal preco, DateTime dataVenda) {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }

        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        
        
        
        public string Serializar(Object o) {
            string serializado = JsonConvert.SerializeObject(o, Formatting.Indented);

            return serializado;
        }

        public void Serializar() {
            DateTime dataAtual = DateTime.Now;

            Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
            Venda v2 = new Venda(2, "Licença de Software", 120.00M, dataAtual);

            List<Venda> listaVenda = new List<Venda>();
            listaVenda.Add(v1);
            listaVenda.Add(v2);

            string serializado = JsonConvert.SerializeObject(listaVenda, Formatting.Indented);

            Console.WriteLine($"{serializado}");

            CriarJson(serializado);
        }

        public void CriarJson(string json) {
            try {
                File.WriteAllText("../Arquivos/vendas.json", json);
                Console.WriteLine($"Arquivo criado!");
            }
            catch(Exception ex) {
                Console.WriteLine($"{ex.Message}");
                
            }
        }
        
        public void LerJson() {
            try {
                string conteudoArquivo = File.ReadAllText("../Arquivos/vendas.json");

                List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

                foreach(Venda venda in listaVenda) {
                    Console.WriteLine($"Id: {venda.Id}, Prudoto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
                }
            }
            catch(Exception ex) {
                Console.WriteLine($"{ex.Message}");
                
            }
        }
        
        
    }
}