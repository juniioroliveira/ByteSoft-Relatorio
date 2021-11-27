using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteSoftRelatorio
{
    class Calcular
    {
        public static float Soma { get; set; }
        public static int valorA { get; set; }
        public static int valorB { get; set; }
        public static int valorC { get; set; }
        public static int valorD { get; set; }
        public static int Cancelado { get; set; }
        public static int Estornado { get; set; }
        public static int Devolvido { get; set; }
        public static int Finalizado { get; set; }
        public static float Resultado { get; set; }
        public static float Margem { get; set; }
        public static string Total { get; set; }

        public static void Porcentagem(int a, int b, int c, int d)
        {
            Cancelado = a;
            Estornado = b;
            Devolvido = c;
            Finalizado = d;

            valorA = Cancelado;
            valorB = Estornado;
            valorC = Devolvido;
            valorD = Finalizado;

            Soma = valorA + valorB + valorC;
            Resultado = Soma / valorD;
            Margem = Resultado * 100;
            //Porcentagem = Soma / valorD * 100;

            Total = Margem.ToString("0.00", CultureInfo.InvariantCulture); ///+ "%"
        }
    }
}
