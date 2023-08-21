using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_SortedSet_002
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7,8 , 9, 10};

            //união entre conjutos
            //estou instanciando o conjunto uniao e pegando todos os itens do conjunto ja existente 'a'
            SortedSet<int> c = new SortedSet<int>(a);
            //agora fiz união do meu conjunto (0,2,4,5,6,8,10) + (5,6,7,8,9,10)
            //resumindo , uniao reaproveitou elementos ja existentes da 'a' e logo depois
            // fez a fusão com 'b', 
            //ATENÇÃO: NÃO SERA FEITO REPETIÇÃO DE ELEMENTOS JA PRESENTES NO CONJUNTO b, 
            //NÃO TERA REPETIÇÃO, SOMENTE REAPROVEITAMENTO.
            c.UnionWith(b);

            PrintCollection(c);
            //como utilizamos um SortedSet (ira mostrar de forma ordenada), diferente do HastSet (desorganizado)

            //INTERSECTION
            SortedSet<int> d= new SortedSet<int>(a);
            d.IntersectWith(b);//ira imprimir somente os elementos repetidos ( que esta presente em ambos conjutos)

            PrintCollection(d);

            //DIFERENC => DIFERENÇA
            SortedSet<int> e = new SortedSet<int>(a);

            e.ExceptWith(b);// ira remover todos os elementos que 
            PrintCollection(e);

        }
        //criar função auxiliar
        static void PrintCollection <T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection) {
            Console.Write(obj + " ");}
            Console.WriteLine();
        }

    }
}
