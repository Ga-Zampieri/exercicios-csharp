using static UtilsFunc.Utils;

namespace Exercises;

public class airplaneList
{

    public void main()
    {
        int firstPosition = 0, lastPosition = 0, MAX = 50;
        int[] airplanesQueue = new int[MAX];
        menu(airplanesQueue, ref firstPosition, ref lastPosition);
    }

    void menu(int[] airplanesQueue, ref int firstPosition, ref int lastPosition)
    {
        string[] possibleChoices = new string[] {"[1] - Adicionar Aviões", "[2] - Consultar quantidade de aviões", "[3] - Autorizar decolagem", "[4] - Listar número de cada avião", "[5] - Consultar o número do primeiro avião", "[6] - Finalizar Programa"};
        
        bool continuar = true;
        int[] possibleAnswers = new int[] {1,2,3,4,5,6};
        
        while (continuar)
        {
            foreach (string choice in possibleChoices)
            {
                Console.WriteLine(choice);
            }
            int answer = intInput("Informe o valor da atividade que deseja realizar, confome o menu acima: ");
            while (!(possibleAnswers.Contains(answer)))
            {
                answer = intInput("Informe o valor da atividade que deseja realizar, confome o menu acima: ");
            }
            switch (answer)
            {
                case 1:
                    addAirplanesToQueue(airplanesQueue, ref lastPosition);
                break;
                case 2:
                    Console.WriteLine(getQueueLength(ref firstPosition, ref lastPosition));
                break;
                case 3:
                    if (!(queueIsEmpty(ref firstPosition, ref lastPosition)))
                    {
                        flightAuthorization(airplanesQueue, ref firstPosition);
                    }
                    else
                    {
                        Console.WriteLine("Não há voos na fila para serem autorizados.");
                    }
                break;
                case 4:
                    listNumberOfAllAirplanesOnQueue(airplanesQueue, firstPosition, lastPosition);
                break;
                case 5:
                    Console.WriteLine($"Posição: {firstPosition} - Número: {getFirstPlaneNumber(airplanesQueue, firstPosition)}");
                break;
                case 6:
                    Console.WriteLine("Programa Finalizado!");
                    continuar = false;
                break;
            }
        }
        
    }

    void addAirplanesToQueue(int[] airplanesQueue, ref int lastPos)
    {
        int quantity = intInput("Informe a quantidade de aviões que irá inserir na fila: ");
        for (int i = 0; i < quantity; i++)
        {
            int numero = intInput("Informe o número do avião: ");
            addIntToQueue(airplanesQueue, ref lastPos, numero);
        }
    }

    int getQueueLength(ref int firstPosition, ref int lastPosition)
    {
        return (lastPosition - firstPosition);
    }

    void flightAuthorization(int[] queue, ref int firstPosition)
    {
        Console.WriteLine($"O avião de número {removeIntFromQueue(queue, ref firstPosition)} está autorizado para levantar voo.");
    }

    void listNumberOfAllAirplanesOnQueue(int[] queue, int firstPosition,int lastPosition)
    {
        for (; firstPosition < lastPosition; firstPosition++)
        {
            Console.WriteLine($"{firstPosition} - {queue[firstPosition]}");
        }
    }

    int getFirstPlaneNumber(int[] queue, int firstPosition)
    {
        return queue[firstPosition];
    }

    // Funções utilitárias utilizadas para reduzir a escrita repetitiva de código.
    void addIntToQueue(int[] queue, ref int lastPosition, int value)
    {
        queue[lastPosition] = value;
        lastPosition++;
    }

    int removeIntFromQueue(int[] queue, ref int firstPosition)
    {
        return  queue[firstPosition++]; 
    }

    bool queueIsEmpty(ref int firstPosition, ref int lastPosition)
    {
        if (firstPosition == lastPosition)  return true;
        return false;
    }

    int intInput(string msg)
    {
        int ans;
        Console.Write(msg);
        ans = int.Parse(Console.ReadLine());
        return ans;
    }
}