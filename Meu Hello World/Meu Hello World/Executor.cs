using MeuHelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;




public class Carro
{
    public const int PORCENTAGEM_RESERVA = 20;

    public string Modelo;
    public int Ano;
    public int TanqueLimite;
    public int TanqueAtual;

    public void Info()
    {
        Console.WriteLine($"Carro de modelo {Modelo} e ano {Ano}.");
    }

    public bool Reserva()
    {
        var porcentagemLimite = (TanqueLimite / 100) * PORCENTAGEM_RESERVA;
        Console.WriteLine("Dados do tanque: ");
        Console.WriteLine($"20%: {porcentagemLimite}");
        Console.WriteLine($"Atual: {TanqueAtual}");

        return TanqueAtual < porcentagemLimite;
    }
}

//    public class Executor
//    {
//        public static void Executar() //void = vazio
//        {
//            var carro = new Carro();
//            carro.Modelo = "Clio";
//            carro.Ano = 1995;
//            carro.TanqueLimite = 100;
//            carro.TanqueAtual = 21;

//            //Console.WriteLine($"Carro de modelo {carro.Modelo} e ano {carro.Ano}.");
//            carro.Info();
//            Console.WriteLine($"O carro {(carro.Reserva() ? "SIM" : "NÃO")} está na reserva!");
//        }

//    }
//}

//    //public class Animal
//    //{
//    //    public string Especie;
//    //    public string NomeCientifico;
//    //    public int Idade;

//    //    public void SomEmitido()
//    //    {
//    //        Console.WriteLine($"Au Au");
//    //    }

//    //    public class Livro
//    //    {
//    //        public string Nome;
//    //        public string Autor;
//    //    }

//    //public class Calculadora
//    //{

//    //    public decimal Somar(decimal valor1, decimal valor2)
//    //    {
//    //        return valor1 + valor2;
//    //    }

//    //    public decimal Subtrair(decimal valor1, decimal valor2)
//    //    {
//    //        return valor1 - valor2;
//    //    }

//    //    public decimal Multiplicar(decimal valor1, decimal valor2)
//    //    {
//    //        return valor1 * valor2;
//    //    }

//    //    public decimal Dividir(decimal valor1, decimal valor2)
//    //    {
//    //        return valor1 / valor2;
//    //    }
//}

//            public class Executor
//            {
//                public static void Acao()
//                {
//                    //var animal = new Animal();
//                    //animal.Especie = "Cachorro";
//                    //animal.NomeCientifico = "Canis lupus familiaris";
//                    //animal.Idade = 7;


//                    //Console.WriteLine($"A espécie do animal é {animal.Especie}, o nome científico da espécie é {animal.NomeCientifico} e a idade dele é {animal.Idade}");
//                    //Console.WriteLine($"O som emiido por esse animal é: ");
//                    //animal.SomEmitido();

//                    //var livro = new Livro();
//                    //livro.Nome = "Bolinha";
//                    //livro.Autor = "Marco";

//                    //Console.WriteLine($"O livro escolhido foi {livro.Nome} e o autor é {livro.Autor}");

//                    //var calc = new Calculadora();

//                    //Console.WriteLine(calc.Somar(256,64));
//                    //Console.WriteLine(calc.Subtrair(256, 64));
//                    //Console.WriteLine(calc.Multiplicar(256, 64));
//                    //Console.WriteLine(calc.Dividir(256, 64));

//                    var carro = new Carro();
//                    carro.Modelo = "Clio";
//                    carro.Ano = 1995;
//                    carro.TanqueLimite = 100;
//                    carro.TanqueAtual = 21;

//                    Console.WriteLine($"Carro de modelo {carro.Modelo} e ano {carro.Ano}.");
//                    carro.Info();
//                    Console.WriteLine($"O carro {(carro.Reserva() ? "SIM" : "NÃO")} está na reserva!");
//                }

//            }
//        }

//=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

namespace MeuHelloWorld
{

    public enum DiasSemana
    {
        Domingo,
        Segunda,
        Terca,
        Quarta,
        Quinta,
        Sexta,
        Sabado
    }

    public class Aluno
    {
        // Propriedades do Aluno
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Matricula { get; set; }

        // Método para calcular a idade em meses
        public int CalcularIdadeEmMeses()
        {
            return Idade * 12;
        }

        // Método para exibir as informações do aluno
        public void ExibirInformacoes()
        {
            int idadeEmMeses = CalcularIdadeEmMeses();
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade} anos ({idadeEmMeses} meses)");
            Console.WriteLine($"Matrícula: {Matricula}");
        }

