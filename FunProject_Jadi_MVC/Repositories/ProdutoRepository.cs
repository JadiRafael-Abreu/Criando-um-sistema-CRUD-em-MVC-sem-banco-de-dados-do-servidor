using FunProject_Jadi_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FunProject_Jadi_MVC.Repositories
{
    public class ProdutoRepository
    {
        private readonly List<Produto> _produtoDB = new List<Produto>();

        public List<Produto> Lista()
        {
            return _produtoDB;
        }

        public void Criar(Produto produto)
        {
            produto.ProdutoId = _produtoDB.Count;
            _produtoDB.Add(produto);

        }

        public Produto BuscarProduto(int id)
        {
            var produto = _produtoDB.FirstOrDefault(p => p.ProdutoId == id);

            return produto;

        }

        public Produto AtualizarProduto(Produto produto)
        {
            var buscaProduto = BuscarProduto(produto.ProdutoId);

            if (buscaProduto == null) throw new Exception("Houve um erro na busca do produto");


            buscaProduto.Nome = produto.Nome;
            buscaProduto.Descricao = produto.Descricao;
            buscaProduto.Preco = produto.Preco;

            return produto;
        }

        public Produto Excluir(Produto produto)
        {
            var excluirProduto = BuscarProduto(produto.ProdutoId);

            if (excluirProduto == null) throw new Exception("Houve um erro na busca do produto");

            excluirProduto.Existe = false;

            NovoStatus(excluirProduto);


            return produto;
        }

        protected void NovoStatus(Produto produto)
        {
            if (produto.Existe == false)
            {
                produto.Status = "Desativado";
            }
        }







    }
}
