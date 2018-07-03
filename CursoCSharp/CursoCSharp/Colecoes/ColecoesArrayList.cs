using System;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar() {
            var arraylist = new ArrayList {
                "Palavra",
                3,
                true
            };

            arraylist.Add(3.14);
            //arraylist.Count

            foreach (var item in arraylist) {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
