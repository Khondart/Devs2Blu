// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Olá, mundo! Meu nome é Éder"); //Essa chamada apresenta uma nvoa linha no console

/*
 Atalhos: 
    CTRL+ KC - Comentar seleção
    CTRL + KU - Descomentar seleção
 */

//Console.Write("Olá, mundo! Meu nome é Éder"); //Essa chamada apresenta o conteúdo a partir do cursor   
//Console.Write("Olá, mundo! Meu nome é Éder"); //Essa chamada apresenta o conteúdo a partir do cursor   

//Console.ReadLine();

//const string VALOR_PI = "3,14";


//Console.WriteLine("Olá, qual o seu nome?");
//string meuNome = Console.ReadLine();

////Concatenação simples
//Console.WriteLine("Olá " + meuNome + ", muito prazer!");

////Interpolação de string
//string mensagem = string.Format("Olá {0}, muito prazer", meuNome);
//Console.WriteLine(mensagem);

////Interpolação de string
//Console.WriteLine($"Olá {meuNome}, muito prazer");

////Declaração de variáveis por inferência
//var meuNomePorInferencia = "Éder Campos";
//Console.WriteLine(meuNomePorInferencia);

//string meuNome = "Éder Campos";
//int minhaIdade = 30;

//Console.WriteLine($"Olá, meu nome é {meuNome} e tenho {minhaIdade} anos de idade");


//Console.WriteLine("Olá, qual seu nome?");
//string meuNomeCliente = Console.ReadLine();

//Console.WriteLine("Olá, qual a sua idade?");
//string minhaIdadeCliente = Console.ReadLine();

//Console.WriteLine($"Meu nome é {meuNomeCliente} e tenho {minhaIdadeCliente} anos de idade");

//bool ganhei = false; //Bool é usado para declarar a variável com o tipo booleano (true ou false)
//ganhei = true;

//char letra = 'A'; //Char serve para definir a variável com o tipo caracter, somente comporta 1 caracter como valor
////As aspas duplas são usadas SOMENTE em caso de declarar a variável como STRING.

//string nome = "Eder";
//Console.WriteLine(nome[3]); //Os colchetes servem para que o console retorne o caracter na posição informada

////Para pular linhas é usado o comando \n
//Console.WriteLine("Olá, meu nome é Eder. \n Esse blablabla");

//É usado para gerar textos em paralelo e tem vários "pedaços" o sistema vai acumulando eles e ao final
//através do comando appendLine.ToString() aí ele é apresentado em tela, ou gera um txt
//var stringBuilder = new  System.Text.StringBuilder();
//stringBuilder.AppendLine("Olá, meu nome é Eder");
//stringBuilder.AppendLine("Esse programa foi feito em aula");

//Console.WriteLine(stringBuilder.ToString());

//Console.WriteLine("Olá, qual seu nome?");
//string meuNome = Console.ReadLine();

//Console.WriteLine($"Olá {meuNome}, muito prazer!");
//Console.WriteLine("Qual a sua idade?");
//int minhaIdade = int.Parse(Console.ReadLine()); //int.Parse é usado para realizar a conversão do que for informado nos parênteses, no caso uma string.

//Console.WriteLine($"Que legal {meuNome}! No seu próximo aniversário você terá {minhaIdade+1} anos de idade");

//var data = new DateTime();

//data = DateTime.MinValue;
//data = DateTime.MaxValue;
//data = DateTime.Today;
//data = DateTime.Now;

//Console.WriteLine(data.ToString());

//string informacao = null;

//Console.WriteLine("Você gostaria de infromar algo sobre o assunto? (Digite não caso contrário)");

//var entrada = Console.ReadLine();

//if (entrada.ToUpper() == "Não")
//{
//    Console.WriteLine("Encerramos por aqui, obrigado!");
//}
//else
//{
//    informacao = entrada;
//}

//Console.WriteLine($"Entrada: {entrada}");
//Console.WriteLine($"Informação: {informacao}");

//Console.WriteLine("Olá, qual seu nome?");
//string meuNome = Console.ReadLine();


//using System.IO.Pipes;
//using System.Runtime.CompilerServices;

//const string nome = "Éder";
//const int cep = 89042320;

//string nomeAluno = "Joãozinho";
//int cepAluno = 89010000;
//bool aprovado = true;
//decimal valor = 100;
//char conceito = 'A';



