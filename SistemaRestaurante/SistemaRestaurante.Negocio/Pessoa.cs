namespace SistemaRestaurante.Negocio
{
    public class abstract Pessoa
    {
       
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

     
        public Pessoa(string nome, string cpf, string email)
        {
            Nome = nome;
            CPF = cpf;
            Email = email;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"E-mail: {Email}");
        }
    }
}