using System;
using System.Collections.Generic;
using System.Data;

namespace ProjetoSenhaAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá, deseja gerar uma senha aleatória? 1 - Sim | 2 - Não \nDigite aqui: ");
            var input = Console.ReadLine();

            try
            {
                var random = new Random();

                var usuarioInput = int.Parse(input);

                const int SenhaTamanho = 9;
                const string charactersPermitidosParaSenha = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?%&#";

                var senhaConjunto = new char[SenhaTamanho];

                while (usuarioInput == 1)
                {
                    for (int i = 0; i < SenhaTamanho; i++)
                    {
                        senhaConjunto[i] = charactersPermitidosParaSenha[random.Next(0, charactersPermitidosParaSenha.Length)];
                    }
                    var senhaGerada = new string(senhaConjunto);

                    Console.WriteLine("Senha aleatória: {0}\n", senhaGerada);
                    Console.WriteLine("Precione o ENTER para continuar");
                    Console.ReadLine();

                    Console.Write("Olá, deseja gerar mais senha aleatória? 1 - Sim | 2 - Não \nDigite aqui: ");
                    var inputParaSairOuContinuar = Console.ReadLine();

                    try
                    {
                        var usuarioInputEscolheSairOuContinuar = int.Parse(inputParaSairOuContinuar);
                        if (usuarioInputEscolheSairOuContinuar == 2)
                        {
                            Console.Write("\nOk então! Até mais!");
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("inputParaSairOuContinuar can't be a integer. Sorry!");
                        throw;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Input can't be a integer. Sorry!");
                throw;
            }
        }
    }
}
