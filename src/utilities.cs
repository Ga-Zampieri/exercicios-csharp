namespace UtilsFunc
{
    public class Utils{
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

    }

}
