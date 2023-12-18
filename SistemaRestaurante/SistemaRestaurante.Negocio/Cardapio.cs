using System;

public class Cardapio
{
    public List<ItemMenu>? cardapio { get; set; }

    public Cardapio()
    {
        cardapio = new List<ItemMenu>();
    }
    public Cardapio(List<ItemMenu> cardapio)
    {
        this.cardapio = cardapio;
    }


    public void AdicionarItemMenu(ItemMenu item)
    {
        cardapio.Add(item);
    }

    public void RemoverItemMenu(ItemMenu item)
    {
        cardapio.Remove(item);
    }


}
