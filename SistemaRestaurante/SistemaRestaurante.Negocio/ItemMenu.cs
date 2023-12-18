using System;

public class ItemMenu
{
    private int id;
    private string nome;
    private string descricao;
    private double preco;
    private string categoria;

    public ItemMenu(int id, string nome, string descricao, double preco, string categoria)
    {
        this.id = id;
        this.nome = nome;
        this.descricao = descricao;
        this.preco = preco;
        this.categoria = categoria;
    }

    public int Id { get { return id; } }
    public string Nome
    {
        get { return nome; }
        private set { nome = value; }
    }

    public string Descricao
    {
        get { return descricao; }
        private set { descricao = value; }
    }

    public double Preco
    {
        get { return preco; }
        private set { preco = value; }
    }

    public string Categoria
    {
        get { return categoria; }
        private set { categoria = value; }
    }
}




