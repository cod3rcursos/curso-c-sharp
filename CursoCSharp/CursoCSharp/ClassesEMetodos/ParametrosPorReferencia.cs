using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero1, out int numero2) {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }

        public static void Executar() {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            // int b;
            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b} {c}");
        }
    }
}
