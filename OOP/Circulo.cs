using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar Círculo");
        }
        public void ColorirCiruculo()
        {
            Console.WriteLine("Colorir Círculo");
        }

    }
}
