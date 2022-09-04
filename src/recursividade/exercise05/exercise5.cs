using static UtilsFunc.Utils;
// using static UtilsFunc.oie; -- import da Classe que possui o método com This, pra extensão.
namespace Exercises
{   
    class Exercise05
    {
        int fib(int fn) {
            if ((fn ==  0) || (fn == 1))    return fn;
            else if (fn >= 2) return (fib(fn - 1) + fib(fn - 2));
            else return 0;
        }
        public void main() {
            int number;
            number = intInput("Informe um valor: ");
            Console.WriteLine(fib(number));
        }
    }
}