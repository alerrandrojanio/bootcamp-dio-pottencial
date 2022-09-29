namespace FundamentosCs.Common.Models
{
    public class Arquivo {

        public Arquivo() {
            
        }

        /// <summary>
        /// Lê as linhas de um arquivo de texto e salva em um vetor de string
        /// </summary>
        /// <param name="caminho">Caminho de onde encontra-se o arquivo</param>
        public void LerArquivo(string caminho) {
            try {
                string[] linhas = File.ReadAllLines(caminho);

                foreach(string linha in linhas) {
                    Console.WriteLine($"{linha}");
                
                }
            } 
            catch(FileNotFoundException ex) {
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
            }
            catch(DirectoryNotFoundException ex) {
                Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");  
            } 
            catch(Exception ex) {
                Console.WriteLine($"Ocorreu um exceção genérica. {ex.Message}");   
            }
            finally {
                Console.WriteLine($"Chegou até aqui!");
            }
        }

        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo2(string caminho) {
            try {
                string[] linhas = File.ReadAllLines(caminho);

                return (true, linhas, linhas.Count());
            }
            catch(Exception) {
                return (false, new string[0], 0);
            }
        }

        public void ImprimeTupla(){
            var (sucesso, linhasArquivo, quantidadeLinhas) = new Arquivo().LerArquivo2("../Arquivos/arquivoLeitura.txt");

            if(sucesso) {
                Console.WriteLine($"Quatidade de linhas: {quantidadeLinhas}");
                
                foreach(string linha in linhasArquivo) {
                    Console.WriteLine($"{linha}");
                    
                }
            }
        }
        
    }
}