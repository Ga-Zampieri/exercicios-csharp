using static UtilsFunc.Utils;

namespace Exercises;

public class isCorrectClosed
{
    public void main()
    {
        string phrase = strInput("Informe a expressão: ");
        buildStack(phrase);
    }

    void buildStack(string phrase)
    {
        string acopladores = "{}[]()";
        char[] stack = new char[30];
        int topStack = 0;
        for (int i = 0; i < phrase.Length; i++)
        {
            if (acopladores.Contains(phrase[i]))
            {
                addStrValueToStack(stack, ref topStack, phrase[i]);
            }
        }
        showStack(stack, ref topStack);
    }

    void showStack(char[] stack, ref int topStack)
    {
        while (!stackIsEmpty(ref topStack))
        {
            removeStrValueFromStack(stack, ref topStack);
            Console.Write(stack[topStack]);
        }
    }
}

