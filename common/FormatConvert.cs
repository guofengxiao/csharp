using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class FormatConvert
    {
        public static string doubleArray2string(double[] dArray)
        {
            string result = "";
            if (dArray.Length == 0)
                return "null string";
            for (int i = 0; i < dArray.Length; i++)
            {
                string temp = dArray[i].ToString("00000.00");
                result += temp;
                result += " # ";
            }
            return result;
        }
        public static double toRadian(double value)
        {
            return ((value * Math.PI) / 180.0);
        }
        public static double toDegree(double value)
        {
            return (value * 180.0) / Math.PI;
        }
        public static double[] toDegree(double[] dArray)
        {
            double[] result = new double[dArray.Length];
            for (int i = 0; i < dArray.Length; i++)
            {
                result[i] = toDegree(dArray[i]);
            }
            return result;
        }
    }
}
