using System.Globalization;

namespace FundamentosCs.Common.Models
{
    public class Valor {

        public void Porcentagem() {
            double porcentagem = .3421;

            Console.WriteLine($"Decimal: {porcentagem}");
            Console.WriteLine($"Porcentagem: {porcentagem.ToString("P")}");

        }

        public void Monetario() {
            decimal valor = 10.00M;

            Console.WriteLine($"Normal: {valor}");
            Console.WriteLine($"Em reais: {valor:C}");
            Console.WriteLine($"Em dolares: {valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
        }

        public void Data() {
            DateTime data = DateTime.Now;

            Console.WriteLine($"{data}");
            Console.WriteLine($"{data.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"{data.ToShortDateString()}");
            Console.WriteLine($"{data.ToString("HH:mm")}");
            Console.WriteLine($"{data.ToShortTimeString()}");

            string dataString = "2002-13-17 18:00";
            bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data2);
            
            if(sucesso) {
                Console.WriteLine($"Conversão com sucesso! Data: {data2}");
            }
            else {
                Console.WriteLine($"{data2} não é uma data válida!");
            }

        }
        
    }
}