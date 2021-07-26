using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// Recibe dos Numeros y un operador por parametro y realiza el calculo correspondiente, retornando el resultado.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            operador = ValidarOperador(operador.ElementAtOrDefault(0));

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

        /// <summary>
        /// Valida que el operador recibido sea correcto, sino lo convierte en una suma.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
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