//Console.WriteLine("Olá, qual seu nome?\n");
//string meuNome = Console.ReadLine();
//Console.WriteLine($"\nOlá {meuNome}, muito prazer!\n");
//Console.WriteLine("\nQual a seu dia de nascimento?");
//int dia = int.Parse(Console.ReadLine());
//Console.WriteLine("\nQual a seu mes de nascimento?");
//int mes = int.Parse(Console.ReadLine());
//Console.WriteLine("\nQual a seu ano de nascimento?");
//int ano = int.Parse(Console.ReadLine());

//var dataUsuario = new DateTime(ano, mes, dia);

//Console.WriteLine(dataUsuario.ToString("dd/MM/yy"));



//-----------------------------------OPERADORES-------------------------------------------------

//int valor1 = 10;
//int valor2 = 12;

//decimal valorDivisao = valor1 / valor2;

//Console.WriteLine($"valor1 + valor2 = {valor1+valor2}");
//Console.WriteLine($"valor1 - valor2 = {valor1-valor2}");
//Console.WriteLine($"valor1 * valor2 = {valor1*valor2}");
//Console.WriteLine($"valor1 / valor2 = {valorDivisao.ToString("F2")}");
//Console.WriteLine($"12 % 3 = {12 % 3}");

/*int valor = 10;*/ //Declaração da variável
                    //Console.WriteLine(valor);
                    //valor += 10; //Valor da variável + 10
                    //Console.WriteLine(valor);
                    //valor -= 10; //Valor da variável -10
                    //Console.WriteLine(valor);
                    //valor *= 10; //Valor da variável * 10
                    //Console.WriteLine(valor);
                    //valor %= 55; //Módulo da divisão: diminui o valor do módulo da variável e retorna o que "sobrar"
                    //Console.WriteLine(valor);
                    //valor++; //Incremento depois do uso da variável
                    //Console.WriteLine(valor);
                    //++valor; //Incremento antes do uso da variável
                    //Console.WriteLine(valor);
                    //valor--; //Decremento depois do uso da variável
                    //Console.WriteLine(valor);
                    //--valor; //Decremento antes do uso da variável
                    //Console.WriteLine(valor);


//Console.WriteLine($"{valor} == {10} ? {valor==10}");
//Console.WriteLine($"{valor} == {8} ? {valor==8}");

//Console.WriteLine($"{valor} != {10} ? {valor != 10}");
//Console.WriteLine($"{valor} != {8} ? {valor != 8}");

//Console.WriteLine($"{valor} < {10} ? {valor < 10}");
//Console.WriteLine($"{valor} < {11} ? {valor < 11}");
//Console.WriteLine($"{valor} < {9} ? {valor < 9}");

//Console.WriteLine($"{valor} > {10} ? {valor > 10}");
//Console.WriteLine($"{valor} > {10} ? {valor > 10}");
//Console.WriteLine($"{valor} > {10} ? {valor > 10}");

//Console.WriteLine($"{valor} <= {10} ? {valor <= 10}");
//Console.WriteLine($"{valor} <= {11} ? {valor <= 11}");
//Console.WriteLine($"{valor} <= {9} ? {valor <= 9}");

//Console.WriteLine($"{valor} >= {10} ? {valor >= 10}");
//Console.WriteLine($"{valor} >= {10} ? {valor >= 10}");
//Console.WriteLine($"{valor} >= {10} ? {valor >= 10}");

//-------------------------------TABELA VERDADE-------------------

//Console.WriteLine("Tabela verdade do AND => &&");
//Console.WriteLine($"{true} && {true} = {true && true}");
//Console.WriteLine($"{false} && {true} = {false && true}");
//Console.WriteLine($"{true} && {false} = {true && false}");
//Console.WriteLine($"{false} && {false} = {false && false}");

//Console.WriteLine("Tabela verdade do OR => ||");
//Console.WriteLine($"{true} || {true} = {true || true}");
//Console.WriteLine($"{false} || {true} = {false || true}");
//Console.WriteLine($"{true} || {false} = {true || false}");
//Console.WriteLine($"{false} || {false} = {false || false}");

//Console.WriteLine("Tabela verdade do NOT => !");
//Console.WriteLine($"!{true} = {true}");
//Console.WriteLine($"!{false} = {false}");

//------------------------TERNÁRIOS---------------------------

//int idade = 70;

////string tipo = idade == 18 ? "Maior de idade" : "Menor de idade";
////string tipo = idade < 18 ? "Menor de idade" : (idade > 60 ? "Bem vivido" : "Maior de idade");

//string tipo = "";

