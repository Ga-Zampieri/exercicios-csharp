namespace Exercises;

public class Exercicio28
{
    const int MAX = 5; 
    pessoa[] listaHashSemTratamento = new pessoa[MAX];
    pessoa[] listaHashLinear = new pessoa[MAX];
    pessoa[] listaHashEncadeada = new pessoa[MAX];

    int Hash(int n)
    {
        return (n % MAX);
    }

    int IntInput(string msg)
    {
        Console.Write(msg);
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    string StrInput(string msg)
    {
        Console.Write(msg);
        string nome = Console.ReadLine();
        return nome;
    }

    void pessoaInput(ref string nome, ref int idade, ref string whats)
    {
        nome = StrInput("Informe o nome: ");
        idade = IntInput("Informe a idade: ");
        whats = StrInput("Informe o número de Whats com DDD: ");
    }

    void alterarPessoaInput(ref string nome, ref string whats)
    {
        nome = StrInput("Informe o nome: ");
        whats = StrInput("Informe o número de Whats com DDD: ");
    }

    string getAns()
    {
        string[] op1 = new string[] {"[1] - Inserir", "[2] - Alterar", "[3] - Relatar", "[4] - Finalizar", "[5] - Trocar tratamento"};
        foreach (string opcao in op1)
        {
            Console.WriteLine(opcao);
        }
        string ans = StrInput("Informe uma das opções acima: ");
        return ans;
    }

    // Sem Tratamento de Colisão 

    void inserirSemTratamento(pessoa[] listaHashSemTratamento)
    {
        pessoa p = new pessoa();
        pessoaInput(ref p.nome, ref p.idade, ref p.whats);
        listaHashSemTratamento[Hash(p.idade)] = p;
    }

    int buscarValorSemTratamento(int valor)
    {
        int pos = Hash(valor);
        if (pos == -1)
            return -1; 
        return pos;//retorna a posição
    }

    void alterarValorSemTratamento()
    {
        int idade = IntInput("Informe a idade do cadastro que deseja mudar: ");
        int posicao = buscarValorSemTratamento(idade);
        if (posicao == -1) // retornou uma posição que não tem nada
            Console.WriteLine("Não há registro");
        else
        {
            pessoa p = listaHashSemTratamento[posicao];
            if (p == null)
                Console.WriteLine("Não há nada registrado nessa posição.");
            else
            {
                Console.WriteLine($"Nome: {p.nome}\nWhats: {p.whats}.");
                alterarPessoaInput(ref p.nome, ref p.whats);
                listaHashSemTratamento[posicao] = p;
                Console.WriteLine("Cadastro alterado com sucesso!");
                Console.WriteLine($"Nome: {p.nome}\nWhats: {p.whats}.");
            }
        }
    }

    void relatarValoresSemTratamento(pessoa[] l)
    {
        for (int i = 0; i < MAX; i++)
        {
            if (l[i] != null)
            {
                Console.Write($"Nome: {l[i].nome}\nIdade: {l[i].idade}\nWhats: {l[i].whats}\n\n");
            }
        }
    }

    //Tratamento Linear

    void inserirComTratamentoLinear(pessoa[] listaHashLinear)
    {
        pessoa p = new pessoa(); 
        pessoaInput(ref p.nome, ref p.idade, ref p.whats);
        int pos = Hash(p.idade);
        for (int i = 0; i < MAX; i++)
        {
            if (listaHashLinear[pos] == null)
            {
                listaHashLinear[pos] = p;
                break;
            }    
            else
            {
                pos++;
                pos = pos % MAX;
            }
        }
    }

    int buscarValorComTratamentoLinear(pessoa[] listaHashLinear, int valor)
    {
        int pos = valor % MAX;
        for (int i = 0; i < MAX; i++)
        {
            if (listaHashLinear[pos].idade == valor)
            {
                return pos;
            }
            else
            {
                pos++;
                pos %= MAX;
            }
        }
        return -1;
    }

    void alterarComTratamentoLinear(pessoa[] listaHashLinear)
    {
        int idade = IntInput("Informe a idade do cadastro que deseja mudar: ");
        int posicao = buscarValorComTratamentoLinear(listaHashLinear, idade);
        if (posicao == -1)
            Console.WriteLine("Não há registro desta idade");
        else
        {
            pessoa p = listaHashLinear[posicao];
            Console.WriteLine($"Nome: {p.nome}\nWhats: {p.whats}.");
            alterarPessoaInput(ref p.nome, ref p.whats);
            listaHashLinear[posicao] = p;
            Console.WriteLine("Cadastro alterado com sucesso!");
            Console.WriteLine($"Nome: {p.nome}\nWhats: {p.whats}.");
        }
    }

    void relatarValoresComTratamentoLinear(pessoa[] l)
    {
        for (int i = 0; i < MAX; i++)
        {
            if (l[i] != null)
            {
                Console.Write($"Nome: {l[i].nome}\nIdade: {l[i].idade}\nWhats: {l[i].whats}\n\n");
            }
        }
    }

    //Tratamento com lista encadeada

    void inserirComListaEncadeada(pessoa[] listaHashEncadeada)
    {
        pessoa p = new pessoa();
        pessoaInput(ref p.nome, ref p.idade, ref p.whats);
        int pos = Hash(p.idade);
        if (listaHashEncadeada[pos] == null)
        {
            listaHashEncadeada[pos] = p;
        }
        else
        {
            p.prox = listaHashEncadeada[pos];
            listaHashEncadeada[pos] = p;
        }
    }

    void alterarComListaEncadeada(pessoa[] listaHashEncadeada)
    {
        int idade = IntInput("Informe a idade do cadastro que deseja mudar: ");
        int posicao = Hash(idade);
        pessoa p = listaHashEncadeada[posicao];
        if (p == null)
            Console.WriteLine("Não há registro desta idade");
        while (p != null)
        {
            if (p.idade == idade)
            {
                Console.WriteLine($"Nome: {p.nome}\nWhats: {p.whats}.");
                alterarPessoaInput(ref p.nome, ref p.whats);
                Console.WriteLine("Cadastro alterado com sucesso!");
                Console.WriteLine($"Nome: {p.nome}\nWhats: {p.whats}.");
                break;
            }
            else
                p = p.prox;
        }
    }

    void relatarValoresComListaEncadeada(pessoa[] l)
    {
        for (int i = 0; i < MAX; i++)
        {
            pessoa p = l[i];
            while (p != null)
            {
                Console.Write($"Nome: {p.nome}\nIdade: {p.idade}\nWhats: {p.whats}\n\n");
                p = p.prox;
            }
        }
    }

    public void main()
    {
        string[] opTratamento = new string[] {"[1] - Sem tratamento", "[2] - Tratamento Linear", "[3] - Tratamento Lista Encadeada", "[4] - Finalizar"};
        foreach (string opcao in opTratamento)
        {
            Console.WriteLine(opcao);
        }
        string ansTratamento = StrInput("Informe uma das opções acima: ");
        string[] respostas = new string[] {"1", "2", "3", "4"};
        if (respostas.Contains(ansTratamento))
            menu_dois(ansTratamento);
        else
        {
            Console.WriteLine("Informe apenas uma das opções citadas.");
            main();
        }        
    } 

    void menu_dois(string ansT)
    {
        switch (ansT)
        {
            case "1":
                string ans1 = getAns();
                switch (ans1)
                {
                    case "1":
                        inserirSemTratamento(listaHashSemTratamento);
                        menu_dois("1");
                    break;
                    case "2":
                        alterarValorSemTratamento();
                        menu_dois("1");
                    break;
                    case "3":
                        relatarValoresSemTratamento(listaHashSemTratamento);
                        menu_dois("1");
                    break;
                    case "4":
                        Console.WriteLine("Sistema Finalizado.");
                    break;
                    case "5":
                        Console.WriteLine();
                        main();
                    break;
                    default:
                        Console.WriteLine("Informe apenas uma das opções citadas.");
                        menu_dois("1");
                    break;
                }
            break;
            case "2":
                string ans2 = getAns();
                switch (ans2)
                {
                    case "1":
                        inserirComTratamentoLinear(listaHashLinear);
                        menu_dois("2");
                    break;
                    case "2":
                        alterarComTratamentoLinear(listaHashLinear);
                        menu_dois("2");
                    break;
                    case "3":
                        relatarValoresComTratamentoLinear(listaHashLinear);
                        menu_dois("2");
                    break;
                    case "4":
                        Console.WriteLine("Sistema Finalizado.");
                    break;
                    case "5":
                        Console.WriteLine();
                        main();
                    break;
                    default:
                        Console.WriteLine("Informe apenas uma das opções citadas.");
                        menu_dois("2");
                    break;
                }
            break;
            case "3":
                string ans3 = getAns();
                switch (ans3)
                {
                    case "1":
                        inserirComListaEncadeada(listaHashEncadeada);
                        menu_dois("3");
                    break;
                    case "2":
                        alterarComListaEncadeada(listaHashEncadeada);
                        menu_dois("3");
                    break;
                    case "3":
                        relatarValoresComListaEncadeada(listaHashEncadeada);
                        menu_dois("3");
                    break;
                    case "4":
                        Console.WriteLine("Sistema Finalizado.");
                    break;
                    case "5":
                        Console.WriteLine();
                        main();
                    break;
                    default:
                        Console.WriteLine("Informe apenas uma das opções citadas.");
                        menu_dois("2");
                    break;
                }
            break;
            case "4":
                Console.WriteLine("Sistema Finalizado.");
            break;
            default:
                Console.WriteLine("Informe apenas uma das opções citadas.");
                main();
            break;
        }
    }

    class pessoa
    {
        public string nome;
        public string whats;
        public int idade;
        public pessoa prox;
    }
}

