// type_node list_last_element = null;

// void inserir(ref type_node list_last_element)
// {
//     type_node node = new type_node();
//     Console.Write("Informe o nome: ");
//     node.nome = Console.ReadLine().ToUpper();
//     Console.Write("Informe sua idade: ");
//     node.idade = Console.ReadLine();
//     Console.Write("Informe o whats com DDD: ");
//     node.whats = Console.ReadLine();
//     if (list_last_element != null)
//         node.prox = list_last_element;
//     list_last_element = node;
// }

// void alterar(ref type_node list_last_element)
// {
//     Console.Write("Informe o nome que deseja buscar: ");
//     string nome = Console.ReadLine().ToUpper();
//     bool encontrado = false;
//     type_node pointer = list_last_element;
//     while (pointer != null)
//     {
//         if (pointer.nome == nome)
//         {
//             Console.Write($"Nome: {pointer.nome}\nIdade: {pointer.idade}\nWhats: {pointer.whats}\n");
//             encontrado = true;
//             Console.Write("Deseja alterar? (S/N)\n");
//             string continuar = Console.ReadLine().ToUpper();
//             if (continuar == "S")
//             {
//                 Console.Write("Informe o nome: ");
//                 pointer.nome = Console.ReadLine().ToUpper();
//                 Console.Write("Informe sua idade: ");
//                 pointer.idade = Console.ReadLine();
//                 Console.Write("Informe o whats com DDD: ");
//                 pointer.whats = Console.ReadLine();
//             }
//             break;
//         }
//         pointer = pointer.prox;
//     }
//     if (!encontrado)
//         Console.WriteLine("Não encontrado.");
// }

// void excluir(ref type_node list_last_element)
// {
//     type_node anterior = null, atual = list_last_element;
//     Console.Write("Informe o nome que deseja excluir: ");
//     string nome = Console.ReadLine().ToUpper();
//     bool encontrado = false;
//     while (atual != null)
//     {
//         if (atual.nome == nome)
//         {
//             encontrado = true;
//             Console.Write($"Nome: {atual.nome}\nIdade: {atual.idade}\nWhats: {atual.whats}\nDeseja remover? (S/N)\n");
//             string confirmar = Console.ReadLine().ToUpper();
//             if (confirmar != "S")
//                 break;
//             if (anterior == null)
//             {
//                 list_last_element = atual.prox;
//                 break;
//             }
//             else if (atual.prox == null)
//             {
//                 anterior.prox = null;
//                 break;
//             }
//             else
//             {
//                 anterior.prox = atual.prox;
//                 atual.prox = null;
//                 break;
//             }
//         }
//         anterior = atual;
//         atual = atual.prox;
//     }
//     if (!encontrado)
//         Console.WriteLine("Não encontrado.");
// }

// void exibir(ref type_node list_last_element)
// {
//     type_node atual = list_last_element;
//     if (atual == null)
//         Console.WriteLine("Não há elementos.");
//     while (atual != null)
//     {
//         Console.WriteLine($"Nome: {atual.nome}\nIdade: {atual.idade}\nWhats: {atual.whats}\n");
//         atual = atual.prox;
//     }
// }

// void main()
// {
//     string[] opcoes = {"[1] - Inserir", "[2] - Alterar", "[3] - Excluir", "[4] - Exibir", "[5] - Sair"};
//     foreach (string opcao in opcoes)
//     {
//         Console.WriteLine(opcao);
//     }
//     Console.Write("Informe uma das opções acima: ");
//     string escolha = Console.ReadLine();
//     switch (escolha)
//     {
//         case "1":
//             inserir(ref list_last_element);
//             main();
//             break;
//         case "2":
//             alterar(ref list_last_element);
//             main();
//             break;
//         case "3":
//             excluir(ref list_last_element);
//             main();
//             break;
//         case "4":
//             exibir(ref list_last_element);
//             main();
//             break;
//         case "5":
//             break;
//         default:
//             Console.WriteLine("Informe uma das opções válidas");
//             main();
//             break;
//     }
// }

// main();
// class type_node
// {
//     public string nome = "";
//     public string idade = "";

//     public string whats = "";
//     public type_node prox = null;
// }

