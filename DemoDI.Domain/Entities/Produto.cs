using System;

namespace DemoDI.Domain.Entities
{
    public class Produto
    {
        public Produto(string nome, decimal preco)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Preco = preco;
        }
        public Guid Id { get; set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
    }
}
