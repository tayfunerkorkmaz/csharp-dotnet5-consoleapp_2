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

            int value1= 90;
            string value2 = Convert.ToString(value1);
            string value3 = value1.ToString();
            
            bool bVal = 1>5;
            Console.WriteLine(bVal);


        }
    }
}
