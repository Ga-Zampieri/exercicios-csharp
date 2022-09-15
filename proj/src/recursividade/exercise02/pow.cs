using static UtilsFunc.Utils;
// using static UtilsFunc.oie; -- import da Classe que possui o método com This, pra extensão.
namespace Exercises
{   
    public class Exercise02
    {
        public int pow(int x, int y) {
            if (y > 0) return x * pow(x, y-1);
            return 1;
        }
        public void main() {
            int x, y;
            x = intInput("Informe o valor da base: ");
            y = intInput("Informe o valor do expoente: ");
            Console.WriteLine(pow(x, y));
        }
    }
}