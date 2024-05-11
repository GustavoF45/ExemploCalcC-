using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploCalc.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Sub(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multi(int x, int y){
            Console.WriteLine($"{x} X {y} = {x * y}");
        }

        public void Div(double x, double y){
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Pot(int x, int y){
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {potencia}");
        }
        public void RaizQuadrada(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz de {x} é {raiz}");
    }
    }
}