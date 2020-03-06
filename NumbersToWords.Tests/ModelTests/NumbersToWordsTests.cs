using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;

 namespace NumbersToWords.Test
 {
    [TestClass]
    public class NumbersToWordsTests
    {
        [TestMethod]
        public void WordNumber_10_ReturnTen()
        {
            Number testNumber = new Number(10);
            Assert.AreEqual("ten", testNumber.WordNumber());
        }
        [TestMethod]
        public void WordNumber_99_ReturnNinetyNine()
        {
            Number testNumber = new Number(99);
            Assert.AreEqual("ninety nine", testNumber.WordNumber());
        }
        [TestMethod]
        public void WordNumber_999_ReturnNineHundredAndNinetyNine()
        {
            Number testNumber = new Number(999);
            Assert.AreEqual("nine hundred ninety nine", testNumber.WordNumber());
        }

        // [TestMethod]
        // public void WordNumber_1568_ReturnOneThousandFiveHundredSixtyEight()
        // {
        //     Number testNumber = new Number(1568);
        //     Assert.AreEqual("one thousand five hundred sixty eight", testNumber.WordNumber());
        // }

        // [TestMethod]
        // public void WordNumber_13345_ReturnThirteenThousandThreeHundredFortyFive()
        // {
        //     Number testNumber = new Number(13345);
        //     Assert.AreEqual("thirteen thousand three hundred fourty five", testNumber.WordNumber());
        // }
        // [TestMethod]
        // public void WordNumber_515000_ReturnThirteenThousandThreeHundredFortyFive()
        // {
        //     Number testNumber = new Number(51000);
        //     Assert.AreEqual("one thousand five hundred sixty eight", testNumber.WordNumber());
        // }
        // [TestMethod]
        // public void NumberToWords_Test5_ReturnFive()
        // {
        // Assert.AreEqual("five", Number.NumberToWords(5));
        // }
        // [TestMethod]
        // public void NumberToWords_Test15_ReturnFifteen()
        // {
        // Assert.AreEqual("fifteen", Number.NumberToWords(15));
        // }
        // [TestMethod]
        // public void NumberToWords_Test45_ReturnFortyfive()
        // {
        // Assert.AreEqual("forty five", Number.NumberToWords(45));
        // }
        // [TestMethod]
        // public void NumberToWords_Test455_ReturnFourHundredAndFiftyFive()
        // {
        // Assert.AreEqual("four hundred and fifty five", Number.NumberToWords(455));
        // }
        // [TestMethod]
        // public void NumberToWords_Test4555_ReturnFourThousandFourHundredAndFiftyFive()
        // {
        // Assert.AreEqual("four thousand four hundred and fifty five", Number.NumberToWords(4455));
        // }
        // [TestMethod]
        // public void NumberToWords_Test44555_ReturnFortyFourThousandFourHundredAndFiftyFive()
        // {
        // Assert.AreEqual("forty four thousand four hundred and fifty five", Number.NumberToWords(44455));
        // }
        // [TestMethod]
        // public void NumberToWords_Test444555_ReturnFourHundredFortyFourThousandFourHundredAndFiftyFive()
        // {
        // Assert.AreEqual("four hundred and forty four thousand four hundred and fifty five", Number.NumberToWords(444455));
        // }
        // [TestMethod]
        // public void NumberToWords_Test5444555_ReturnFiveMillionAndFourHundredFortyFourThousandFourHundredAndFiftyFive()
        // {
        // Assert.AreEqual("five million four hundred and forty four thousand four hundred and fifty five", Number.NumberToWords(5444455));
        // }
        // [TestMethod]
        // public void NumberToWords_Test55444555_ReturnFiftyFiveMillionAndFourHundredFortyFourThousandFourHundredAndFiftyFive()
        // {
        // Assert.AreEqual("fifty five million four hundred and forty four thousand four hundred and fifty five", Number.NumberToWords(55444455));
        // }
        // [TestMethod]
        // public void NumberToWords_Test555444555_ReturnFiveHundredFiftyFiveMillionAndFourHundredFortyFourThousandFourHundredAndFiftyFive()
        // {
        // Assert.AreEqual("five hundred and fifty five million four hundred and forty four thousand four hundred and fifty five", Number.NumberToWords(555444455));
        // }
        // [TestMethod]
        // public void NumberToWords_Test4555444555_ReturnFourBillionAndFiveHundredFiftyFiveMillionAndFourHundredFortyFourThousandFourHundredAndFiftyFive()
        // {
        // Assert.AreEqual("four billion five hundred and fifty five million four hundred and forty four thousand four hundred and fifty five", Number.NumberToWords(4555444455));
        // }
        // [TestMethod]
        // public void NumberToWords_Test44555444555_ReturnFortyFourBillionAndFiveHundredFiftyFiveMillionAndFourHundredFortyFourThousandFourHundredAndFiftyFive()
        // {
        // Assert.AreEqual("forty four billion five hundred and fifty five million four hundred and forty four thousand four hundred and fifty five", Number.NumberToWords(44555444455));
        // }
        // [TestMethod]
        // public void NumberToWords_Test444555444555_ReturnFourHundredFortyFourBillionAndFiveHundredFiftyFiveMillionAndFourHundredFortyFourThousandFourHundredAndFiftyFive()
        // {
        // Assert.AreEqual("four hundred and forty four billion five hundred and fifty five million four hundred and forty four thousand four hundred and fifty five", Number.NumberToWords(444555444455));
        // }

        // [TestMethod]
        // public void NumberToWords_Test5444555444555_ReturnFiveTrillionFourHundredFortyFourBillionAndFiveHundredFiftyFiveMillionAndFourHundredFortyFourThousandFourHundredAndFiftyFive()
        // {
        // Assert.AreEqual("five tillion four hundred and forty four billion five hundred and fifty five million four hundred and forty four thousand four hundred and fifty five", Number.NumberToWords(5444555444455));
        // }


    }
 }