using static UtilsFunc.Utils;
// using static UtilsFunc.oie; -- import da Classe que possui o método com This, pra extensão.
namespace Exercises
{
    class Exercise06
    {
        string binaryIterative(int n)
        {
            string rest = "";
            while (n / 2 != 0)
            {
                rest = Convert.ToString(n % 2) + rest;
                n = n / 2;
            }
            rest = Convert.ToString(n % 2) + rest;
            return rest;
        }

        string binaryRecursive(int n)
        {
            if (n == 0) return ""; 
            return binaryRecursive(n/2) + Convert.ToString(n%2); 
        }
        public void main()
        {
            int number;
            number = intInput("Informe um valor que será representado em forma binária: ");
            Console.WriteLine(binaryIterative(number));
            Console.WriteLine(binaryRecursive(number));
        }
    }
}