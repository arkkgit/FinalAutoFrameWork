using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAutoFrameWork.Utilities
{
    public class Utils
    {

       public static string GenerateRandomNumber(int numDigits)
        {
            Random rand = new Random();
            int min = (int)Math.Pow(10, numDigits - 1);
            int max = (int)Math.Pow(10, numDigits) - 1;
            int randomNumber = rand.Next(min, max + 1);
            return randomNumber.ToString();
        }

        public static Dictionary<string, string> LoadData(string fname)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            var report = File.ReadAllLines(fname);
            foreach (string line in report)
            {
                string[] keyvalue = line.Split('=');
                if (keyvalue.Length == 2)
                {
                    result.Add(keyvalue[0].Trim(), keyvalue[1].Trim());
                }
            }
            return result;

        }

    }
}
