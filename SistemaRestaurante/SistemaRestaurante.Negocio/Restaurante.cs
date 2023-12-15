using System;

public class Restaurante
{
    private string nome;
    private string endereco;
    private List<ItemMenu> menu;
    private List<Pedido> pedidos;

    public Restaurante(string nome, string endereco)
    {
        this.nome = nome;
        this.endereco = endereco;
        this.menu = new List<ItemMenu>();
        this.pedidos = new List<Pedido>();
    }

    public void AdicionarItemMenu(ItemMenu item)
    {
        menu.Add(item);
    }

    public void RemoverItemMenu(ItemMenu item)
    {
        menu.Remove(item);
    }

    public Pedido CriarPedido(int numeroMesa)
    {
        Pedido pedido = new Pedido(numeroMesa);
        pedidos.Add(pedido);
        return pedido;
    }

    public void ProcessarPedido(Pedido pedido)
    {
        // Falta implementar a lógica para processar o pedido
    }
}
