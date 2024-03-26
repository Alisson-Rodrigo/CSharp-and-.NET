using System;
using EasyAutomationFramework;
using OpenQA.Selenium;

namespace MeuApp {
    class Program {
        static void Main(string[] args) {

            int valor = calcularDecimal(24.6);
            Console.WriteLine(valor);

        }

        static int calcularDecimal (double valor) {
            double aux = valor - (int)valor;
            if (aux >= 5) {
                aux += 1;
            }
            else {
                aux = valor - aux;
            }

            return (int)aux;
        }
    }
}