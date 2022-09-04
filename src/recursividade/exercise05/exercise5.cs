using static UtilsFunc.Utils;
// using static UtilsFunc.oie; -- import da Classe que possui o método com This, pra extensão.
namespace Exercises
{
    class Exercise05
    {
        int fibRec(int fn)
        {
            if ((fn == 0) || (fn == 1)) return fn;
            else if (fn >= 2) return (fibRec(fn - 1) + fibRec(fn - 2));
            else return 0;
        }

        int fibIte(int fn, int acum)
        {
            int fst = 0, scnd = 1, i = 2;
            if ((fn == 0) || (fn == 1)) return fn;
            if (fn >= 2){
                while (i <= fn)
                {
                acum = fst + scnd;
                fst = scnd;
                scnd = acum;
                i++;
                }
            }
            return acum;
        }



        public void main()
        {
            int number, acumulador = 0;
            number = intInput("Informe um valor: ");
            Console.WriteLine(fibRec(number));
            Console.WriteLine(fibIte(number, acumulador));
        }
    }
}
