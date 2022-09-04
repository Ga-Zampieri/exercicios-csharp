using static UtilsFunc.Utils;
// using static UtilsFunc.oie; -- import da Classe que possui o método com This, pra extensão.
namespace Exercises
{
    class Exercise05
    {
        int fibonacciRecursive(int fib_num_position)
        {
            if ((fib_num_position == 0) || (fib_num_position == 1)) return fib_num_position;
            else if (fib_num_position >= 2) return (fibonacciRecursive(fib_num_position - 1) + fibonacciRecursive(fib_num_position - 2));
            else return 0;
        }

        int fibonacciIterative(int fib_num_position, int acumulated)
        {
            int firstValue = 0, secondValue = 1, i = 2;
            if ((fib_num_position == 0) || (fib_num_position == 1)) return fib_num_position;
            if (fib_num_position >= 2){
                while (i <= fib_num_position)
                {
            acumulated = firstValue + secondValue;
                firstValue = secondValue;
                secondValue = acumulated;
                i++;
                }
            }
            return acumulated;
        }



        public void main()
        {
            int number, acumulatedulatedValue = 0;
            number = intInput("Informe um valor: ");
            Console.WriteLine(fibonacciRecursive(number));
            Console.WriteLine(fibonacciIterative(number, acumulatedulatedValue));
        }
    }
}
