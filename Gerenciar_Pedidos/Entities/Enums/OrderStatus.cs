using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciar_Pedidos.Entities.Enums
{
    enum OrderStatus : int
    {
        Pagamento_Pendente = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}
