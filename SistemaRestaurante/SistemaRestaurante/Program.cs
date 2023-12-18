namespace SistemaRestaurante
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Cardapio cardapio = new Cardapio();
            ItemMenu item1 = new ItemMenu(1, "Mini pizza de Calabresa", "Deliciosa mini pizza", 15.0, "Entrada");
            ItemMenu item2 = new ItemMenu(2, "Hamburguer Duplo", "Hamburguer duplo suculento", 30.0, "Principal");
            ItemMenu item3 = new ItemMenu(3, "Mini pizza quatro queijos", "Deliciosa mini pizza", 15.0, "Entrada");
            ItemMenu item4 = new ItemMenu(4, "Picanha", "Picanha assada na brasa", 120.0, "Principal");

            cardapio.AdicionarItemMenu(item1);
            cardapio.AdicionarItemMenu(item2);
            cardapio.AdicionarItemMenu(item3);
            cardapio.AdicionarItemMenu(item4);

            Console.WriteLine("\nDigite o número da mesa");
            int nmesa = int.Parse(Console.ReadLine());

            Mesa mesa = new Mesa { Numero = nmesa, IsOcupada = true};
            Pedido pedido = new Pedido(mesa);
            Console.WriteLine("Insira o id do produto para adicionar ao pedido");
            while (true)
            {
                Console.Clear(); 

                Console.WriteLine("Cardápio:");
                foreach (var itemMenu in cardapio.cardapio)
                {
                    Console.WriteLine($"Id: {itemMenu.Id} - {itemMenu.Nome} - R$ {itemMenu.Preco}");
                }

                Console.WriteLine("\nEscolha um item para adicionar ao pedido através do id (ou digite 'sair' para encerrar):");
                string escolha = Console.ReadLine();

                if (escolha.ToLower() == "sair")
                {
                    break; 
                }
                var numero = int.Parse(escolha);
                ItemMenu itemEscolhido = cardapio.cardapio.Find(item => item.Id == numero);

                if (itemEscolhido != null)
                {
                    pedido.AdicionarItem(itemEscolhido);
                    Console.WriteLine($"Item '{itemEscolhido.Nome}' adicionado ao pedido!");
                }
                else
                {
                    Console.WriteLine("Item não encontrado no cardápio. Tente novamente.");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("Resumo do Pedido:");
            pedido.MostrarItensPedido();

            Console.ReadLine();  
        }

    }
}
