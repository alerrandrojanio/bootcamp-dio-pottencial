namespace FundamentosCs.Common.Models
{
    public class Dictionary {

        public Dictionary() {
            
        }

        public void CriaDictionary() {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("CE", "Ceará");
            estados.Add("SP", "São Paulo");
            estados.Add("BA", "Bahia");

            ImprimeDictionary(estados);
            Console.WriteLine($"-----------------");

            estados.Remove("BA");

            ImprimeDictionary(estados);
            Console.WriteLine($"-----------------");

            estados["SP"] = "São Paulo - Valor Alterado";

            ImprimeDictionary(estados);

        }
        
        public void ImprimeDictionary(Dictionary<string, string> dictionary){
            foreach(var item in dictionary) {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");  
            }
        }

        public bool ChaveExiste(Dictionary<string, string> dictionary, string chave) {
            if(dictionary.ContainsKey(chave)) {
                return true;
            }
            return false;
        }

        public void ImprimeValor(Dictionary<string, string> dictionary, string chave) {
            Console.WriteLine($"{dictionary[chave]}");
        }

    }
}