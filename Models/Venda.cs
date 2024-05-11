using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_Net_2.Models
{
    public class Venda
    {
        public Venda (int id, string produto, decimal preco, DateTime datadevenda)
        {
            Id = id;
            ProductName =  produto;
            Preco = preco;
            dataDeVenda = datadevenda;
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Preco { get; set; }

        public DateTime dataDeVenda { get; set; }

    }
}