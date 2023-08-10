using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace PlusCalcUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()

        {
            // Redirect console output for testing
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Provide input values to simulate user input
            string input = "3" + Environment.NewLine + "5" + Environment.NewLine;
            StringReader sr = new StringReader(input);
            Console.SetIn(sr);

            // Run the program
            PlusCalcConsole.Program.Main(null);

            // Get the output
            string output = sw.ToString();

            // Assert the output contains the expected result
            StringAssert.Contains(output, "The sum of 3 and 5 is: 8");

            // Clean up
            sw.Close();
            sr.Close();
        }

        [TestMethod]
        public void TestMethod2()

        {
            // Redirect console output for testing
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Provide input values to simulate user input
            string input = "3" + Environment.NewLine + "1" + Environment.NewLine;
            StringReader sr = new StringReader(input);
            Console.SetIn(sr);

            // Run the program
            PlusCalcConsole.Program.Main(null);

            // Get the output
            string output = sw.ToString();

            // Assert the output contains the expected result
            StringAssert.Contains(output, "The sum of 3 and 1 is: 5");

            // Clean up
            sw.Close();
            sr.Close();
        }

        [TestMethod]
        public void TestMethod3()

        {
            // Redirect console output for testing
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Provide input values to simulate user input
            string input = "2" + Environment.NewLine + "1" + Environment.NewLine;
            StringReader sr = new StringReader(input);
            Console.SetIn(sr);

            // Run the program
            PlusCalcConsole.Program.Main(null);

            // Get the output
            string output = sw.ToString();

            // Assert the output contains the expected result
            StringAssert.Contains(output, "The sum of 3 and 1 is: 5");

            // Clean up
            sw.Close();
            sr.Close();
        }

        [TestMethod]
        public void TestMethod4()

        {
            // Redirect console output for testing
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Provide input values to simulate user input
            string input = "10" + Environment.NewLine + "11" + Environment.NewLine;
            StringReader sr = new StringReader(input);
            Console.SetIn(sr);

            // Run the program
            PlusCalcConsole.Program.Main(null);

            // Get the output
            string output = sw.ToString();

            // Assert the output contains the expected result
            StringAssert.Contains(output, "The sum of 10 and 11 is: 21");

            // Clean up
            sw.Close();
            sr.Close();
        }

        [TestMethod]
        public void TestMethod5()

        {
            // Redirect console output for testing
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            // Provide input values to simulate user input
            string input = "2" + Environment.NewLine + "3" + Environment.NewLine;
            StringReader sr = new StringReader(input);
            Console.SetIn(sr);

            // Run the program
            PlusCalcConsole.Program.Main(null);

            // Get the output
            string output = sw.ToString();

            // Assert the output contains the expected result
            StringAssert.Contains(output, "The sum of 2 and 3 is: 5");

            // Clean up
            sw.Close();
            sr.Close();
        }
    }
}
