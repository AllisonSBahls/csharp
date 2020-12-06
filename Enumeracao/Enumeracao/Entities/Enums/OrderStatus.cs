using System;
using System.Collections.Generic;
using System.Text;

namespace Enumeracao.Entities.Enums
{
    //Criando uma Enumeração para o Order Status
    enum OrderStatus : int //indicando que o enum é inteiro
    {
        //Colando os valores possiveis do meu tipo enumerado e definido o valor que represente ele
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
