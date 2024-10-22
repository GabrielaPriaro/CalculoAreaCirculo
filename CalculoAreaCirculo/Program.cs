//Problema "circulo"
//Fazer um programa para ler o valor "r" do raio de um círculo, e depois mostrar o valor da área do
//círculo com três casas decimais. A fórmula da área do círculo é a seguinte: 𝑎𝑟𝑒𝑎 = 𝜋. 𝑟ଶ.
//Você pode usar o valor de 𝜋 fornecido pela biblioteca da sua linguagem de programação, ou então, se preferir, use
//diretamente o valor 3.14159.

using System.Globalization;

namespace CalculoAreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, area;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o valor do raio do circulo: ");
            raio = double.Parse(Console.ReadLine(), CI);

            area = Math.PI * Math.Pow(raio, 2);

            Console.Write($"AREA = {area.ToString("F3", CI)}");
        }
    }
}