        // Método para capturar os dados do usuário
        public void SolicitarDados()
        {
            Console.Write("Informe o nome do aluno: ");
            Nome = Console.ReadLine();

            Console.Write("Informe a idade do aluno (em anos): ");
            Idade = int.Parse(Console.ReadLine());

            Console.Write("Informe a matrícula do aluno: ");
            Matricula = Console.ReadLine();
        }
    }

    public class contaBancaria
    {
        public string Titular;
        public double Saldo;

        private static int _ContagemContasCadastradas = 0; //Private deixa acessivel a informação somente dentro da classe
        public static int ContagemContasCadastradas { get => _ContagemContasCadastradas; } //=> = Lambda, é como se fosse um "atalho", algo como para encurtar o código
        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Valor de {valor} depositado!");
        }

        public void Sacar(double valor)
        {
            if (Saldo > valor)
            {
                Console.WriteLine("Saque não realizado!");
            }
            else
            {
                Console.WriteLine("Saque realizado!");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Sua conta possui o saldo de {Saldo}");
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public contaBancaria(string titular, int saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;

            _ContagemContasCadastradas++;

        }

        public contaBancaria()
        {
            _ContagemContasCadastradas++;
        }
    }

    public class Produto
    {
        public string Nome;
        public double Preco;
        public int QuantidadeEstoque;

        public void AtualizarEstoque(int quantidade)
        {
            QuantidadeEstoque = quantidade;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Dados do Produto");
            Console.WriteLine($"Nome do produto:{Nome}");
            Console.WriteLine($"Preço do produto:{Preco.ToString("C")}"); //Método Preco.ToString("C") serve para formatar o número fornecido como moeda, atribuindo automaticamnte a moeda do pais do idioma do sistema
            Console.WriteLine($"Quantidade em estoque:{QuantidadeEstoque}");
        }
    }

    public class Pessoa
    {
        private static int _ContagemPessoasCadastradas = 0; //Private deixa acessivel a informação somente dentro da classe
        public static int ContagemPessoasCadastradas { get => _ContagemPessoasCadastradas; } //=> = Lambda, é como se fosse um "atalho", algo como para encurtar o código

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
            _ContagemPessoasCadastradas++;
        }
    }

    public class Produto2
    {
        private string Nome;
        private decimal preco;

        public void AlterarNome(string novoNome)
        {
            Nome = novoNome;
            Console.WriteLine("Nome Alterado");
        }

        public void AlterarPreco(decimal novoPreco)
        {
            if (novoPreco > 0)
            {
                Console.WriteLine("Preço Alterado");
            }
            else
            {
                Console.WriteLine("Preço não alterado");
            }
        }
    }

    public class Veiculo
    {
        public int Velocidade { get; set; }

        public void Mover()
        {
            Console.WriteLine("O veiculo está se movendo");
        }
    }

    public class Carro2 : Veiculo
    {
        public int QtdPortas { get; set; }

        public void Buzinar()
        {
            Console.WriteLine("Bee!");
        }
    }

    public class Animal
    {
        protected string Som { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine($"O animal está emitindo o som {Som}");
        }
    }

    public class Cachorro : Animal
    {
        public Cachorro()
        {
            Som = ("AuAu");
        }
    }

    public class Gato : Animal
    {
        public Gato()
        {
            Som = ("Miau");
        }
    }

    public class InstrumentoMusical
    {
        protected string Nota { get; set; } //Protected é usado para definir um nivel de segurança, mas que fica visivel para as classes que a implementam

        public void Tocar()
        {
            Console.WriteLine($"O instrumento está fazendo a seguinte nota: {Nota}");
        }

    }

    public class Violao : InstrumentoMusical
    {
        public Violao()
        {
            Nota = ("Dó");
        }
    }

    public class Piano : InstrumentoMusical
    {
        public Piano()
        {
            Nota = ("Sol");
        }
    }

    public class Tambor : InstrumentoMusical
    {
        public Tambor()
        {
            Nota = ("BUM!");
        }
    }

    public abstract class RegistroDB
    {
        protected abstract string NomeTabela { get; }
        public void Select()
        {
            var select = $"SELECT * FROM {NomeTabela}";
            Console.WriteLine($"Executando select no banco de dados: {select}");
        }
    }

    public class PessoaDB : RegistroDB
    {
        protected override string NomeTabela { get => "PESSOAS"; }
    }

    public abstract class Forma
    {
        public abstract double CalcularPerimetro();

        public abstract void ExibirInformacoes();
    }

    class Retangulo : Forma
    {
        private double Largura { get; set; }
        private double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Retângulo - Largura: {Largura}, Altura: {Altura}, Perímetro: {CalcularPerimetro()}");
        }
    }

    class Triangulo : Forma
    {
        private double Lado1 { get; set; }
        private double Lado2 { get; set; }
        private double Lado3 { get; set; }

        public Triangulo(double lado1, double lado2, double lado3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public override double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Triângulo - LadoA: {Lado1}, LadoB: {Lado2}, LadoC: {Lado3}, Perímetro: {CalcularPerimetro()}");
        }
    }

    public interface IMotor
    {
        void Ligar();
        void Desligar();
    }

    public interface ICambioManual
    {
        void ColocarMarchaAcima();
        void ColocarMarchaAbaixo();
    }

    public class Gol : Carro2, IMotor, ICambioManual
    {
        public void ColocarMarchaAbaixo()
        {
            Console.WriteLine("Reduzindo a marcha");
        }

        public void ColocarMarchaAcima()
        {
            Console.WriteLine("Aumentando a marcha");
        }

        public void Desligar()
        {
            Console.WriteLine("Desligando o motor");
        }

        public void Ligar()
        { 
            Console.WriteLine("Ligando o motor");
        }
    }

    public interface IAutenticavel
    {
        bool Autenticar(string senha);
        void Deslogar();
    }

    public class UsuarioSistemas : IAutenticavel
    {
        private string senha;

        public UsuarioSistemas(string senha)
        {
            this.senha = senha;
        }

        public bool Autenticar(string senha)
        {
            if (this.senha == senha)
            {
                Console.WriteLine("Login bem-sucedido!");
                return true;
            }
            Console.WriteLine("Senha incorreta.");
            return false;
        }

        public void Deslogar()
        {
            Console.WriteLine("Logout realizado.");
        }
    }

    public class Executor
    {
        public static void Executar()
        {
            //var aluno = new Aluno();
            //aluno.Nome = "Bolinha";
            //aluno.Idade = 25;
            //aluno.Matricula = "Aluno2546";

            //aluno.ExibirInformacoes();

            //Console.WriteLine($"Existem {Pessoa.ContagemPessoasCadastradas} pessoas cadastradas no sistema.");

            //var p1 = new Pessoa()
            //{
            //    Nome = "João",
            //    Idade = 18,
            //};

            //var p2 = new Pessoa()
            //{
            //    Nome = "Maria",
            //    Idade = 16,
            //};

            //var p3 = new Pessoa()
            //{
            //    Nome = "Maria",
            //    Idade = 23
            //};     


            //var c1 = new contaBancaria()
            //{
            //    Titular = "João",
            //    Saldo = 2000,
            //};

            //var c2 = new contaBancaria()
            //{
            //    Titular = "Bolinha",
            //    Saldo = 10000,
            //};

            //Console.WriteLine($"Existem {contaBancaria.ContagemContasCadastradas} contas cadastradas na agência.");


            //var p1 = new Produto()
            //{
            //    Nome = "Bola",
            //    Preco = 20000,
            //    QuantidadeEstoque = 30
            //};

            //p1.ExibirInfo();


            //DiasSemana numero = (DiasSemana)2;

            //switch (numero)
            //{
            //    case DiasSemana.Domingo:
            //        Console.WriteLine("É Domingo");
            //        break;
            //    case DiasSemana.Segunda:
            //        Console.WriteLine("É Segunda");
            //        break;
            //    case DiasSemana.Terca:
            //        Console.WriteLine("É Terça");
            //        break;
            //    case DiasSemana.Quarta:
            //        Console.WriteLine("É Quarta");
            //        break;
            //    case DiasSemana.Quinta:
            //        Console.WriteLine("É Quinta");
            //        break;
            //    case DiasSemana.Sexta:
            //        Console.WriteLine("É Sexta");
            //        break;
            //    case DiasSemana.Sabado:
            //        Console.WriteLine("É Sábado");
            //        break;
            //    default:
            //        break;

            //}

            //ExibirMensagemConsole("Olá!");

            //int velocidadeFusca = 0;
            //var carro = new Carro ("Fusca",1976);
            //carro.Info();

            //Console.WriteLine($"Carro de modelo {carro.Modelo} e ano {carro.Ano}.");
            //carro.Info();
            //Console.WriteLine($"O carro {(carro.Reserva() ? "SIM" : "NÃO")} está na reserva!");

            //var cachorro = new Cachorro();

            //    cachorro.EmitirSom();

            //var gato = new Gato();

            //    gato.EmitirSom();


            //List<InstrumentoMusical> instrumentos = new List<InstrumentoMusical>();

            //instrumentos.Add(new Violao());
            //instrumentos.Add(new Piano());
            //instrumentos.Add(new Tambor());


            //foreach (var instrumento in instrumentos)
            //{
            //    instrumento.Tocar();
            //}

            //var registro = new PessoaDB();
            //registro.Select();


            //Forma retangulo = new Retangulo(5.0, 10.0);
            //retangulo.ExibirInformacoes();


            //Forma triangulo = new Triangulo(3.0, 4.0, 5.0);
            //triangulo.ExibirInformacoes();

            UsuarioSistemas usuario = new UsuarioSistemas("1234");

            usuario.Autenticar("1234"); 
            usuario.Deslogar(); 

        }
    }
}


