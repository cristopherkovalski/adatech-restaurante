public class Funcionario : Pessoa
{
	// Atributo adicional para a classe Funcionario
	public string NumeroFuncionario { get; set; }

	// Construtor para a classe Funcionario
	public Funcionario(string nome, string cpf, string email, string numeroFuncionario)
		: base(nome, cpf, email)
	{
		NumeroFuncionario = numeroFuncionario;
	}

	public override void ExibirInformacoes()
	{
		// Chamando o m�todo da classe base para exibir as informa��es da pessoa
		base.ExibirInformacoes();
		Console.WriteLine($"N�mero do Funcion�rio: {NumeroFuncionario}");
	}
}