using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro {
        public static int Soma(this int num, int outroNumero) {
            return num + outroNumero;
        }

        public static int Subtracao(this int num, int outroNumero) {
            return num - outroNumero;
        }
    }

    class MetodosDeExtensao
    {
        public static void Executar() {
            int numero = 5;

            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numero.Subtracao(10));

            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.Subtracao(4));
        }
    }
}
