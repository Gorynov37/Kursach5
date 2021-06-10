using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachLib
{
    public class Utilites
    {
        public static string RandomInit(int n, List dataObj) 
        {
            string str = null;
            if (dataObj is List<int>) str = InitInt(n);
            if (dataObj is List<double>) str = InitDouble(n);
            if (dataObj is List<string>) str = InitString(n);
            return str;
        }

        private static string InitInt(int n) 
        {
            string str = string.Empty;
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                str += rnd.Next(-7*n, 7*n).ToString();
                str += " ";
            }

            return str;
        }
        private static string InitDouble(int n)
        {
            string str = string.Empty;
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                str += (rnd.NextDouble()*rnd.Next(-7 * n, 7 * n)).ToString();
                str += " ";
            }

            return str;
        }
        private static string InitString(int n)
        {
            string str = string.Empty;
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random rnd = new Random();

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < 5; j++) str += letters[rnd.Next(0, 51)];
                str += " ";
            }

            return str;
        }

        public static List InputList(TextBox TB, List list)
        {
            if (list is List<int>) list = InputListInt(TB);
            if (list is List<double>) list = InputListDouble(TB);
            if (list is List<string>) list = InputListString(TB);

            return list;
        }

        private static List<int> InputListInt(TextBox TB)
        {
            List<int> list = new List<int>();

            string str = TB.Text;
            string[] S = str.Trim().Split(' ', '\r', '\n');

            foreach (string s in S)
            {
                if (!String.IsNullOrWhiteSpace(s))
                {
                    list.PushBack(int.Parse(s));
                }
            }

            return list;
        }

        private static List<double> InputListDouble(TextBox TB)
        {
            List<double> list = new List<double>();

            string str = TB.Text;
            string[] S = str.Trim().Split(' ', '\r', '\n');

            foreach (string s in S)
            {
                if (!String.IsNullOrWhiteSpace(s))
                {
                    list.PushBack(double.Parse(s));
                }
            }

            return list;
        }

        private static List<string> InputListString(TextBox TB)
        {
            List<string> list = new List<string>();

            string str = TB.Text;
            string[] S = str.Trim().Split(' ', '\r', '\n');

            foreach (string s in S)
            {
                if (!String.IsNullOrWhiteSpace(s))
                {
                    list.PushBack(s);
                }
            }

            return list;
        }

        public static void Output(List list, TextBox TB)
        {
            TB.Text = list.ToString();
        }
    }
}
