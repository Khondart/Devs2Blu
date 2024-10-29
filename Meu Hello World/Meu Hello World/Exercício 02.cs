//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////---------------------------------------------------------LISTA DE EXERCÍCIOS 02---------------------------------------------------------
///
//FAVOR RODAR OS EXERCÍCIOS UM A UM, PARA EVITAR ERRO NOS NOMES DE VARÁVEIS <3

////Instrução IF
////Exercício 01 - Identificar ímpar ou par


//int numeroDigitado = 0;
//bool seNumeroValido = false;

//while (!seNumeroValido)
//{
//    Console.WriteLine("Informe um número:");
//    string entrada = Console.ReadLine();
//    seNumeroValido = int.TryParse(entrada, out numeroDigitado);

//    if (!seNumeroValido)
//    {
//        Console.WriteLine("Você não digitou um número!");
//    }
//}

//if (numeroDigitado % 2 == 0)
//{
//    Console.WriteLine($"01 - O número informado foi {numeroDigitado} e ele é par!");
//}
//else
//{
//    Console.WriteLine($"01 - O número informado foi {numeroDigitado} e ele é impar!");
//}

////Exercício 02 - verificação de idade

//Console.WriteLine("Informe o seu nome:");
//var nome = Console.ReadLine();
//Console.WriteLine($"Olá {nome}, qual a sua idade?");
//var idade = int.Parse(Console.ReadLine());

//if (idade < 18)
//{
//    Console.WriteLine($"02 - {nome}, você é menor de idade e não pode entrar");
//}
//else if (idade >= 18 && idade <= 60)
//{
//    Console.WriteLine($"02 - Bem vindo {nome}, pode entrar!");
//}
//else
//{
//    Console.WriteLine($"02 - {nome}, você tem mais de 60 anos e não pode entrar");
//}

////Instrução SWITCH
////Exercício 01 - verificação dia da semana

//Console.WriteLine("Informe um número entre 1 e 7:");
//var dia = Console.ReadLine();

//switch (dia)
//{
//    case "1":
//        Console.WriteLine("Domingo");
//        break;
//    case "2":
//        Console.WriteLine("Segunda-feira");
//        break;
//    case "3":
//        Console.WriteLine("Terça-feira");
//        break;
//    case "4":
//        Console.WriteLine("Quarta-feira");
//        break;
//    case "5":
//        Console.WriteLine("Quinta-feira");
//        break;
//    case "6":
//        Console.WriteLine("Sexta-feira");
//        break;
//    case "7":
//        Console.WriteLine("Sábado");
//        break;
//    default:
//        Console.WriteLine("Você digitou uma informação inválida");
//        break;
//}

////ARRAYS
////Exercício 01 - Criação array de 5 posições, soma e exibição deles

//int[] somaValores = new int[5];

//Console.WriteLine("Informe o primeiro valor:");
//somaValores[0] = int.Parse(Console.ReadLine());

//Console.WriteLine("Informe o segundo valor:");
//somaValores[1] = int.Parse(Console.ReadLine());

//Console.WriteLine("Informe o terceiro valor:");
//somaValores[2] = int.Parse(Console.ReadLine());

//Console.WriteLine("Informe o quarto valor:");
//somaValores[3] = int.Parse(Console.ReadLine());

//Console.WriteLine("Informe o quinto valor:");
//somaValores[4] = int.Parse(Console.ReadLine());

//Console.WriteLine($"Os números informados foram {somaValores[0]}, {somaValores[1]}, {somaValores[2]}, {somaValores[3]} e {somaValores[4]}. A soma deles é: {somaValores[0] + somaValores[1] + somaValores[2] + somaValores[3] + somaValores[4]}.");

////ARRAYS
////Exercício 02 - Criação array de 10 posições, retorno do maior e menor

//int[] ArrayNumeros = new int[10];
//int maiorNumero = int.MinValue;
//int menorNumero = int.MaxValue;

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Informe um número: ");
//    ArrayNumeros[i] = int.Parse(Console.ReadLine());
//}

//for (int i = 0; i < 10; i++)
//{
//    if (ArrayNumeros[i] > maiorNumero)
//    {
//        maiorNumero = ArrayNumeros[i];
//    }
//    if (ArrayNumeros[i] < menorNumero)
//    {
//        menorNumero = ArrayNumeros[i];
//    }
//}

//Console.WriteLine($"Maior número: {maiorNumero}");
//Console.WriteLine($"Menor número: {menorNumero}");

////ARRAYS
////Exercício 03 - Criação array de 5 posições, exibição dos dados em ordem inversa

//string[] nomes = new string[5];

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Digite um nome: ");
//    nomes[i] = Console.ReadLine();
//}

//Console.WriteLine("\n Exibindo os nomes na ordem inversa: ");