//if (idade < 18)
//{
//    tipo = "menor de idade";
//}
//else
//{
//    tipo = "maior de idade";
//}

//Console.WriteLine($"Eu sou {tipo}");



//--------------------------------------EXERCICIO 01-----------------------------

////Número 01 - Escreva um programa que leia dois números inteiros e exiba a soma deles.

//using System.Drawing;
//using System.Reflection;
//using System.Runtime.InteropServices;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//Console.WriteLine("Informe o primeiro valor");
//int primeiroValor = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe o segundo valor");
//int segundoValor = int.Parse(Console.ReadLine());

//Console.WriteLine($"01 - A soma do primeiro valor e do segundo é {primeiroValor + segundoValor}\n");

////Número 02 - Escreva um programa que leia dois números inteiros e mostre a diferença entre o primeiro e o segundo número.

//Console.WriteLine("Informe o primeiro valor");
//int terceiroValor = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe o segundo valor");
//int quartoValor = int.Parse(Console.ReadLine());
//Console.WriteLine($"02 - A diferença entre o terceiro valor e o quarto é {terceiroValor - quartoValor}\n");

////Número 03 - Escreva um programa que leia dois números inteiros e exiba o produto deles.

//Console.WriteLine("Informe o primeiro valor");
//int quintoValor = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe o segundo valor");
//int sextoValor = int.Parse(Console.ReadLine());

//Console.WriteLine($"03 - O produto resultante da multiplicação entre os dois valores é {quintoValor * sextoValor}\n");

////Número 04 - Escreva um programa que leia dois números inteiros e mostre o resultado da divisão do primeiro pelo segundo. (Considere a divisão inteira, sem ponto flutuante.).

//Console.WriteLine("Informe o primeiro valor");
//int setimoValor = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe o segundo valor");
//int oitavoValor = int.Parse(Console.ReadLine());

//Console.WriteLine($"04 - O resultado da divisão entre os dois valores é {setimoValor / oitavoValor} \n");

////Número 05 - Escreva um programa que leia dois números inteiros e exiba o resto da divisão do primeiro pelo segundo.

//Console.WriteLine("Informe o primeiro valor");
//int nonoValor = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe o segundo valor");
//int decimoValor = int.Parse(Console.ReadLine());

//Console.WriteLine($"05 - O resto da divisão entre os dois valores informados é {nonoValor % decimoValor}");

//Console.WriteLine("\n----------------------------------------------------\n");

////Número 06 - Escreva um programa que declare uma variável inteira, atribua a ela um valor digitado pelo usuário e exiba esse valor.

//int dado = 150;
//Console.WriteLine($"06 - O informação que foi solicitada é {dado} \n");

////Número 07 - Escreva um programa que declare uma variável inteira, atribua um valor a ela, depois adicione um valor digitado pelo usuário a essa variável e exiba o resultado.

//int valor1 = 100;

//Console.WriteLine("Por favor, informe o valor a ser somado ao inicial \n");
//int valorSoma = int.Parse(Console.ReadLine());

//Console.WriteLine($"\n07 - O resultado do valor informado somado ao inicial é {valor1 + valorSoma}\n");

////Número 08 - Escreva um programa que declare uma variável inteira, atribua um valor inicial, depois subtraia um valor digitado pelo usuário dessa variável e mostre o resultado.

//int valor2 = 200;

//Console.WriteLine("Por favor, informe o valor a ser subtraído do inicial \n");
//int valorSubtrair = int.Parse(Console.ReadLine());

//Console.WriteLine($"\n08 - O resultado do valor informado subtraído do inicial é {valor2 - valorSubtrair}\n");

////Número 09 - Escreva um programa que declare uma variável inteira, atribua um valor a ela, multiplique essa variável por um número digitado pelo usuário e exiba o resultado.

//int valor3 = 20;

//Console.WriteLine("Por favor, informe o valor pelo qual o inicial será multiplicado \n");
//int valorMult = int.Parse(Console.ReadLine());
//Console.WriteLine($"\n09 - O resultado do valor inicial multiplicado pelo informado é {valor3 * valorMult}\n");

////Número 10 - Escreva um programa que declare uma variável inteira, atribua um valor inicial, divida essa variável por um número digitado pelo usuário e mostre o resultado da divisão.

//int valor4 = 50;

//Console.WriteLine("Por favor, informe o valor pelo qual o inicial será dividido \n");
//int valorDivide = int.Parse(Console.ReadLine());

//Console.WriteLine($"\n10 - O resultado do valor inicial dividido pelo informado é {valor4 / valorDivide}\n");

