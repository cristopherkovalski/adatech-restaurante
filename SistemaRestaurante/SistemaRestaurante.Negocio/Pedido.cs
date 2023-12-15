using System;

public class Pedido
{
        private string numeroPedido;
        private int numeroMesa;
        private List<ItemMenu> itens;
        private double valorTotal;
        private StatusPedido status;


        public Pedido()
        {

        }
        public Pedido(int numeroMesa)
        {
            this.numeroPedido = Guid.NewGuid().ToString();
            this.numeroMesa = numeroMesa;
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
        PENDENTE = 1,
        CONFIRMADO = 2,
        EM_ANDAMENTO = 3,
        COMPLETO = 4,
        CANCELADO = 5
    }
}
}
