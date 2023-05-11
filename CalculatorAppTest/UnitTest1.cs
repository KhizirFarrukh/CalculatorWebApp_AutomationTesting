using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CalculatorAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase001()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("1234");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("4321");

            driver.FindElement(By.Id("Operation")).SendKeys("+");
            
            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "5555");

            driver.Close();
        }

        [TestMethod]
        public void TestCase002()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("1010");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("5987");

            driver.FindElement(By.Id("Operation")).SendKeys("-");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "-4977");

            driver.Close();
        }

        [TestMethod]
        public void TestCase003()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("105");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("549");

            driver.FindElement(By.Id("Operation")).SendKeys("*");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "57645");

            driver.Close();
        }

        [TestMethod]
        public void TestCase004()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("9801");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("11");

            driver.FindElement(By.Id("Operation")).SendKeys("/");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "891");

            driver.Close();
        }

        [TestMethod]
        public void TestCase005()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("0");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("0");

            driver.FindElement(By.Id("Operation")).SendKeys("+");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "0");

            driver.Close();
        }

        [TestMethod]
        public void TestCase006()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("0");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("0");

            driver.FindElement(By.Id("Operation")).SendKeys("-");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "0");

            driver.Close();
        }

        [TestMethod]
        public void TestCase007()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("0");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("0");

            driver.FindElement(By.Id("Operation")).SendKeys("*");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "0");

            driver.Close();
        }

        [TestMethod]
        public void TestCase008()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("0");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("5");

            driver.FindElement(By.Id("Operation")).SendKeys("/");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "0");

            driver.Close();
        }

        [TestMethod]
        public void TestCase009()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("11");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("0");

            driver.FindElement(By.Id("Operation")).SendKeys("/");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "Cannot divide by zero.");

            driver.Close();
        }

        [TestMethod]
        public void TestCase010()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("-5");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("105");

            driver.FindElement(By.Id("Operation")).SendKeys("+");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "100");

            driver.Close();
        }

        [TestMethod]
        public void TestCase011()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("-105");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("395");

            driver.FindElement(By.Id("Operation")).SendKeys("-");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "-500");

            driver.Close();
        }

        [TestMethod]
        public void TestCase012()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("-5");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("42");

            driver.FindElement(By.Id("Operation")).SendKeys("*");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "-210");

            driver.Close();
        }

        [TestMethod]
        public void TestCase013()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("-1024");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("16");

            driver.FindElement(By.Id("Operation")).SendKeys("/");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "-64");

            driver.Close();
        }

        [TestMethod]
        public void TestCase014()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("-5");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("-495");

            driver.FindElement(By.Id("Operation")).SendKeys("+");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "-500");

            driver.Close();
        }

        [TestMethod]
        public void TestCase015()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("-1025");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("-2500");

            driver.FindElement(By.Id("Operation")).SendKeys("-");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "1475");

            driver.Close();
        }

        [TestMethod]
        public void TestCase016()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("-51");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("-42");

            driver.FindElement(By.Id("Operation")).SendKeys("*");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "2142");

            driver.Close();
        }

        [TestMethod]
        public void TestCase017()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Url = "https://calculatorwebappdevops.azurewebsites.net/Calculator";

            driver.FindElement(By.Id("Number1")).Clear();
            driver.FindElement(By.Id("Number1")).SendKeys("-2048");

            driver.FindElement(By.Id("Number2")).Clear();
            driver.FindElement(By.Id("Number2")).SendKeys("-32");

            driver.FindElement(By.Id("Operation")).SendKeys("/");

            driver.FindElement(By.Id("CalculateBtn")).Click();

            string returnValue = driver.FindElement(By.Id("ResultValue")).Text;

            Assert.AreEqual(returnValue, "64");

            driver.Close();
        }
    }
}