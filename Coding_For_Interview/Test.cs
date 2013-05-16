//namespace StarNet
//{
//    using NUnit.Framework;

//    [TestFixture]
//    public class CamelCaseTests
//    {
//        [Test]
//        public void TestOne()
//        {
//            string input = "CamelCaseString";
//            string output = "camel-case-string";

//            CamelCaseClass camel = new CamelCaseClass();
//            string convertedString = camel.ConvertString(input);

//            Assert.AreEqual(output, convertedString);
//        }

//        [Test]
//        public void TestTwo()
//        {
//            string input = "anotherCamelCaseZing";
//            string output = "another-camel-case-zing";

//            CamelCaseClass camel = new CamelCaseClass();
//            string convertedString = camel.ConvertString(input);

//            Assert.AreEqual(output, convertedString);
//        }

//    }

//    [TestFixture]
//    public class CreditCardSurchargeTests
//    {
//        [Test]
//        public void TestOne()
//        {
//            Surcharger surcharger = new Surcharger();
//            decimal surcharge = surcharger.GetSurcharge("MasterCard", 3.50m);

//            Assert.AreEqual(0.042m, surcharge);
//        }

//        [Test]
//        public void TestTwo()
//        {
//            Surcharger surcharger = new Surcharger();
//            decimal surcharge = surcharger.GetSurcharge("Visa", 10.00m);

//            Assert.AreEqual(0.1m, surcharge);
//        }

//        [Test]
//        public void TestThree()
//        {
//            Surcharger surcharger = new Surcharger();
//            decimal surcharge = surcharger.GetSurcharge("Amex", 10.00m);

//            Assert.AreEqual(0.31m, surcharge);
//        }

//        [Test]
//        public void TestFour()
//        {
//            Surcharger surcharger = new Surcharger();
//            decimal surcharge = surcharger.GetSurcharge("", 999.00m);

//            Assert.AreEqual(0.4m, surcharge);
//        }

//    }

//}
