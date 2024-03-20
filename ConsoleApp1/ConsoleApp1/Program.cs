using System;

class Program
{
    static void Main()
    {
        // Boas-vindas
        Console.WriteLine("Bem-vindo ao meu jogo! Você nunca vai me superar muahahah!");
        Console.Write("Você gostaria de saber as regras do jogo? (S/N): ");
        char resposta = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // Regras do Jogo
        if (resposta == 's' || resposta == 'S')
        {
            Console.WriteLine("\nRegras:");
            Console.WriteLine("- Você deve tentar adivinhar o número aleatório sorteado por mim;");
            Console.WriteLine("- O número será entre 1 e 20;");
            Console.WriteLine("- Se falhar, você deve tentar novamente, mas dessa vez a resposta será a soma dos números que sorteei!");
            Console.WriteLine("- Se a soma dos números atingir 100, você perde o jogo! Vitória pra mim!\n");
        }

        // Gerador de números aleatórios
        Random rand = new Random();
        int target = rand.Next(1, 21);
        int total = target;

        // Input do usuário
        int guess;
        bool isNumber = false;
        do
        {
            Console.Write("Qual número eu sorteei? ");
            string input = Console.ReadLine();
            isNumber = int.TryParse(input, out guess);
            if (!isNumber)
                Console.WriteLine("Não sabe ler?! Insira um número válido!");
        } while (!isNumber);

        // Loop de resultados
        while (total <= 100)
        {
            if (guess == total)
            {
                // Vitória
                Console.WriteLine("Droga! Você acertou o número, trapaceiro!");
                //Encerra o programa
                Console.WriteLine("Pressione ENTER para encerrar o programa.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            // Tente Novamente
            Console.WriteLine($"Hahahahah! Errou! O número sorteado foi: {target}");
            Console.WriteLine($"A soma dos números sorteados é: {total}");
            do
            {
                Console.Write("Tenta de novo! Duvido acertar: ");
                string input = Console.ReadLine();
                isNumber = int.TryParse(input, out guess);
                if (!isNumber)
                    Console.WriteLine("Por favor, insira um número válido.");
            } while (!isNumber);

            target = rand.Next(1, 21);
            total += target; // Faz a soma dos números
        }
        // Game Over
        Console.WriteLine($"Hahahahah! Errou! O número sorteado foi: {target}");
        Console.WriteLine($"A soma dos números sorteados é: {total}");
        Console.WriteLine("Infalível! Eu venci! Até a próxima, perdedor!");
        //Encerra o programa
        Console.WriteLine("Pressione ENTER para encerrar o programa.");
        Console.ReadLine();
        Environment.Exit(0);
    }
}