////Número 11 - Escreva um programa que leia dois números inteiros e exiba se eles são iguais ou não.

//Console.WriteLine("Informe o primeiro valor");
//int seIgual = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe o segundo valor");
//int seIgual02 = int.Parse(Console.ReadLine());

//if (seIgual == seIgual02)
//{
//    Console.WriteLine($"11 - Os valores informados foram {seIgual} e {seIgual02} e eles são iguais.\n");
//}
//else
//{
//    Console.WriteLine($"11 - Os valores informados foram {seIgual} e {seIgual02} e eles são diferentes.\n");
//}

////Número 12 - Escreva um programa que leia dois números inteiros e exiba se eles são diferentes.

//Console.WriteLine("Informe o primeiro valor");
//int seDiferente = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe o segundo valor");
//int seDiferente02 = int.Parse(Console.ReadLine());

//if (seDiferente != seDiferente02)
//{
//    Console.WriteLine($"12 - Os valores informados foram {seDiferente} e {seDiferente02} e eles são diferentes.\n");
//}
//else
//{
//    Console.WriteLine($"12 - Os valores informados foram {seDiferente} e {seDiferente02} e eles são iguais.\n");
//}

////Número 13 - Escreva um programa que leia dois números inteiros e mostre se o primeiro número é maior que o segundo.

//Console.WriteLine("Informe o primeiro valor");
//int seMaior = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe o segundo valor");
//int seMaior02 = int.Parse(Console.ReadLine());

//if (seMaior > seMaior02)
//{
//    Console.WriteLine($"13 - Os valores informados foram {seMaior} e {seMaior02} e o primeiro valor é maior que o segundo.\n");
//}
//else
//{
//    Console.WriteLine($"13 - Os valores informados foram {seMaior} e {seMaior02} e o primeiro valor é menor que o segundo.\n");
//}

////Número 14 - Escreva um programa que leia dois números inteiros e exiba se o primeiro número é menor que o segundo.

//Console.WriteLine("Informe o primeiro valor");
//int seMenor = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe o segundo valor");
//int seMenor02 = int.Parse(Console.ReadLine());

//if (seMenor < seMenor02)
//{
//    Console.WriteLine($"14 - Os valores informados foram {seMenor} e {seMenor02} e o primeiro valor é menor que o segundo.\n");
//}
//else
//{
//    Console.WriteLine($"14 - Os valores informados foram {seMenor} e {seMenor02} e o primeiro valor é maior que o segundo.\n");
//}

////Número 15 - Escreva um programa que leia dois números inteiros e mostre se o primeiro número é maior ou igual ao segundo.

//Console.WriteLine("Informe o primeiro valor");
//int seMaiorIgual = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe o segundo valor");
//int seMaiorIgual02 = int.Parse(Console.ReadLine());

//if (seMaiorIgual <= seMaiorIgual02)
//{
//    Console.WriteLine($"15 - Os valores informados foram {seMaiorIgual} e {seMaiorIgual02} e os valores são iguais, ou um é maior que o outro.\n");
//}
//else
//{
//    Console.WriteLine($"15 - Os valores informados foram {seMaiorIgual} e {seMaiorIgual02} e os valores são iguais, ou um é maior que o outro.\n");
//}

////Número 16 - Escreva um programa que leia dois números inteiros e verifique se ambos são maiores que zero usando o operador lógico &&.

//Console.WriteLine("Informe o primeiro valor");
//int naoZero = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe o segundo valor");
//int naoZero02 = int.Parse(Console.ReadLine());

//if (naoZero > 0 && naoZero02 > 0)
//{
//    Console.WriteLine($"16 - Os valores informados são {naoZero} e {naoZero02} e eles são maiores que 0.\n");
//}
//else
//{
//    Console.WriteLine($"16 - Revise os valores, algum deles é menor que 0. \n");
//}

////Número 17 - Escreva um programa que leia dois números inteiros e verifique se pelo menos um deles é menor que zero usando o operador lógico ||.

//Console.WriteLine("Informe o primeiro valor");
//int menorQueZero = int.Parse(Console.ReadLine());
//Console.WriteLine("Informe o segundo valor");
//int menorQueZero02 = int.Parse(Console.ReadLine());

//if (menorQueZero < 0 || menorQueZero02 < 0)
//{
//    Console.WriteLine($"17 - Pelo menos um dos valores informados {menorQueZero} e {menorQueZero02} é menor que zero.\n");
//}
//else
//{
//    Console.WriteLine($"17 - Nenhum dos valores informados {menorQueZero} e {menorQueZero02} é menor que zero.\n");
//}

