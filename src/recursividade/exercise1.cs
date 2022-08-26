using UtilsFunc;

namespace Exercises {
    internal static class Exercise01 {
        internal static void withoutVetor() {
            int number_1, number_2, lowestnum, highestnum;
            number_1 = Utils.intInput("Informe o primeiro número: ");
            number_2 = Utils.intInput("Informe o segundo número: ");
            lowestnum = number_1;
            if (number_2 < lowestnum) {
                lowestnum = number_2;
                highestnum = number_1;
            } 
            else {
                highestnum = number_2;
            }
            secondary_options(lowestnum, highestnum);
        }

        internal static void crescent(int low, int high) {
            if (low <= high) {
                Console.WriteLine(low);
                crescent(low+1, high);
            }
        }

        internal static void decrescent(int low, int high) {
            if (low <= high) {
                decrescent(low+1, high);
                Console.WriteLine(low);
            }
        }

        internal static void crescentOdds(int low, int high) {
            if (low <= high) {
                if (low % 2 != 0) {
                    Console.WriteLine(low);
                }
                crescentOdds(low+1, high);
            }
        }

        internal static int sumvalues(int low, int high) {
            if (low < high) {
                return low + sumvalues(low+1, high);
            }
            else{
                return low;
            }
        }

        internal static void secondary_options(int lowest, int highest) {
            int ans, i;
            int[] possibleAnswers = new int[6];
            for (i = 0; i < 6; i++)
                possibleAnswers[i] = i+1;
            int op = 0;
            while (op == 0){
                Console.WriteLine("MENU SECUNDÁRIO\n[1] - Inteiros em ordem crescente.\n[2] - Inteiros em ordem decrescente.\n[3] - Inteiros ímpares (crescente).\n[4] - Somatória dos inteiros.\n[5] - Nova seleção de números. \n[6] - Voltar ao menu inicial.");
                ans = Utils.intInput("Informe uma das opções acima: ");
                if (possibleAnswers.Contains(ans)) {
                    switch (ans) {
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

        internal static void menu() {
            string op = "0";
            while (op == "0") 
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("[1] - Funções recursivas sem vetor");
                Console.WriteLine("[2] - Funções recursivas com vetor");
                Console.WriteLine("[3] - Sair");
                op = Utils.strInput("Informe uma das opções acima: ");
            }

            if (op == "1") {
                withoutVetor();
                menu();
            }
            else if (op == "2") {
                withVetor();
                menu();
            }
            else if (op == "3") {
                Console.WriteLine("Programa Finalizado!");
            }
        }
    }
}
