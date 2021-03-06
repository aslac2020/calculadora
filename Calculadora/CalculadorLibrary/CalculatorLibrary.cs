using System;
using System.IO;
using System.Diagnostics;

namespace CalculatorProgram
{
    public class CalculatorLibrary
    {
        public class Calculator
        {
            public Calculator()
            {
                StreamWriter logFile = File.CreateText("calculatora.log");
                Trace.Listeners.Add(new TextWriterTraceListener(logFile));
                Trace.AutoFlush = true;
                Trace.WriteLine("Starting Calculator Log");
                Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
            }

            public  double DoOperation(double num1, double num2, string op)
            {
                double result = double.NaN;

                switch (op)
                {
                    case "sm":
                        result = num1 + num2;
                        Trace.WriteLine(String.Format("{0} + {1} = {2}", num1, num2, result));
                        break;
                    case "st":
                        result = num1 - num2;
                        Trace.WriteLine(String.Format("{0} - {1} = {2}", num1, num2, result));
                        break;
                    case "m":
                        result = num1 * num2;
                        Trace.WriteLine(String.Format("{0} * {1} = {2}", num1, num2, result));
                        break;
                    case "d":
                        // Ask the user to enter a non-zero divisor.
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Trace.WriteLine(String.Format("{0} / {1} = {2}", num1, num2, result));
                        }
                        break;
                    // Return text for an incorrect option entry.
                    default:
                        break;
                }
                return result;
            }
        }
    }
}
