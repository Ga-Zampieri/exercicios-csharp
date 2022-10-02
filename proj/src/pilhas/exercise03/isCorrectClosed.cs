using static UtilsFunc.Utils;

namespace Exercises;

public class isCorrectClosed
{
    public void main()
    {
        string phrase = strInput("Informe a expressão: ");
        buildStack(phrase);
    }

    public bool buildStack(string phrase)
    {
        bool compativel;
        int[] stack = new int[20];
        int indice = 0, topStack = 0;;
        string abridores = "({[", fechadores = ")}]";
        while (indice < phrase.Length)
        {
            compativel = true;
            if (abridores.Contains(phrase[indice]))
            {
                int a = 0;
                while (compativel)
                {
                    if (abridores[a] == phrase[indice])
                    {
                        addIntValueToStack(stack, ref topStack, a);
                        compativel = false;
                    }
                    a++;
                }
            }
            else if (fechadores.Contains(phrase[indice]))
            {
                if (!(stackIsEmpty(ref topStack)))
                {
                    int f = 0;
                    while (compativel)
                    {
                        if (fechadores[f] == phrase[indice])
                        {
                            int value = removeIntValueFromStack(stack, ref topStack);
                            compativel = false;
                            if (value != f)
                            {
                                Console.WriteLine("Inválido!");
                                return false;
                            }
                        }
                        f++;
                    }
                }
                else 
                {
                    Console.WriteLine("Inválido!");
                    return false;
                }
            }
            if (indice == (phrase.Length-1) && !(stackIsEmpty(ref topStack)))
            {
                return false;
            }
            indice ++;
        }
        return true;
    }
}

