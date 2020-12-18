using System;
using System.Collections.Generic;

namespace AulaPOO_Interface.classes
{
    // Agora é só colocar as ações corretas dentro do método e tudo estará pronto :)

    // Se der CTRL + . no erro, ele habilita a opção de implementar a interface para você
    // Não esqueça de apagar as linhas que tenham esse: throw new System.NotImplementedException();
    public class Carrinho : ICarrinho
    {
        public float ValorTotal { get; set; }
        List<Produto> carrinho = new List<Produto>();
        public void Alterar(int _codigo, Produto produto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = produto.Preco;
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Listar()
        {
            foreach (Produto p in carrinho){
                Console.WriteLine($"R$ {p.Preco,2} - {p.Nome}");
            }
        }
    }
}