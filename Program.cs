using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCompany
{
    [TestClass]
    public class TestProgram
    {
        [TestMethod]
        public void TestGetSquareTriangle2_1()
        {
        var res = MyComanyLib.GetSquareTriangle(2, 1);
        Debug.WriteLine("result 2 1: " + res);
        Assert.AreEqual(1, res);
    }

        [TestMethod]
        public void TestGetSquareTriangle3_1()
        {
            var res = MyComanyLib.GetSquareTriangle(3, 1);
            Debug.WriteLine("result 3 1: " + res);
            Assert.AreEqual(1.5, res);
        }
    }


    public class MyComanyLib
    {
        public static float GetSquareTriangle(float a, float b)
        {
            if ((a<=0)||(b<=0))
            {
                throw  new Exception();
            }
            float res;
            checked
            {
                res = (a*b)/2;
            }
            return res;
        }
    }

    public class ExampleOfUsage
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("result is {0}", MyComanyLib.GetSquareTriangle(float.MaxValue, float.MaxValue));
                Console.WriteLine("result is {0}", MyComanyLib.GetSquareTriangle(2.5f, 2));
                Console.WriteLine("result is {0}", MyComanyLib.GetSquareTriangle(3, 1));
                Console.WriteLine("result is {0}", MyComanyLib.GetSquareTriangle(1, -1));
                Console.WriteLine("result is {0}", MyComanyLib.GetSquareTriangle(float.MinValue, float.MinValue));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
