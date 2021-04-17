using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Cambia el valor del Numero luego de validar el valor recibido por parametro.
        /// </summary>
        /// <param name="numero"></param>
        public void SetNumero(string numero)
        {
            this.numero = ValidarNumero(numero);
        }

        /// <summary>
        /// Intenta parsear el string recibido, devuelve 0 si el valor no es valido.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private double ValidarNumero(string numero)
        {
            double parseo;

            double.TryParse(numero, out parseo);

            return parseo;
        }

        /// <summary>
        /// Crea una instancia de numero con valor 0.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Crea una instacia de numero con el valor recibido por parametro.
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Crea una instacia de numero con el valor recibido por parametro luego de que este sea validado.
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            this.SetNumero(strNumero);
        }

        /// <summary>
        /// Checkea si el string recibido corresponde a un numero binario.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private static bool EsBinario(string binario)
        {
            foreach(char c in binario)
            {
                if (!(c.Equals('0') || c.Equals('1') || c.Equals('\n')))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Convierte un numero binario recibido como string a su valor decimal si es posible.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        static public string BinarioDecimal(string binario)
        {
            int devolucion = 0;

            int contador = (binario.Length - 2);
            int digito;

            if(EsBinario(binario))
            {
                foreach (char c in binario)
                {

                    int.TryParse(c.ToString(), out digito);

                    if (contador == 0)
                    {
                        devolucion += digito;
                        break;//Se sale del ciclo para no tomar errores con los demas char del string. Ej. \n.
                    }
                    else
                    {
                        devolucion += (int)Math.Pow(digito * 2, contador);
                    }

                    contador--;
                }

                return devolucion.ToString();
            }
            else
            {
                return "Valor invalido";
            }
        }

        /// <summary>
        /// Retorna un string con un numero binario equivalente a la parte entera positiva del double recibido.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        static public string DecimalBinario(double numero)
        {
            string devolucion = "\n";
            numero = (int) Math.Abs(numero);

            while (numero > 1)
            {
                devolucion = devolucion.Insert(0, (numero % 2).ToString());

                numero = (numero - (numero % 2)) / 2;
            }

            devolucion = devolucion.Insert(0, (numero % 2).ToString());

            return devolucion;
        }

        /// <summary>
        /// Convierte un numero decimal recibido como string a binario si es possible, sino retorna valor invalido.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        static public string DecimalBinario(string numero)
        {
            double x;
            double.TryParse(numero, out x);
            if(x == 0.0 && numero != "0")
            {
                return "Valor invalido";
            }

            return DecimalBinario(x);
        }

        /// <summary>
        /// Operador de resta entre dos numeros.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }

        /// <summary>
        /// Operador de suma entre dos numeros.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return (n1.numero + n2.numero);
        }

        /// <summary>
        /// Operador de division entre dos num. En caso de que el divisor sea 0 retorna MinValue.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return (n1.numero / n2.numero);
            }
        }

        /// <summary>
        /// Operador de multiplicacion entre dos numeros.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return (n1.numero * n2.numero);
        }


    }
}
