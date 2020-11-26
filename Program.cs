using System;

namespace Exercicio_2_Aula_23_11_2020
{
    class Program
    {
        static void Main(string[] args)

        //Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
        //da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
        //sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.

        {
            Console.WriteLine("EXERCÍCIO 2");

            Console.WriteLine("Selecione o tipo de combustível:");
            Console.WriteLine("[A] - Álcool");
            Console.WriteLine("[G] - Gasolina");
            Console.Write("Opção desejada:");

            string combustivel = Console.ReadLine();

            Console.Write("Digite a quantidada de combustível em litros: ");

            float quantidadeCombustivel = float.Parse(Console.ReadLine());


            float precoAlcool   = 4.9f;
            float precoGasolina = 5.3f;
            float porcalcool1 = 0.05f;
            float porcalcool2 = 0.03f;
            float porcgasolina1 = 0.06f;
            float porcgasolina2 = 0.04f;
            float retornoDesconto;

            
            switch (combustivel.ToLower())
            {
                case "a":
                    retornoDesconto = aplicarDesconto(quantidadeCombustivel,precoAlcool,porcalcool1,porcalcool2);
                    ExibirValorPago(retornoDesconto);
                    break;

                case "g":
                    retornoDesconto = aplicarDesconto(quantidadeCombustivel,precoGasolina,porcgasolina1,porcgasolina2);
                    ExibirValorPago(retornoDesconto);
                    break;

                default:

                    Console.WriteLine("Opção inválida");

                    break;
            }        

                float aplicarDesconto(float litros, float preco, float porc1, float porc2){
                    if(litros > 20){
                        float valorTotal = litros * preco;
                        float desconto = (litros * preco) * porc1;
                        return valorTotal - desconto;
                    }else{
                        float valorTotal = litros * preco;
                        float desconto = (litros * preco) * porc2;
                        return valorTotal - desconto;
                    }
            }//FIM APLICAR DESCONTO
            void ExibirValorPago(float valor){

                Console.WriteLine($"O valor total a ser pago é de:R${valor}.");
            }

        }
    }
}
