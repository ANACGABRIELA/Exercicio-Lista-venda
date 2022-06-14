using System;
using System.Collections.Generic;

namespace Exercicio_Lista_venda
{
    using System.Text;
    using System.Threading.Tasks;
    public class Cliente
    {
       
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public Cliente(string nome, string cpf, string endereco)
        {
           
            this.Nome = nome;
            this.CPF = cpf;
            this.Endereco = endereco;
        }
    }
    public class Vendedor
    {
       
        public string Nome { get; set; }
        public string CodigoCracha { get; set; }
        public Vendedor( string nome, string codigoCracha)
        {
            this.Nome = nome;
            this.CodigoCracha = codigoCracha;
        }
    }
    public class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }
        public Produto(int codigo,string descricao, string marca, double preco)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Marca = marca;
            this.Preco = preco;
        }
    }
    public class CarrinhoCompras
    {
        
        public List<Produto> Produtos { get; set; } = new List<Produto>();
        public CarrinhoCompras() { } 
    }
    public class Venda
    {
        public bool Finalizada { get; set; }
        public Vendedor vendedor { get; set; }
        public Cliente clinete { get; set; }
        public double ValorTotal { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public Venda(bool Finalizada, Vendedor vendedor, Cliente cliente, double valorTotal)
        {
            this.Finalizada = Finalizada;
            this.ValorTotal = valorTotal;  
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
            List<Produto> Produtos = new List<Produto>();
            Produtos.Add(new Produto(1, "camisa", "AVV", 200));
            Produtos.Add(new Produto(2, "calca", "AVV", 300));
            Produtos.Add(new Produto(3, "camiseta", "AVV", 100));
            Produtos.Add(new Produto(4, "short", "IT", 200));
            Produtos.Add(new Produto(1, "meia", "AVV", 50));


         

        }
       

    }
}
