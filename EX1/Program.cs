using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
        }
         public static void Exercicio1()
        {
            Console.WriteLine("                         Exercicio 1");
            Console.WriteLine(" ");

            float _resultado = 0;
            float[] Numeros;
            Numeros = new float[5];

            Console.WriteLine("Digite um numero");
            Numeros[0] = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            Numeros[1] = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            Numeros[2] = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            Numeros[3] = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            Numeros[4] = float.Parse(Console.ReadLine());

            Console.Clear();

            _resultado = Numeros[0] + Numeros[1] + Numeros[2] + Numeros[3] + Numeros[4];
            Console.WriteLine("O total da soma de todos os numeros é: " + _resultado);

            Console.WriteLine("Lista dos numeros digitados na ordem em que foram inseridos");
            Console.WriteLine(Numeros[0]);
            Console.WriteLine(Numeros[1]);
            Console.WriteLine(Numeros[2]);
            Console.WriteLine(Numeros[3]);
            Console.WriteLine(Numeros[4]);

            Console.WriteLine("Tecle 'ENTER' para prosseguir para a proxima resolução");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Exercicio2()
        {
            Console.WriteLine("                         Exercicio 2");
            string[] _nomes;
            _nomes = new string[5];

            Console.WriteLine("Digite um nome");
            _nomes[0] = Console.ReadLine();

            Console.WriteLine("Digite outro nome");
            _nomes[1] = Console.ReadLine();

            Console.WriteLine("Digite outro nome");
            _nomes[2] = Console.ReadLine();

            Console.WriteLine("Digite outro nome");
            _nomes[3] = Console.ReadLine();

            Console.WriteLine("Digite outro nome");
            _nomes[4] = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("Lista dos nomes inseridos na ordem");
            Console.WriteLine(_nomes[0]);
            Console.WriteLine(_nomes[1]);
            Console.WriteLine(_nomes[2]);
            Console.WriteLine(_nomes[3]);
            Console.WriteLine(_nomes[4]);
            Console.WriteLine("________________________________________________");
            Console.WriteLine("Lista dos nomes inseridos, em ordem invertida");
            Console.WriteLine(_nomes[4]);
            Console.WriteLine(_nomes[3]);
            Console.WriteLine(_nomes[2]);
            Console.WriteLine(_nomes[1]);
            Console.WriteLine(_nomes[0]);

            Console.WriteLine("Tecle 'ENTER' para prosseguir para proxima resolução");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Exercicio3()
        {
            Console.WriteLine("                         Exercicio 3");

            float[] _numeros;
            float[] _multi;
            _numeros = new float[10];
            _multi = new float[10];

            Console.WriteLine("Digite um numero");
            _numeros[0] = float.Parse(Console.ReadLine());
            _multi[0] = _numeros[0] * 5;

            Console.WriteLine("Digite outro numero");
            _numeros[1] = float.Parse(Console.ReadLine());
            _multi[1] = _numeros[1] * 5;

            Console.WriteLine("Digite outro numero");
            _numeros[2] = float.Parse(Console.ReadLine());
            _multi[2] = _numeros[2] * 5;

            Console.WriteLine("Digite outro numero");
            _numeros[3] = float.Parse(Console.ReadLine());
            _multi[3] = _numeros[3] * 5;

            Console.WriteLine("Digite outro numero");
            _numeros[4] = float.Parse(Console.ReadLine());
            _multi[4] = _numeros[4] * 5;

            Console.WriteLine("Digite um numero");
            _numeros[5] = float.Parse(Console.ReadLine());
            _multi[5] = _numeros[5] * 5;

            Console.WriteLine("Digite outro numero");
            _numeros[6] = float.Parse(Console.ReadLine());
            _multi[6] = _numeros[6] * 5;

            Console.WriteLine("Digite outro numero");
            _numeros[7] = float.Parse(Console.ReadLine());
            _multi[7] = _numeros[7] * 5;

            Console.WriteLine("Digite outro numero");
            _numeros[8] = float.Parse(Console.ReadLine());
            _multi[8] = _numeros[8] * 5;

            Console.WriteLine("Digite outro numero");
            _numeros[9] = float.Parse(Console.ReadLine());
            _multi[9] = _numeros[9] * 5;
            Console.Clear();

            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("Lista dos numeros na ordem de entrada");
            Console.WriteLine(" ");
            Console.WriteLine(_numeros[0]);
            Console.WriteLine(_numeros[1]);
            Console.WriteLine(_numeros[2]);
            Console.WriteLine(_numeros[3]);
            Console.WriteLine(_numeros[4]);
            Console.WriteLine(_numeros[5]);
            Console.WriteLine(_numeros[6]);
            Console.WriteLine(_numeros[7]);
            Console.WriteLine(_numeros[8]);
            Console.WriteLine(_numeros[9]);
            Console.WriteLine("");

            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("Lista dos numeros na ordem de entrada, Multiplicados por 5");
            Console.WriteLine(" ");
            Console.WriteLine(_multi[0]);
            Console.WriteLine(_multi[1]);
            Console.WriteLine(_multi[2]);
            Console.WriteLine(_multi[3]);
            Console.WriteLine(_multi[4]);
            Console.WriteLine(_multi[5]);
            Console.WriteLine(_multi[6]);
            Console.WriteLine(_multi[7]);
            Console.WriteLine(_multi[8]);
            Console.WriteLine(_multi[9]);
            Console.WriteLine("_____________________________________________________________");

            Console.WriteLine("Pressione 'ENTER' para finalizar a execução do algoritimo.");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
