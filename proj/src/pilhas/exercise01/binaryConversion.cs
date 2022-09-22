using static UtilsFunc.Utils;

namespace Exercises;

public class stack_binaryConversion
{
    public void main()
    {
        int value;
        value = intInput("Informe um número inteiro: ");
        binaryConversionWithStack(value);
    }

    void showBinary(int[] stackList, ref int topOfStack)
    {
        while (!stackIsEmpty(ref topOfStack))
        {
            removeIntValueFromStack(stackList, ref topOfStack);
            Console.Write(Convert.ToString(stackList[topOfStack]));
        }
    }

    void binaryConversionWithStack(int value)
    {
        int topOfStack = 0, MAX = 20;
        int[] stackList = new int[MAX];
        while (value != 0)
        {
            addIntValueToStack(stackList, ref topOfStack, (value % 2));
            value /= 2;
        }
        showBinary(stackList, ref topOfStack);
    }
}

