using System;

namespace console_dotnet
{
    class Calcsoma
    {
        double resultado;

            public double comissao(double valor, double quantidade) {
                resultado = (valor*quantidade)*0.1;
                return resultado;
            }


            public Boolean avalicao() {
            if(resultado >= 200) {
                System.Console.WriteLine(resultado + " reais: Resultado Satisfatório");
                return true;
            } else {
                System.Console.WriteLine(resultado + " reais: Resultado Não Satisfatório");
                return false;
            }
        }
    }
}