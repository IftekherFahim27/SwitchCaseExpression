using System;
using System.Diagnostics;

namespace SwitchCaseExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Value
            int testValue = 6;
            int loopCount = 1_000_000; 

            Stopwatch sw = new Stopwatch();

            //Switch Case
            sw.Start();
            for (int i = 0; i < loopCount; i++)
            {
                _ = SwitchCaseExample(testValue);
            }
            sw.Stop();
            Console.WriteLine($"Switch-Case Time: {sw.ElapsedMilliseconds} ms");

            //Switch Expression
            sw.Restart();
            for (int i = 0; i < loopCount; i++)
            {
                _ = SwitchExpressionExample(testValue);
            }
            sw.Stop();
            Console.WriteLine($"Switch Expression Time: {sw.ElapsedMilliseconds} ms");

            Console.ReadLine();
        }

        // Old Style Switch-Case
        static string SwitchCaseExample(int fusion_infotech_product)
        {
            switch (fusion_infotech_product)
            {
                case 1: return "SAP A1";
                case 2: return "SAP B1";
                case 3: return "Oracel";
                case 4: return "ERPNext";
                case 5: return "Mobile Applicaton";
                case 6: return "Web Application";
                default: return "AI ......Coming Soon";
            }
        }

        // New Style Switch Expression 
        static string SwitchExpressionExample(int fusion_infotech_product) =>
            fusion_infotech_product switch
            {
                1 => "SAP A1",
                2 => "SAP B1",
                3 => "Oracel",
                4 => "ERPNext",
                5 => "Mobile Applicaton",
                6 => "Web Application",
                _ => "AI ......Coming Soon"
            };
    }
}
