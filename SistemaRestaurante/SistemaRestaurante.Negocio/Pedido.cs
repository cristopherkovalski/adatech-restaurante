using System;

public class Pedido
{
        private string numeroPedido;
        private Mesa mesa;
        private List<ItemMenu> itens;
        private double valorTotal;
        private StatusPedido status;


        public Pedido()
        {

        }
        public Pedido(Mesa mesa)
        {
            this.numeroPedido = Guid.NewGuid().ToString();
            this.mesa = mesa;
            this.itens = new List<ItemMenu>();
            this.status = StatusPedido.PENDENTE;
        }

        public void AdicionarItem(ItemMenu item)
        {
            itens.Add(item);
        }

        public void RemoverItem(ItemMenu item)
        {
            itens.Remove(item);
        }

        public double CalcularValorTotal()
        {
     
            return 0.0;
        }

        public void ConfirmarPedido()
        {
            status = StatusPedido.CONFIRMADO;
        }

        public void CancelarPedido()
        {
            status = StatusPedido.CANCELADO;
        }
    }

    public enum StatusPedido
    {
        PENDENTE,
        CONFIRMADO,
        EM_ANDAMENTO,
        COMPLETO,
        CANCELADO
    }
}
}
