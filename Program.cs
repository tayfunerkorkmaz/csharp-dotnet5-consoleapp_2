using System;

namespace csharp_dotnet5_consoleapp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iVal = -1;
            uint k = 1;
            float fVal = 1;
            decimal dVal = 1;

            string str = null;
            str = String.Empty;
            str = "Tayfun";
            string str2 = "Erkorkmaz";
            string myNameAndSurname = str + " " + str2;

            Console.WriteLine(myNameAndSurname);

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);

            object o1 = 4.3;
            object o2 = "test";



            bool bVal = 1 > 5;
            Console.WriteLine(bVal);

            //Dönüşümler

            Console.WriteLine("***Implicit Conversion"); //Bilinçsiz Dönüşüm

            int iValx = 5;
            string kValx = "Merhaba" + iValx;

            Console.WriteLine("***Explicit Conversion"); //Bilinçli Dönüşüm
            float fVal2 = 1.4f;
            byte bVal2 = (byte)fVal2;

            Console.WriteLine("***ToString() Conversion"); //ToString Dönüşüm
            int value1 = 90;
            string value2 = Convert.ToString(value1);
            string value3 = value1.ToString();

            Console.WriteLine("***System.Convert Class Conversion"); //System.Convert Class  Dönüşüm
            string sVal = "5";
            int intVal = Convert.ToInt32(sVal);

            Console.WriteLine("***Parse Method Conversion"); //Parse Method Dönüşümü
            string sVal2 = "10.1";
            float fVal3 = float.Parse(sVal2);

        }
    }
}