////Número 18 - Escreva um programa que leia a idade de uma pessoa e use o operador ternário para verificar se ela é maior de idade ou não.

//Console.WriteLine("Qual a sua idade?");
//int idade = int.Parse(Console.ReadLine());

//Console.WriteLine($"18 - A minha idade é {idade} anos, e eu sou {(idade >= 18 ? "maior de idade" : "menor de idade")}\n");

////Número 19 - Escreva um programa que leia um número inteiro e use o operador ternário para verificar se o número é par ou ímpar.

//Console.WriteLine("Informe um número para realizar a verificação");
//int ePar = int.Parse(Console.ReadLine());

//Console.WriteLine($"19 - O número informado foi {ePar} e ele {(ePar % 2 == 0 ? "é par" : "é ímpar")}\n");

////Número 20 - Escreva um programa que leia um número inteiro e use o operador ternário para exibir "Positivo" se o número for maior que zero, "Negativo" se o número for menor que zero, e "Zero" se for exatamente zero.

//Console.WriteLine("Informe um número para realizar a verificação");
//int ultimaQuestao = int.Parse(Console.ReadLine());

//Console.WriteLine($"20 - O número informado foi {ultimaQuestao} e ele é {(ultimaQuestao > 0 ? "positivo" : (ultimaQuestao < 0 ? "negativo" : "zero"))}");

//-----------------------------------------------------ESTRUTURAS CONDICIONAIS E LAÇOS DE REPETIÇÃO---------------------------------------------

//Quando ocorrem vários "ifs" seguidos, chamamos de if encadeado.

//Console.WriteLine("Olá, qual o seu nome?");
//string nomeInformado = Console.ReadLine();

//if (nomeInformado == "Ana")
//{
//    Console.WriteLine($"Pode entrar {nomeInformado}!");
//}
//else if(nomeInformado == "Maria")
//{
//    Console.WriteLine($"Pode entrar {nomeInformado}!");
//}
//else if (nomeInformado == "João")
//{
//    Console.WriteLine($"Pode entrar {nomeInformado}!");
//}
//else if (nomeInformado == "José")
//{
//    Console.WriteLine($"Pode entrar {nomeInformado}!");
//}
//else if (nomeInformado == "Carlos")
//{
//    Console.WriteLine($"Pode entrar {nomeInformado}!");
//}
//else
//{
//    Console.WriteLine($"Desculpe {nomeInformado}, mas seu nome não está na lista.");
//}

//Console.WriteLine("Olá, qual o seu nome?");
//string nome = Console.ReadLine();

//if (nome == "Ana" || nome == "Maria" || nome == "João" || nome == "José" || nome == "Carlos")
//{
//    Console.WriteLine($"Pode entrar {nome}!");
//}
//else 
//{
//    Console.WriteLine($"Sinto muito {nome}, mas você não está na lista.");
//}

//Console.WriteLine("Olá, qual o seu nome?");
//string nome = Console.ReadLine();

//switch (nome)
//{
//    case "Ana":
//    case "João":
//    case "José":
//    case "Carlos":
//    case "Maria":
//        Console.WriteLine($"Pode entrar {nome}");
//        break;
//    default:
//        Console.WriteLine($"Desculpe {nome}, seu nome não está na lista.");
//        break;
//}

//Console.WriteLine("Qual o seu nome?");
//string nome = Console.ReadLine();
//char inicial = nome.ToUpper()[0]; //Sempre que for um COMPORTAMENTO é necessário abrir e fechar os parênteses ().

//switch (inicial)
//{
//    case 'K':
//    case 'L':
//    case 'M':
//    case 'N':
//    case 'O':
//    case 'P':
//    case 'Q':
//    case 'R':
//    case 'S':
//        Console.WriteLine($"Você pode ir para a fila 01");
//        break;
//    case 'A':
//    case 'B':
//    case 'C':
//    case 'D':
//    case 'E':
//    case 'F':
//    case 'G':
//    case 'H':
//    case 'I':
//    case 'J':
//        Console.WriteLine($"Você pode ir para a fila 02");
//        break;
//    case 'T':
//    case 'U':
//    case 'V':
//    case 'W':
//    case 'X':
//    case 'Y':
//    case 'Z':
//        Console.WriteLine($"Você pode ir para a fila 03");
//        break;
//}

//-*--------------------------------ARRAYS---------------------------------------------

