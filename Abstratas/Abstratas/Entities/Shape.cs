using System;
using System.Collections.Generic;
using System.Text;
using Abstratas.Entities.Enums;
namespace Abstratas.Entities
{
    //Quando se tem um metodo abstrado é obrigatório a classe ser abstrada
    abstract class Shape
    {
        public Color Color { get; set; }


        public Shape(Color color)
        {
            Color = color;
        }


        //Ao invez de abrir o corpo da implementação é colocado abstract
        public abstract double Area();
    }
}
