namespace ExemploExplorando.Models
{
    public class Pessoa {
        public Pessoa() {
            
        }
        public Pessoa(string nome, string sobrenome) {
            gitNome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;
        public string Nome {  
            // get => return _nome.ToUpper();
            get {
                return _nome.ToUpper();
            }
            
            set {
                if(value == "") {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }

                _nome = value;
            } 
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade { 
            get {
                return _idade;
            }
            
            set {
                if(value < 0) {
                    throw new ArgumentException("Idade não pode ser menor que 0!");
                }

                _idade = value;
            } 
        }
        
        public void Apresentar() {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
            
        }
        
    }
}