using System;
using System.Collections.Generic;
using System.Text;
using Abstratas.Entities.Enums;

namespace Abstratas.Entities
{
    //Obrigando a subclasse a implementar os metodos abstrados
    //Ou vc pode definir a classe como abstrata porém ela não podera ser instanciada
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
