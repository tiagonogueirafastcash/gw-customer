using System;

namespace GW.Customer.Domain
{
    public class Cliente : Entity
    {
        public Cliente()
        {
            DataCadastro = DateTime.Now;
            Ativo = true;

        }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