//for (int i = 4; i >= 0; i--)
//{
//    Console.WriteLine(nomes[i]);
//}


////LISTAS
////Exercício 01 - Criação de lista com "n" nomes e exibição deles

//List<string> nomes = new List<string>();

//string nome = string.Empty;

//while (true)
//{
//    Console.WriteLine("informe um nome para inserir na lista, ou sair para encerrar");
//    nome = Console.ReadLine();

//    if (nome.ToLower() == "sair")
//    {
//        break;
//    }

//    nomes.Add(nome);
//}

//Console.WriteLine("os nomes informados foram: ");

//foreach (string n in nomes)
//{
//    Console.WriteLine(n);
//}

////Exercício 02 - Lista de numeros entre 1 e 100, com validação e verificao de valores

//List<int> numeros = new List<int>();
//int tentativas = 3;
//int acertos = 0;


//Console.WriteLine("Informe 10 números entre 1 e 100 para criar a lista:");
//for (int i = 0; i < 10; i++)
//{
//    int numero;
//    Console.Write($"Digite o {i + 1}º número: ");

//    while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 100)
//    {
//        Console.WriteLine("Entrada inválida. Digite um número entre 1 e 100: ");
//    }

//    numeros.Add(numero);
//}

//Console.Clear();

//Console.WriteLine("\nVocê tem 3 chances para adivinhar um número da lista!");

//for (int i = 0; i < tentativas; i++)
//{
//    Console.Write("Digite um número entre 1 e 100: ");
//    int numeroUsuario;

//    while (!int.TryParse(Console.ReadLine(), out numeroUsuario) || numeroUsuario < 1 || numeroUsuario > 100)
//    {
//        Console.Write("Entrada inválida. Digite um número entre 1 e 100: ");
//    }

//    if (numeros.Contains(numeroUsuario))
//    {
//        Console.WriteLine("Parabéns! O número está na lista.");
//        acertos++;
//    }
//    else
//    {
//        Console.WriteLine("O número não está na lista.");
//    }
//}

//Console.WriteLine($"\nVocê acertou {acertos} número(s)!");

////FOR
////Exercício 01 - Fatorial

//Console.Write("Digite um número inteiro positivo: ");
//int numero = 0;

//while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
//{
//    Console.Write("Entrada inválida. Digite um número inteiro positivo: ");
//}

//int fatorial = 1;
//for (int i = 1; i <= numero; i++)
//{
//    fatorial *= i;
//}

//Console.WriteLine($"\nO fatorial de {numero}! é {fatorial}");

////Exercício 02 - Tabuada

//Console.WriteLine("Digite o número de qual tabuada você quer saber: ");
//int tabuada = int.Parse(Console.ReadLine());


//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"\n{tabuada} x {i} = {tabuada * i}");
//}


////WHILE
////Exercício 01 - Lista de números até entrar negativo, retornar soma;
//int numero = 0;
//int soma = 0;

//Console.WriteLine("Digite números positivos. Para encerrar, insira um número negativo:");

//while (true)
//{
//    Console.Write("Digite um número: ");

//    if (int.TryParse(Console.ReadLine(), out numero))
//    {
//        if (numero < 0)
//        {
//            break;
//        }

//        soma += numero;
//    }
//    else
//    {
//        Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
//    }
//}

//Console.WriteLine($"\nA soma de todos os números positivos inseridos é: {soma}");

////DO - WHILE
////Exercício 01 - SISTEMA DE CAIXA ELETRÔNICO;

//class Program
//{
//    static void Main(string[] args)
//    {
//        double saldo = 0.0;
//        string nome;

//        // Pergunta o nome do cliente
//        nome = ObterNomeCliente();

//        int opcao;
//        do
//        {
//            // Limpar a tela
//            Console.Clear();
//            Console.WriteLine($"Banco +Devs2Blu, seja bem-vindo, {nome}!");
//            Console.WriteLine("=== Menu ===");
//            Console.WriteLine("1. Consultar Saldo");
//            Console.WriteLine("2. Realizar Depósito");
//            Console.WriteLine("3. Realizar Saque");
//            Console.WriteLine("4. Sair");
//            Console.Write("Escolha uma opção: ");

//            // Ler a opção do usuário e verificar se é um número
//            opcao = ObterOpcaoMenu();

//            switch (opcao)
//            {
//                case 1:
//                    ConsultarSaldo(saldo);
//                    break;
//                case 2:
//                    saldo = RealizarDeposito(saldo);
//                    break;
//                case 3:
//                    saldo = RealizarSaque(saldo);
//                    break;
//                case 4:
//                    Console.WriteLine("Obrigado por utilizar o Banco +Devs2Blu, volte sempre!");
//                    break;
//                default:
//                    Console.WriteLine("Opção inválida. Tente novamente.");
//                    break;
//            }

