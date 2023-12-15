using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Negocio
{
    internal class Cliente : Pessoa
    {
        public string NumeroCliente { get; set; }

        public Cliente(string nome, string cpf, string email, string numeroCliente)
            : base(nome, cpf, email)
        {
            NumeroCliente = numeroCliente;
        }

        public void ExibirInformacoes()
        {
            
            base.ExibirInformacoes();
            Console.WriteLine($"Número do Cliente: {NumeroCliente}");
        }
    }



}
