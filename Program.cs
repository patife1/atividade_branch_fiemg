﻿using System.IO;

Console.Clear();

int largura = 50; // Ajuste a largura do cabeçalho conforme necessário

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("=".PadLeft(37, '='));
Console.WriteLine("Atividade 13 - Jogo da Mega-Sena");
Console.WriteLine("=".PadLeft(37, '='));
Console.ResetColor();


Random random = new Random();

int qtdDezenaInformada,
    qtdJogoInformada;
bool repetir;

Console.Write("Deseja realizar quantos jogos: ");
if (int.TryParse(Console.ReadLine(), out qtdJogoInformada))

{
    Console.Write("Deseja realizar quantos jogos?: ");
    if (!int.TryParse(Console.ReadLine(), out qtdJogoInformada) || qtdJogoInformada < 1)
    {        Console.Write("Informar a quantidade de dezena: ");
        if (int.TryParse(Console.ReadLine(), out qtdDezenaInformada))
        {
            if (qtdDezenaInformada < 6 || qtdDezenaInformada > 15)
                        repetir = true;
                else
                        repetir = false;

            if (repetir == false)
            {
                Console.WriteLine();
                for (int qtdJogo = 1; qtdJogo <= qtdJogoInformada; qtdJogo++)
                {
                    for (int qtdDezena = 1; qtdDezena <= qtdDezenaInformada; qtdDezena++)
                    {
                        Console.Write($" {random.Next(1,61):D2} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jogos gerados e salvos no arquivo 'jogos-mega-sena.txt'.\n");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Quantidade dezena menor que 6");
                repetir = true;

            }     
        } else
            {
                repetir = true;
                Console.WriteLine("Número inválido!");
            }
        
    }while (repetir == true);
}
else

        Console.WriteLine("Número inválido!");

