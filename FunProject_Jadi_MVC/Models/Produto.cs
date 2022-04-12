using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FunProject_Jadi_MVC.Models
{
    public class Produto
    {
        [DisplayName("Id")]
        public int ProdutoId { get; set; }

        [DisplayName("Nome do Produto")]
        public string Nome { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Preço")]
        public double Preco { get; set; }

        public bool Existe { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }

        public Produto()
        {

            this.Existe = true;
            this.Status = "Em uso";

        }
    }

   
}
