Using System;

namespace console-dotnet
{ 
    class Verifica
    {
        public void geranumero(int a, int b) {
        Random rdm = new Random();
        int q = rdm.Next(a, b);
        int w = rdm.Next(a, b);
        System.Console.WriteLine(q + " + " + w + "=");

        }
    }
}
