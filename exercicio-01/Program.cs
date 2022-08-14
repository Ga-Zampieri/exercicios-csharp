// See https://aka.ms/new-console-template for more information



string strInput(string msg) {
    string ans;
    Console.Write(msg);
    ans = Console.ReadLine();
    return ans;
}

int intInput(string msg) {
    int ans;
    Console.Write(msg);
    ans = Convert.ToInt32(Console.ReadLine());
    return ans;
}

double floatInput(string msg) {
    double ans;
    Console.Write(msg);
    ans = Convert.ToDouble(Console.ReadLine());
    return ans;
}

void withoutVetor() {
    int number_1, number_2, lowestnum, highestnum;
    number_1 = intInput("Informe o primeiro número: ");
    number_2 = intInput("Informe o segundo número: ");
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

void secondary_options(int lowest, int highest) {
    int ans, i, sumvalues;
    int[] possibleAnswers = new int[6];
    possibleAnswers[0] = 1;
    possibleAnswers[1] = 2;
    possibleAnswers[2] = 3;
    possibleAnswers[3] = 4;
    possibleAnswers[4] = 5;
    possibleAnswers[5] = 6;
    int op = 0;
    while (op == 0){
        Console.WriteLine("MENU SECUNDÁRIO\n[1] - Inteiros em ordem crescente.\n[2] - Inteiros em ordem decrescente.\n[3] - Inteiros ímpares (crescente).\n[4] - Somatória dos inteiros.\n[5] - Nova seleção de números. \n[6] - Voltar ao menu inicial.");
        ans = intInput("Informe uma das opções acima: ");
        if (possibleAnswers.Contains(ans)) {
            switch (ans) {
                case 1:
                     for (i = lowest; i <= highest; i++) {
                        Console.WriteLine(i);
                     }
                break;
                case 2:
                    for (i = highest; i >= lowest; i--) {
                        Console.WriteLine(i);
                    }
                break;
                case 3:
                    for (i = lowest; i <= highest; i++) {
                        if (i % 2 != 0) {
                            Console.WriteLine(i);
                        }
                    }
                break;
                case 4:
                    sumvalues = 0;
                    for (i = lowest; i <= highest; i++) {
                        sumvalues += i;
                    }
                    Console.WriteLine(sumvalues);
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

void menu() {
    string op = "0";
    while (op == "0") 
    {
        Console.WriteLine("Menu Principal");
        Console.WriteLine("[1] - Funções recursivas sem vetor");
        Console.WriteLine("[2] - Funções recursivas com vetor");
        Console.WriteLine("[3] - Sair");
        op = strInput("Informe uma das opções acima: ");
    }

    if (op == "1") {
        withoutVetor();
        menu();
    }
    else if (op == "2") {

    }
    else if (op == "3") {
        Console.WriteLine("Programa Finalizado!");
    }
}

menu();
