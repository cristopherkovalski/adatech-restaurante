using System;

public class Funcionario : Pessoa
{

	public string NumeroFuncionario { get; set; }


	public Funcionario(string nome, string cpf, string email, string numeroFuncionario)
		: base(nome, cpf, email)
	{
		NumeroFuncionario = numeroFuncionario;
	}

	public override void ExibirInformacoes()
	{
		
		base.ExibirInformacoes();
		Console.WriteLine($"Número do Funcionário: {NumeroFuncionario}");
	}
}