using static UtilsFunc.Utils;
// using static UtilsFunc.oie; -- import da Classe que possui o método com This, pra extensão.
namespace Exercises
{   
    public class Exercise01
    {
        void withoutVetor()
        {
            //Usando extensão
            // var number_3 = "x".strInput2();
            int number_1, number_2, lowestnum, highestnum;
            number_1 = intInput("Informe o primeiro número: ");
            number_2 = intInput("Informe o segundo número: ");
            lowestHighestValue(number_1, number_2);
            secondary_options(lowestnum, highestnum);
        }

        void crescent(int low, int high)
        {
            if (low <= high)
            {
                Console.WriteLine(low);
                crescent(low + 1, high);
            }
        }

        void decrescent(int low, int high)
        {
            if (low <= high)
            {
                decrescent(low + 1, high);
                Console.WriteLine(low);
            }
        }

        void crescentOdds(int low, int high)
        {
            if (low <= high)
            {
                if (low % 2 != 0)
                {
                    Console.WriteLine(low);
                }
                crescentOdds(low + 1, high);
            }
        }

        int sumvalues(int low, int high)
        {
            if (low < high)
            {
                return low + sumvalues(low + 1, high);
            }
            else
            {
                return low;
            }
        }

        void secondary_options(int lowest, int highest)
        {
            int ans, i;
            int[] possibleAnswers = new int[6];
            for (i = 0; i < 6; i++)
                possibleAnswers[i] = i + 1;
            int op = 0;
            while (op == 0)
            {
                Console.WriteLine("MENU SECUNDÁRIO\n[1] - Inteiros em ordem crescente.\n[2] - Inteiros em ordem decrescente.\n[3] - Inteiros ímpares (crescente).\n[4] - Somatória dos inteiros.\n[5] - Nova seleção de números. \n[6] - Voltar ao menu inicial.");
                ans = intInput("Informe uma das opções acima: ");
                if (possibleAnswers.Contains(ans))
                {
                    switch (ans)
                    {
                        case 1:
                            crescent(lowest, highest);
                            break;
                        case 2:
                            decrescent(lowest, highest);
                            break;
                        case 3:
                            crescentOdds(lowest, highest);
                            break;
                        case 4:
                            Console.WriteLine(sumvalues(lowest, highest));
                            break;
                        case 5:
                            Console.WriteLine("NOVA SELEÇÃO DE NÚMEROS.");
                            withoutVetor();
                            break;
                        case 6:
                            Console.WriteLine("Voltando para o menu principal.");
                            op = 1;
                            break;
                    }

                }
            }

        }

        void withVetor()
        {
            int ans, num;
            ans = intInput("Informe a quantidade de números que irá informar: ");
            int[] numberList = new int[ans];
            for (int i = 0; i < ans; i++)
            {
                num = intInput("Informe um número: ");
                numberList[i] = num;
            }
            Console.WriteLine(sumValuesInVetor(numberList, ans));
        }

        int sumValuesInVetor(int[] numberList, int lastIndex)
        {
            if (lastIndex == 0) 
            {
                return 0;
            }
            else
            {
                return numberList[lastIndex-1] + sumValuesInVetor(numberList, (lastIndex - 1));
            }
        }
        

        public void menu()
        {
            string op = "0";
            while (op == "0")
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("[1] - Funções recursivas sem vetor");
                Console.WriteLine("[2] - Funções recursivas com vetor");
                Console.WriteLine("[3] - Sair");
                op = strInput("Informe uma das opções acima: ");
            }

            if (op == "1")
            {
                withoutVetor();
                menu();
            }
            else if (op == "2")
            {
                withVetor();
                menu();
            }
            else if (op == "3")
            {
                Console.WriteLine("Programa Finalizado!");
            }
        }
    }
}