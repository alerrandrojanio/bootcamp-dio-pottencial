using System;

namespace FundamentosCs.Common.Models
{
    public class Calculadora {

        /// <summary>
        /// Soma dois números
        /// </summary>
        /// <param name="x">Primeiro numero</param>
        /// <param name="y">Segundo número</param>
        public void Somar(int x, int y) {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y) {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y) {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y) {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y) {
            double c = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {c}");
        }

        public void Seno(double angulo) {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno, 4)}");
            
        }

        public void Coseno(double angulo) {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}º = {Math.Round(coseno, 4)}");
            
        }

        public void Tangente(double angulo) {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Cos(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente, 4)}");
            
        }

        public void RaizQuadrada(double x) {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrade de {x} = {Math.Round(raiz, 4)}");
            
        }
        
    }
}