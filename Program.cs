using System;

class Programa
{
    static void Main(string[] args)
    {
        // Entrada das notas
        string entrada = Console.ReadLine();

        // Separar os valores e convertê-los para inteiros
        string[] notasString = entrada.Split(',');
        int produtividade = int.Parse(notasString[0]);
        int qualidade = int.Parse(notasString[1]);
        int pontualidade = int.Parse(notasString[2]);

        // Calcular a média
        double media = (produtividade + qualidade + pontualidade) / 3.0;

        string elegivelParaBonus;
        // Verificar a elegibilidade para bônus
        if (media >= 7.0)
        {
            elegivelParaBonus = "Sim";
        }
        else
        {
            elegivelParaBonus = "Não";
        }

        // Exibir os resultados
        Console.WriteLine($"Media: {media}");
        Console.WriteLine($"Elegivel para bonus: {elegivelParaBonus}");
    }
} 
