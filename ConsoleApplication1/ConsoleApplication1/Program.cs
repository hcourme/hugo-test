using System;
using System.Configuration;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = String.Format(CultureInfo.CurrentUICulture, "Message : {0}",
                ConfigurationManager.AppSettings[Constants.AppSettingKeys.MessageContent]);
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }
    }
}