//string[] alunos = new string[5]; //Criando um array com 5 posições, usar sempre a palavra reservada NEW para quando for criar um array.
//alunos[0] = "João"; //Atribuindo "João" como primeiro elemento do array (posição 0).


//string[] alunos = new string[2];

//Console.WriteLine("Digite o nome do primeiro aluno:");
//alunos[0] = Console.ReadLine();

//Console.WriteLine("Digite o nome do outro aluno:");
//alunos[1] = Console.ReadLine();

//Console.WriteLine("Lista de alunos:");
//Console.WriteLine(alunos[0]);
//Console.WriteLine(alunos[1]);

//string[] nomes = {"Marco", "Pedro", "Maria" };
//Console.WriteLine(nomes[0]);
//Console.WriteLine(nomes[1]);
//Console.WriteLine(nomes[2]);

//------------------------------EXERCICIO ARRAY-------------------------

//string[] nomes = new string[5];

//Console.WriteLine("Informe o nome do aluno desejado:");
//nomes[0] = Console.ReadLine();
//Console.WriteLine("Informe o nome do aluno desejado:");
//nomes[1] = Console.ReadLine();
//Console.WriteLine("Informe o nome do aluno desejado:");
//nomes[2] = Console.ReadLine();
//Console.WriteLine("Informe o nome do aluno desejado:");
//nomes[3] = Console.ReadLine();
//Console.WriteLine("Informe o nome do aluno desejado:");
//nomes[4] = Console.ReadLine();

//float[] notas = new float[5];

//Console.WriteLine($"\nInforme a nota do aluno {nomes[0]}:");
//notas[0] = float.Parse(Console.ReadLine());
//Console.WriteLine($"Informe a nota do aluno {nomes[1]}:");
//notas[1] = float.Parse(Console.ReadLine());
//Console.WriteLine($"Informe a nota do aluno {nomes[2]}:");
//notas[2] = float.Parse(Console.ReadLine());
//Console.WriteLine($"Informe a nota do aluno {nomes[3]}:");
//notas[3] = float.Parse(Console.ReadLine());
//Console.WriteLine($"Informe a nota do aluno {nomes[4]}:");
//notas[4] = float.Parse(Console.ReadLine());

//Console.WriteLine($"\nA nota do aluno {nomes[0]} é: {notas[0]}.");
//Console.WriteLine($"A nota do aluno {nomes[1]} é: {notas[1]}.");
//Console.WriteLine($"A nota do aluno {nomes[2]} é: {notas[2]}.");
//Console.WriteLine($"A nota do aluno {nomes[3]} é: {notas[3]}.");
//Console.WriteLine($"A nota do aluno {nomes[4]} é: {notas[4]}.");



//-------------------------------------------LISTAS-----------------------------------------

//List<string> listaAlunos = new List<string>(); //Cria a lista com dados do tipo string

//listaAlunos.Add("João"); //Adicionando o valor "João" na lista
//listaAlunos.Remove("João"); //Remove o valor "João" da lista

//----------------------------------EXERCÍCIO LISTA-----------------------------------------

//List<String> nomes = new List<string>();
//List<float> notas = new List<float>();

//Console.WriteLine("Informe o nome do aluno");
//nomes.Add(Console.ReadLine());
//Console.WriteLine("Informe a nota do aluno");
//notas.Add(float.Parse(Console.ReadLine()));

//Console.WriteLine("Informe o nome do aluno");
//nomes.Add(Console.ReadLine());
//Console.WriteLine("Informe a nota do aluno");
//notas.Add(float.Parse(Console.ReadLine()));

//Console.WriteLine("Informe o nome do aluno");
//nomes.Add(Console.ReadLine());
//Console.WriteLine("Informe a nota do aluno");
//notas.Add(float.Parse(Console.ReadLine()));

//Console.WriteLine("Informe o nome do aluno");
//nomes.Add(Console.ReadLine());
//Console.WriteLine("Informe a nota do aluno");
//notas.Add(float.Parse(Console.ReadLine()));

//Console.WriteLine("Informe o nome do aluno");
//nomes.Add(Console.ReadLine());
//Console.WriteLine("Informe a nota do aluno");
//notas.Add(float.Parse(Console.ReadLine()));

//Console.WriteLine($"A nota do aluno {nomes[0]} foi {notas[0]}");
//Console.WriteLine($"A nota do aluno {nomes[1]} foi {notas[1]}");
//Console.WriteLine($"A nota do aluno {nomes[2]} foi {notas[2]}");
//Console.WriteLine($"A nota do aluno {nomes[3]} foi {notas[3]}");
//Console.WriteLine($"A nota do aluno {nomes[4]} foi {notas[4]}");


