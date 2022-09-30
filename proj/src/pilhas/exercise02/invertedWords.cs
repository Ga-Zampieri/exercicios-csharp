using static UtilsFunc.Utils;

namespace Exercises;

public class invertedWords
{
    public void main()
    {
        Console.Write("Informe uma frase com no máximo 100 caracteres: ");
        string phrase = Console.ReadLine();
        breakWords(phrase);
    }

    void breakWords(string phrase)
    {
        char[] stack = new char[100];
        int topStack = 0, contador = 0;
        while(contador < phrase.Length)
        { // enquanto não for o fim da string
            if(phrase[contador] != ' ') // se não for um espaço, então empilha o caracter
                insertOnStack(stack, ref topStack, phrase[contador]);
            else 
            { // se for um espaço, desempilha toda a palavra empilhada
                while(!(stackIsEmpty(ref topStack)))
                {
                    Console.Write(removeFromStack(stack, ref topStack));
                }
                Console.Write(' ');
            }
            contador++;
        }
        while(!(stackIsEmpty(ref topStack)))
        {
            Console.Write(removeFromStack(stack, ref topStack));
        }
    }

    void insertOnStack(char[] stack, ref int topStack, char value)
    {
        stack[topStack] = value;
        topStack++;
    }

    char removeFromStack(char[] stack, ref int topStack)
    {
        topStack--;
        return stack[topStack];
    }

    bool stackIsEmpty(ref int topStack)
    {
        if (topStack == 0)  return true;
        return false;
    }

}
