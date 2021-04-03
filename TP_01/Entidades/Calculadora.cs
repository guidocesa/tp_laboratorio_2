using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        static double Operar(Numero num1, Numero num2, string operador)
        {
            operador = ValidarOperador(operador.ElementAt(0));

            switch(operador)
            {
                case "+":
                    {
                        return num1 + num2;
                    }
                case "-":
                    {
                        return num1 - num2;
                    }
                case "*":
                    {
                        return num1 * num2;
                    }
                case "/":
                    {
                        return num1 / num2;
                    }
                default:
                    return 0;
            }
        }

        static private string ValidarOperador(char operador)
        {
            if(operador != '+' && operador != '-' && operador != '*' && operador != '/')
            {
                return "+";
            }
            else
            {
                return operador.ToString();
            }
        }
    }
}
