type_node root = null;
void inserir(ref type_node root, int numero)
{
    if (root == null)
    {
        root = new type_node();
        root.valor = numero;
    }
    else if (numero < root.valor)
        inserir(ref root.l, numero);
    else
        inserir(ref root.r, numero);
}

type_node maiorValor(ref type_node root)
{
    if (root.r == null)
    {
        type_node p = root;
        root = root.l;
        return p;
    }        
    else
        return maiorValor(ref root.r);
}

type_node remover(ref type_node root, int numero)
{
    if (root == null)
        return null;
    else if (root.valor == numero)
    {
        type_node p = root;
        if (root.l == null)
            root = root.r;
        else if (root.r == null)
            root = root.l;
        else
        {
            p = maiorValor(ref root.l);
            root.valor = p.valor;
        }
        return p;
    }
    else if (root.valor < numero)
        return remover(ref root.r, numero);
    else
        return remover(ref root.l, numero);
}


type_node pesquisar(ref type_node root, int numero)
{
    if (root == null)
        return null;
    else if (root.valor > numero)
        return pesquisar(ref root.l, numero);
    else if (root.valor < numero)
        return pesquisar(ref root.r, numero);
    else
        return root;
}

void exibir_crescente(type_node root)
{
    if (root != null)
    {
        exibir_crescente(root.l);
        Console.WriteLine(root.valor);
        exibir_crescente(root.r);
    }
}

int pegarNumero()
{
    Console.Write("Informe um número: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    return numero;
}


void main()
{
    string[] opcoes = {"[1] - Inserir", "[2] - Pesquisar", "[3] - Remover", "[4] - Exibir", "[5] - Sair"};
    foreach (string opcao in opcoes)
    {
        Console.WriteLine(opcao);
    }
    Console.Write("Informe uma das opções acima: ");
    string escolha = Console.ReadLine();
    switch (escolha)
    {
        case "1":
            inserir(ref root, pegarNumero());
            main();
            break;
        case "2":
            if (pesquisar(ref root, pegarNumero()) == null)
                Console.WriteLine("Não encontrado");
            else
                Console.WriteLine("Encontrado");
            main();
            break;
        case "3":
            Console.WriteLine($"{remover(ref root, pegarNumero()).valor} foi removido.");
            main();
            break;
        case "4":
            exibir_crescente(root);
            main();
            break;
        case "5":
            break;
        default:
            Console.WriteLine("Informe uma das opções válidas");
            main();
            break;
    }
}


main();

class type_node
{
    public type_node r;
    public type_node l;
    public int valor;
}