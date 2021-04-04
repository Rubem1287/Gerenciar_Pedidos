using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciar_Pedidos.Entities.Enums
{
    enum OrderStatus : int
    {
        Processando = 1,
        Pagamento_Pendente = 2,
        Enviado = 3,
        Entregue = 4
    }
}
