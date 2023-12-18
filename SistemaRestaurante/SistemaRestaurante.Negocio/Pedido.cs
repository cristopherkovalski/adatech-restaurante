using System;

public class Pedido
{
        private string? numeroPedido;
        private Mesa? mesa;
        private List<ItemMenu>? itens;
        private double? valorTotal;
        private StatusPedido? status;


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

    public double? CalcularValorTotal()
    {
        double total = 0.0;

        if (itens != null)
        {
            foreach (ItemMenu item in itens)
            {
                total += item.Preco;
            }
        }

        this.valorTotal = total;
        return this.valorTotal;
    }

    public void ConfirmarPedido()
        {
            status = StatusPedido.CONFIRMADO;
        }

        public void CancelarPedido()
        {
            status = StatusPedido.CANCELADO;
        }
        public void MostrarItensPedido()
        {
        Console.WriteLine($"Itens do Pedido ({numeroPedido}):");

        if (itens != null && itens.Count > 0)
        {
            foreach (var item in itens)
            {
                Console.WriteLine($"- {item.Nome} | Preço: {item.Preco:C}");
            }
        }
        else
        {
            Console.WriteLine("Nenhum item no pedido.");
        }

        Console.WriteLine($"Valor Total: R$ {CalcularValorTotal():C}");
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


