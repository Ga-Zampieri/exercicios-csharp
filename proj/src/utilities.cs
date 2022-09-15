namespace UtilsFunc;
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

        public static int lowestValue(int num_01, int num_02) {
            int lowestNumber = num_01;
            if (num_02 < lowestNumber)  return num_02;
            else    return lowestNumber;
        }

        public static int highestValue(int num_01, int num_02) {
            int highestNumber = num_01;
            if (num_02 > highestNumber) return num_02;
            else    return highestNumber;
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



