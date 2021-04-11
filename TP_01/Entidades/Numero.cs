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

        public void SetNumero(string numero)
        {
            this.numero = ValidarNumero(numero);
        }

        private double ValidarNumero(string numero)
        {
            double parseo;

            double.TryParse(numero, out parseo);

            return parseo;
        }

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero(strNumero);
        }

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
                        break;
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

        public static double operator -(Numero n1, Numero n2)
        {
            return (n1.numero - n2.numero);
        }
        public static double operator +(Numero n1, Numero n2)
        {
            return (n1.numero + n2.numero);
        }
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
        public static double operator *(Numero n1, Numero n2)
        {
            return (n1.numero * n2.numero);
        }


    }
}