//            // Pausar para o usuário ver o resultado
//            if (opcao != 4)
//            {
//                Console.WriteLine("Pressione qualquer tecla para continuar...");
//                Console.ReadKey();
//            }

//        } while (opcao != 4);
//    }

//    static string ObterNomeCliente()
//    {
//        string nome;
//        do
//        {
//            Console.Write("Digite seu nome: ");
//            nome = Console.ReadLine();

//            // Verifica se o nome não é vazio e contém apenas letras
//            if (string.IsNullOrWhiteSpace(nome) || !IsValidName(nome))
//            {
//                Console.WriteLine("Por favor, forneça um nome válido (apenas letras).");
//            }
//        } while (string.IsNullOrWhiteSpace(nome) || !IsValidName(nome));

//        return nome;
//    }

//    static int ObterOpcaoMenu()
//    {
//        int opcao;
//        while (!int.TryParse(Console.ReadLine(), out opcao))
//        {
//            Console.WriteLine("Por favor, forneça uma opção válida (número).");
//        }
//        return opcao;
//    }

//    static bool IsValidName(string name)
//    {
//        foreach (char c in name)
//        {
//            if (!char.IsLetter(c) && !char.IsWhiteSpace(c)) // Verifica se é letra ou espaço
//                return false;
//        }
//        return true;
//    }

//    static void ConsultarSaldo(double saldo)
//    {
//        Console.WriteLine($"Seu saldo atual é: R$ {saldo:F2}");
//    }

//    static double RealizarDeposito(double saldo)
//    {
//        double valorDeposito;

//        do
//        {
//            Console.Write("Digite o valor a ser depositado: ");
//            string input = Console.ReadLine();

//            // Verifica se a entrada é válida
//            if (string.IsNullOrWhiteSpace(input) || !double.TryParse(input, out valorDeposito))
//            {
//                Console.WriteLine("Por favor, forneça um valor válido (número).");
//            }
//            else if (valorDeposito < 0)
//            {
//                Console.WriteLine("Valor inválido! O depósito deve ser um valor positivo.");
//            }
//            else if (valorDeposito == 0)
//            {
//                Console.WriteLine("Nenhum valor foi depositado. Deseja informar um novo valor? (1 - Sim, 2 - Não): ");
//                int resposta = ObterOpcaoSimNao();
//                if (resposta == 2)
//                {
//                    return saldo; // Retorna o saldo sem alteração
//                }
//            }
//            else
//            {
//                saldo += valorDeposito;
//                Console.WriteLine($"Depósito de R$ {valorDeposito:F2} realizado com sucesso.");
//                return saldo; // Retorna o saldo atualizado
//            }
//        } while (true); // Continua até que um depósito válido seja feito
//    }

//    static double RealizarSaque(double saldo)
//    {
//        double valorSaque;

//        do
//        {
//            Console.WriteLine($"Seu saldo atual é: R$ {saldo:F2}");
//            Console.Write("Digite o valor a ser sacado: ");
//            string input = Console.ReadLine();

//            // Verifica se a entrada é válida
//            if (string.IsNullOrWhiteSpace(input) || !double.TryParse(input, out valorSaque))
//            {
//                Console.WriteLine("Por favor, forneça um valor válido (número).");
//            }
//            else if (valorSaque > saldo)
//            {
//                Console.WriteLine("Saldo insuficiente para realizar esta operação.");
//                Console.Write("Deseja informar um novo valor? (1 - Sim, 2 - Não): ");
//                int resposta = ObterOpcaoSimNao();
//                if (resposta == 2)
//                {
//                    return saldo; // Retorna o saldo sem alteração
//                }
//            }
//            else if (valorSaque < 0)
//            {
//                Console.WriteLine("Valor inválido! O saque deve ser um valor positivo.");
//            }
//            else if (valorSaque == 0)
//            {
//                Console.WriteLine("Nenhum valor foi retirado da sua conta. Deseja informar um novo valor? (1 - Sim, 2 - Não): ");
//                int resposta = ObterOpcaoSimNao();
//                if (resposta == 2)
//                {
//                    return saldo; // Retorna o saldo sem alteração
//                }
//            }
//            else
//            {
//                saldo -= valorSaque;
//                Console.WriteLine($"Saque de R$ {valorSaque:F2} realizado com sucesso.");
//                return saldo; // Retorna o saldo atualizado
//            }
//        } while (true); // Continua até que um saque válido seja feito
//    }

//    static int ObterOpcaoSimNao()
//    {
//        int resposta;
//        while (!int.TryParse(Console.ReadLine(), out resposta) || (resposta != 1 && resposta != 2))
//        {
//            Console.WriteLine("Por favor, forneça uma resposta válida (1 - Sim, 2 - Não).");
//        }
//        return resposta;
//    }
//}
