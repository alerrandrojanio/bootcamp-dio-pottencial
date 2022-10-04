namespace POO.Models
{
    public class ContaCorrente {
        public ContaCorrente(int numeroConta, decimal saldoInicial) {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        
        private decimal saldo;

        public void Sacar(decimal valor) {
            if(saldo >= valor) {
                saldo -= valor;
                Console.WriteLine($"Saque realizado!");
            }
            else {
                Console.WriteLine($"Valor é maior que o saldo!");
                
            }
        }

        public void ExibirSaldo() {
            Console.WriteLine($"Seu saldo disponível é: {Saldo}");
        }


    }
}