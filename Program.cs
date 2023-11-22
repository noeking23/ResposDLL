using System;

namespace MatematicasLib {
    public static class Calculadora {
        public static double Sumar(double a, double b) {
            return a + b;
        }

        public static double Restar(double a, double b) {
            return a - b;
        }

        public static double Multiplicar(double a, double b) {
            return a * b;
        }

        public static double Dividir(double a, double b) {
            if (b == 0) {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            return a / b;
        }

        public static double ElevarAlCuadrado(double a) {
            return a * a;
        }

        public static double RaizCuadrada(double a) {
            if (a < 0) {
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");
            }
            return Math.Sqrt(a);
        }

        public static double Potencia(double baseNum, double exponente) {
            return Math.Pow(baseNum, exponente);
        }

        public static double Modulo(double a, double b) {
            return a % b;
        }
    }
}
