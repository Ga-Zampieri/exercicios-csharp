namespace UtilsFunc;
public class Utils
{

    // General Functions //
    public static string strInput(string msg)
    {
        string ans;
        Console.Write(msg);
        ans = Console.ReadLine();
        return ans;
    }

    public static int intInput(string msg)
    {
        int ans;
        Console.Write(msg);
        ans = int.Parse(Console.ReadLine());
        return ans;
    }

    public static float floatInput(string msg)
    {
        float ans;
        Console.Write(msg);
        ans = float.Parse(Console.ReadLine());
        return ans;
    }

    public static int lowestValue(int num_01, int num_02)
    {
        int lowestNumber = num_01;
        if (num_02 < lowestNumber) return num_02;
        else return lowestNumber;
    }

    public static int highestValue(int num_01, int num_02)
    {
        int highestNumber = num_01;
        if (num_02 > highestNumber) return num_02;
        else return highestNumber;
    }


    // Stacks Functions //

    public static void addIntValueToStack(int[] lista, ref int topStack, int value)
    {
        lista[topStack] = value;
        topStack += 1;
    }

    public static void addStrValueToStack(char[] lista, ref int topStack, char value)
    {
        lista[topStack] = value;
        topStack += 1;
    }

    public static int removeIntValueFromStack(int[] lista, ref int topStack)
    {
        topStack -= 1;
        return lista[topStack];
    }

    public static int removeStrValueFromStack(char[] lista, ref int topStack)
    {
        topStack -= 1;
        return lista[topStack];
    }

    public static bool stackIsFull(ref int topStack, int maxLenght)
    {
        if (topStack == maxLenght) return true;
        return false;
    }

    public static bool stackIsEmpty(ref int topStack)
    {
        if (topStack == 0) return true;
        return false;
    }
}

// public static class oie           --  Declaração de classe estática com método de extensão 
// {
//       public static string strInput2(this string msg) 
//     {
//         string ans;
//         Console.Write(msg);
//         ans = Console.ReadLine();
//         return ans;
//     }
// }



