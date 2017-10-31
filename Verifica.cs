using System;

namespace console_dotnet
{ 
    class Verifica
    {
        public Boolean geranumero(int a, int b) {
        Random rdm = new Random();
        int q = rdm.Next(a, b);
        int w = rdm.Next(a, b);
        int resultado = q + w;
        System.Console.WriteLine(q + " + " + w + "=");
        int resposta = Convert.ToInt32(Console.ReadLine());

        if (resposta == resultado) {
            System.Console.WriteLine("BOUAAA");
            return true;

        } else {
            System.Console.WriteLine("ERROUUU");
            return false;
            }
        }
    }
}
