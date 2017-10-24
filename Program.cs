using System;

namespace console_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            nome = "Contabilidade";
            Console.WriteLine(nome);

            Calcsoma o = new Calcsoma();
            System.Console.WriteLine(o.comissao(67, 80));
            o.avalicao();
        }
    }
}
