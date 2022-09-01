namespace UtilsFunc
{
    public class Utils
    {
        public static string strInput(string msg) {
            string ans;
            Console.Write(msg);
            ans = Console.ReadLine();
            return ans;
        }

        public static int intInput(string msg) {
            int ans;
            Console.Write(msg);
            ans = int.Parse(Console.ReadLine());
            return ans;
        }

        public static float floatInput(string msg) {
            float ans;
            Console.Write(msg);
            ans = float.Parse(Console.ReadLine());
            return ans;
        }

        public static int lowestHighestValue(int num_01, int num_02) {
            int highestNumber, int lowestNumber = num_01;
            lowestNumber = num_01;
            if (num_02 < lowestNumber)
            {
                lowestNumber = num_02;
                highestNumber = num_01;
            }
            else    highestnum = number_2;
            return lowestNumber, highestNumber
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


}
