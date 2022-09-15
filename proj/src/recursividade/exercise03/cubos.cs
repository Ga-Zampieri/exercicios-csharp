using static UtilsFunc.Utils;
// using static UtilsFunc.oie; -- import da Classe que possui o método com This, pra extensão.
namespace Exercises
{   
    class Exercise03
    {
        void cubos(int n) {
            if (n > 0) 
            {
                cubos(n-1);
                Console.WriteLine(Math.Pow(n, 3));
            }
        }
        public void main() {
            int n = intInput("Informe um número inteiro: ");
            cubos(n);
        }
    }
    
}