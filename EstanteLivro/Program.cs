using EstanteLivro;

Livro[] estante = new Livro[10];
int indice = 0, op = 0;

int Menu()
{
    Console.WriteLine("1 - Cadastrar Livro");
    Console.WriteLine("2 - Imprimir Estante");
    Console.WriteLine("3 - Imprimir Livro Especifico");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("Escolha sua opção: ");
    return int.Parse(Console.ReadLine());
}

Livro CadastrarLivro()
{
    string titulo, editora, isbn;
    int edicao, paginas;
    string[] autores = new string[3];
    DateOnly lancamento;

    Console.WriteLine("Informe o titulo do livro: ");
    titulo = Console.ReadLine();

    Console.WriteLine("Informe 1o autor do livro: ");
    autores[0] = Console.ReadLine();
    Console.WriteLine("Informe 2o autor do livro: ");
    autores[1] = Console.ReadLine();
    Console.WriteLine("Informe 3o autor do livro: ");
    autores[2] = Console.ReadLine();

    Console.WriteLine("Informe a data de lançamento: ");
    lancamento = DateOnly.Parse(Console.ReadLine());
    Console.WriteLine("Informe a editora: ");
    editora = Console.ReadLine();
    Console.WriteLine("Informe a edição: ");
    edicao = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o ISBN: ");
    isbn = Console.ReadLine();
    Console.WriteLine("Informe a quantidade de páginas: ");
    paginas = int.Parse(Console.ReadLine());

    return new(titulo, autores, lancamento, editora, edicao, isbn, paginas);
}
void AdicionarLivroNaEstante()
{
    do
    {
        Livro l = CadastrarLivro();
        estante[indice] = l;
        indice++;
        if (indice <= 10)

            Console.WriteLine("Deseja cadastrar um novo livro? (Digite 1 para sim, 0 para não)");
        op = int.Parse(Console.ReadLine());

        if (op != 1)
            break;

    } while (true);
}
void ImprimirEstante()
{
    for (int i = 0; i < indice; i++)
        estante[i].ImprimirLivro();
}

void BuscarLivro(int i)
{
    if (i >= 0 && i < indice)
    {
        estante[i].ImprimirLivro();
    }
    else
    {
        Console.WriteLine("Índice inválido. Livro não encontrado na estante.");
    }
}

do
{
    switch (Menu())
    {
        case 1:
            AdicionarLivroNaEstante();
            break;
        case 2:
            ImprimirEstante();
            break;
        case 3:
            Console.Write("Informe o indice do livro: ");
            BuscarLivro(int.Parse(Console.ReadLine()));
            break;
        case 4:
            Console.WriteLine("Hasta la vista, baby!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }
} while (true);
Console.ReadLine();