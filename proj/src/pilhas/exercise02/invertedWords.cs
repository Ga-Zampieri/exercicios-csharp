using static UtilsFunc.Utils;

namespace Exercises;

public class invertedWords
{
    public void main()
    {
        string phrase = strInput("Informe uma frase com no máximo 100 caracteres: ");
        insertStringOnStack(phrase);
    }

    void insertStringOnStack(string phrase)
    {
        int MAX = 100, topStack = 0;
        char[] stack = new char[MAX];
        while (phrase.Length != topStack)
        {
            addStrValueToStack(stack, ref topStack, phrase[topStack]);
        }
        showInvertedString(stack, ref topStack);
    }

    void showInvertedString(char[] stack, ref int topStack)
    {
        while (!stackIsEmpty(ref topStack))
        {
            removeStrValueFromStack(stack, ref topStack);
            Console.Write(stack[topStack]);
        }
    }
}

