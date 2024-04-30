using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteLivro
{
    internal class Livro
    {
        string Titulo;
        string[] Autores;
        DateOnly Lancamento;
        string Editora;
        int Edicao;
        string ISBN;
        int Paginas;

        public Livro(string titulo, string[] autores, DateOnly lancamento, string editora, int edicao, string iSBN, int paginas)
        {
            Titulo = titulo;
            Autores = autores;
            Lancamento = lancamento;
            Editora = editora;
            Edicao = edicao;
            ISBN = iSBN;
            Paginas = paginas;
        }

        public void ImprimirLivro()
        {
            Console.WriteLine("\n\n>>> INFORMAÇÕES DO LIVRO <<<");
            Console.WriteLine("Titulo: "+this.Titulo);
            Console.WriteLine("Autores: ");
            for (int i = 0; i < this.Autores.Length; i++)
            {
                Console.Write(this.Autores[i]);
                if (i < this.Autores.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("\nData de Lançamento: "+this.Lancamento);
            Console.WriteLine("Editora: "+this.Editora);
            Console.WriteLine("Ediçao: "+this.Edicao);
            Console.WriteLine("ISBN: "+this.ISBN);
            Console.WriteLine("Quantidade de Páginas: "+this.Paginas);
        }
    }
}
