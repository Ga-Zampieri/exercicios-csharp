using static UtilsFunc.Utils;

namespace Exercises;

public class queueConcept
{
    public void main()
    {
        Console.WriteLine("Informe no máximo 50 números inteiros.");
        int[] intQueue = new int[50];
        int firstPos = 0, lastPos = 0;
        int numero, sum = 0, lowestNumber, highestNumber;
        numero = intInput("Informe qualquer número, caso queira parar basta informar 00: ");
        highestNumber = numero;
        lowestNumber = numero;        
        while (numero != 00)
        {
            addIntToQueue(intQueue, ref lastPos, numero);
            numero = intInput("Informe qualquer número, caso queira parar basta informar 00: ");
        }
        while ((firstPos != lastPos) && (lastPos != 50))
        {
            highestNumber = highestValue(highestNumber, intQueue[firstPos]);
            lowestNumber = lowestValue(lowestNumber, intQueue[firstPos]);
            sum += removeIntFromQueue(intQueue, ref firstPos);
        }
        Console.WriteLine($"Média aritmética: {sum/(lastPos)}\nMenor Valor: {lowestNumber}\nMaior Valor: {highestNumber}.");
    }
}