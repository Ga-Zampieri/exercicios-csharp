Activities ac = new Activities();
ac.main();
class Activities
{
    public void main()
    {
        string op = "0";
        while (op == "0")
        {
            Console.WriteLine("Menu Principal");
            Console.WriteLine("[1] - Potência");
            Console.WriteLine("[2] - Cubos");
            Console.WriteLine("[3] - Mdc");
            Console.WriteLine("[4] - Fibonacci");
            Console.WriteLine("[5] - Conversão para binário");
            Console.WriteLine("[6] - Sair");
            Console.Write("Informe uma das opções acima: ");
            op = Console.ReadLine();
        }

        if (op == "1")
        {
            int x, y;
            Console.Write("Informe um número inteiro para ser a base da potência: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Informe um número inteiro para elevar a base informada: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine(pow(x,y));
            Console.ReadKey();
            Console.Clear();
            main();
        }
        else if (op == "2")
        {
            int x;
            Console.Write("Informe um número inteiro: ");
            x = int.Parse(Console.ReadLine());
            cubos(x);
            Console.ReadKey();
            Console.Clear();
            main();
        }
        else if (op == "3")
        {
            int x, y;
            Console.Write("Informe um número inteiro para calcular o mdc: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Informe um número inteiro para calcular o mdc: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine(mdc(x,y));
            Console.ReadKey();
            Console.Clear();
            main();
        }
        else if (op == "4")
        {
            int x;
            Console.Write("Informe um número inteiro para que seja calculado o número de fibonacci desta posição: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacciRecursive(x));
            Console.ReadKey();
            Console.Clear();
            main();
        }
        else if (op == "5")
        {
            int x;
            Console.Write("Informe um número inteiro para que este seja representado de forma binária: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(binaryRecursive(x));
            Console.ReadKey();
            Console.Clear();
            main();
        }
        else if (op == "6")
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Programa finalizado.");
        }
    }

    int pow(int x, int y) 
    {
        if (y > 0) return x * pow(x, y-1);
        return 1;
    }

    void cubos(int n) 
    {
        if (n > 0) 
        {
            cubos(n-1);
            Console.WriteLine(n*n*n);
        }
    }

    int mdc(int x, int y) {
        if (x == y) return x;
        else if (y % x > 0)  return mdc((y % x), x);
        else    return x;
    }

    int fibonacciRecursive(int fib_num_position)
    {
        if ((fib_num_position == 0) || (fib_num_position == 1)) return fib_num_position;
        else if (fib_num_position >= 2) return (fibonacciRecursive(fib_num_position - 1) + fibonacciRecursive(fib_num_position - 2));
        else return 0;
    }

    string binaryRecursive(int n)
    {
        if (n == 0) return ""; 
        return binaryRecursive(n/2) + Convert.ToString(n%2); 
    }
}