//--------------------------------ESTRUTURAS DE REPETIÇÃO------------------------------------------
//Quando for ser realizado o uso de um FOR em uma lista, ao invés de .lenght é usado .count


//string[] alunos = {"Ana", "Pedro", "Maria" };

//for (int i = 0; i < alunos.Length; i++)
//{
//    Console.WriteLine(alunos[i]);
//}

//--------------------------------EXERCICIO TABUADA------------------------------------------------

//Console.WriteLine("Digite o número de qual tabuada você quer saber: ");
//int tabuada = int.Parse(Console.ReadLine());


//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"\n{tabuada} x {i} = {tabuada * i}");
//}

//--------------------------------WHILE------------------------------------------------------------

//List<string> alunos = new List<string>();

//Console.WriteLine("Informe o nome do aluno, ou 'OK' para sair");
//var entrada = Console.ReadLine();

//while (entrada != "Ok") 
//{
//    alunos.Add(entrada);
//    Console.WriteLine("Aluno adicionado");

//    Console.WriteLine("Informe o nome do aluno, ou 'OK' para sair");
//    entrada = Console.ReadLine();
//}

//for (int i = 0; i < alunos.Count; i++)
//{
//    Console.WriteLine(alunos[i]);
//}

//--------------------------------EXERCICIO WHILE------------------------------------------------------------



//Console.WriteLine("Digite o número desejado, ou OK para sair");
//var entrada = Console.ReadLine();

//int maiorValor = int.MinValue;
//int menorValor = int.MaxValue;

//while (entrada.ToUpper() != "OK")
//{
//    var numero = int.Parse(entrada);
//    if (menorValor > numero)
//    {
//        menorValor = numero;
//    }

//    if (maiorValor < numero)
//    {
//        maiorValor = numero;
//    }

//    Console.WriteLine("Digite o número desejado, ou OK para sair");
//    entrada = Console.ReadLine();
//}

//Console.WriteLine("Fim de execução");
//Console.WriteLine($"Maior número: {maiorValor}");
//Console.WriteLine($"Menor número: {menorValor}");


//--------------------------------EXERCICIO DO-WHILE------------------------------------------------------------

//var entrada = "";
//const string senhaCorreta = "bolinha";

//do
//{
//    Console.WriteLine("Digite sua senha: ");
//    entrada = Console.ReadLine();

//    if (entrada == senhaCorreta)
//    {
//        Console.WriteLine("Sua senha está correta!");
//    }
//    else
//    {
//        Console.WriteLine("Sua senha está incorreta, tente novamente!");
//    }

//}while (entrada != senhaCorreta);

//----------------------------------------------EXERCÍCIO DO-WHILE-----------------------------------------------------------------

//const string usuario = "juca";
//const string senha = "senhajuca";

//const string usuario2 = "ze";
//const string senha2 = "senhaze";

//const string usuario3 = "pelé";
//const string senha3 = "senhapelé";

//var leitura = "";
//var leituraSenha = "";

//bool logado = false;

//do
//{
//    Console.WriteLine("Digite seu usuário: ");
//    leitura = Console.ReadLine();

//    if (leitura == usuario)
//    {
//        Console.WriteLine($"Olá {usuario}, agora informe a sua senha:");
//        leituraSenha = Console.ReadLine();

//        if (leituraSenha == senha)
//        {
//            logado = true;
//            Console.WriteLine($"Seja bem vindo {usuario}");
//        }
//        else
//        {
//            Console.WriteLine("Usuário ou senha não encontrado, tente novamente!");
//        }
//    }

//    if (leitura == usuario2)
//    {
//        Console.WriteLine($"Olá {usuario2}, agora informe a sua senha:");
//        leituraSenha = Console.ReadLine();

//        if (leituraSenha == senha2)
//        {
//            logado = true;
//            Console.WriteLine($"Seja bem vindo {usuario2}");
//        }
//        else
//        {
//            Console.WriteLine("Usuário ou senha não encontrado, tente novamente!");
//        }
//    }

//    if (leitura == usuario3)
//    {
//        Console.WriteLine($"Olá {usuario3}, agora informe a sua senha:");
//        leituraSenha = Console.ReadLine();

