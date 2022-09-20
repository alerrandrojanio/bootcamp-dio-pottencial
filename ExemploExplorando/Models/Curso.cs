namespace ExemploExplorando.Models
{
    public class Curso {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno) {
            Alunos.Add(aluno);

        }

        public int QuantidadeDeAlunos() {
            return Alunos.Count;
        }

        public void RemoverAluno(Pessoa aluno) {
            Alunos.Remove(aluno);
        }
        
        public void ListarAlunos(){
            foreach(Pessoa aluno in Alunos) {
                Console.WriteLine($"Nome: {aluno.NomeCompleto}");
                
            }
        }
        
    }
}