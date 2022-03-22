using System;
using System.Collections.Generic;
using System.Text;
using Ex_Proposto_132.Entidades.Enums;

namespace Ex_Proposto_132.Entidades.Enums
{
    class StatusPedido
    {
        enum StatusPedidos : int
        {
            PagamentoPendente = 0,
            Processando = 1,
            Enviado = 2,
            Entregue = 3
        }
    }
}
