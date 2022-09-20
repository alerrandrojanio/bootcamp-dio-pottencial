using FundamentosCs.Common.Models;

Vetor vetor = new Vetor();

vetor.CriarLista();














// using System;
// using System.IO;
// using System.Linq;

// class DIO {

//     static void Main(string[] args){

//         int qt = int.Parse(Console.ReadLine());

//         for (int i = 0; i <= qt; i++){

//             string temp = Console.ReadLine();
//             string[] numbers = temp.Split(" ", 2, StringSplitOptions.RemoveEmptyEntries);
//             char[] charArray = numbers[0].ToCharArray();
//             string b = numbers[1];
//             string numberA = "";

//             for(int l = charArray.Length - 1; l >= 0; l--){
//                 numberA += charArray[l];
//                 char[] temp2 = numberA.ToCharArray();
//                 Array.Reverse(temp2);
//                 string a = string.Join("", temp2);
                
//                 if (a == b){
//                     Console.WriteLine("encaixa");
//                 }
//                 else if (temp2.Length <= 0){
//                     Console.WriteLine("nao encaixa");
//                 }
//             }

//         }

//     }
// }