//        if (leituraSenha == senha3)
//        {
//            logado = true;
//            Console.WriteLine($"Seja bem vindo {usuario3}");
//        }
//        else
//        {
//            Console.WriteLine("Usuário ou senha não encontrado, tente novamente!");
//        }
//    }

//} while (!logado);

//----------------------------------------------EXERCÍCIO FOREACH---------------------------------------------------------------------------

//string entrada = string.Empty;

//List<string> listaAlunos = new List<string>();



//do {
//    Console.WriteLine("Informe o nome do aluno ou OK para sair.");
//    entrada = Console.ReadLine();

//    if (!string.IsNullOrEmpty(entrada))
//    {
//        entrada = entrada.ToUpper();

//        if (entrada != "OK")
//        {
//            listaAlunos.Add(entrada);
//        }
//    }
//    else
//    {
//        Console.WriteLine("Digite um nome válido!");
//    }

//} while (entrada.ToUpper() != "OK");

//int contagem = 0;
//Console.Clear();
//Console.WriteLine("Cadastrada Turma");
//Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
//foreach (string aluno in listaAlunos)
//{
//    Console.WriteLine($"#{++contagem} {aluno}");
//}
//Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

//---------------------------------------------------------LISTA DE EXERCÍCIOS 02---------------------------------------------------------

//Instrução IF
//Exercício 01 - Identificar ímpar ou par

//using System;
//using System.Security.Cryptography.X509Certificates;

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

//ARRAYS
//Exercício 02 - Criação array de 10 posições, retorno do maior e menor

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


//LISTAS
//Exercício 01 - Criação de lista com "n" nomes e exibição deles

//List<string> nomes = new List<string>();

//string nome = string.Empty;

//while (true)
//{
//    Console.WriteLine("Informe um nome para inserir na lista, ou sair para encerrar");
//    nome = Console.ReadLine();

//    if (nome.ToLower() == "sair")
//    {
//        break;
//    }

//    nomes.Add(nome);
//}

//Console.WriteLine("Os nomes informados foram: ");

//foreach (string n in nomes)
//{
//    Console.WriteLine(n);
//}

//Exercício 02 - Lista de numeros entre 1 e 100, com validação e verificao de valores

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
//        Console.Write("Entrada inválida. Digite um número entre 1 e 100: ");
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

//FOR
//Exercício 01 - Fatorial

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

//Exercício 02 - Tabuada

//Console.WriteLine("Digite o número de qual tabuada você quer saber: ");
//int tabuada = int.Parse(Console.ReadLine());


//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"\n{tabuada} x {i} = {tabuada * i}");
//}



//WHILE
//Exercício 01 - Lista de números até entrar negativo, retornar soma;
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

//DO - WHILE
//Exercício 01 - SISTEMA DE CAIXA ELETRÔNICO;

//using System;

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





//-----------------------------------------OBJETOS---------------------------------------------------------------------

//namespace MeuHelloWorld
//{
//    public class Pessoa
//    {
//        public string Nome;
//        public int Idade;
//        public string CPF;
//    }

//    public class Carro
//    {
//        public string Modelo { get; set; }
//        public string Marca { get; set; }
//        public int Ano { get; set; }
//        public string Placa { get; set; }
//        public string cor { get; set; }

//        public void Acelerar() //Os parênteses simbolizam a ASSINATURA do método, o que possibilita usar o mesmo método com dados diferentes, chama-se SOBRECARGA ou OVERLOAD
//        {
//            Console.WriteLine("O carro está acelerando!");
//        }
//    }


//    public class Executar
//    {
//        public static void ExecutarApplicacao()
//        {
//            var carro = new Carro();
//            carro.Modelo = "HB20";
//            carro.cor = "Prata";

//            Console.WriteLine(carro.ToString());
//        }
//    }
//}

//-------------------------------------------------CONSTRUTORES---------------------------------------------------------

////Construtor padrão: Quando não implementamos um cosntrutor na classe.
//var carro1 = new Carro();
//carro1.Marca = "Ferrari";

////Construtor customizado: Implementamos um construtor na classe.
//var carro2 = new Carro("Honda");

////Construtor de objetos C#: Quando utilizamos as propriedades diretamente.
//var carro3 = new Carro() { Marca = "Hyundai" }; //Pode-se implementar todas as informações entre chaves.

////Objeto anônimo: QUando passamos um valor no tipo object (anônimo).
////Esse tipo de construção não é indicada e é sucetível a erros no código.
//var carro4 = new { Marca = "Fiat" };

//----------------------------------------------------ELEMENTOS ESTÁTICOS-------------------------------------------------



