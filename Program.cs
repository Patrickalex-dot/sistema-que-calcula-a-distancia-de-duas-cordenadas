using System;

namespace sistema_que_calcula_a_distancia_de_duas_cordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Xa;
            decimal Xb;
            decimal Ya;
            decimal Yb;
            decimal XaElevadoA2;
            decimal XbElevadoA2;
            decimal YaElevadoA2;
            decimal YbElevadoA2;
            decimal subDeX;
            decimal subDeY;
            decimal somaDeXeY;
            

            Console.WriteLine("Digite a posição de Xa");
            Xa = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a posição de Xb");
            Xb = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a posição de Ya");
            Ya = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a posição de Yb");
            Yb = Convert.ToDecimal(Console.ReadLine());


            subDeX = (XaElevadoA2 - XbElevadoA2);
            subDeY = (YaElevadoA2 - YbElevadoA2);

            XaElevadoA2 = (Xa * Xa);
            XbElevadoA2 = (Xb * Xb);
            YaElevadoA2 = (Xb * Xb);
            YbElevadoA2 = (Xb * Xb);

          

            somaDeXeY = (subDeX + subDeY);

            Console.WriteLine("A distancia de A até B é de: " + somaDeXeY);
        }
    }
}
