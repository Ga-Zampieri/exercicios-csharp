using static UtilsFunc.Utils;
// using static UtilsFunc.oie; -- import da Classe que possui o método com This, pra extensão.
namespace Exercises
{   
    class Exercise04
    {
        int mdc(int x, int y) {
            if (x == y) return x;
            else if (y % x > 0)  return mdc((y % x), x);
            else    return x;
        }
        public void main() {
            int x, y;
            x = intInput("Informe um valor: ");
            y = intInput("Informe um valor: ");
            Console.WriteLine(mdc(lowestValue(x, y), highestValue(x, y)));
        }
    }   
}