using System.IO;
using System.Text;
using DojoCalender;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{


    /// <summary>
    ///Dies ist eine Testklasse für "ConsoleOutputTest" und soll
    ///alle ConsoleOutputTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class StreamOutputTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Ruft den Testkontext auf, der Informationen
        ///über und Funktionalität für den aktuellen Testlauf bietet, oder legt diesen fest.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Zusätzliche Testattribute
        // 
        //Sie können beim Verfassen Ihrer Tests die folgenden zusätzlichen Attribute verwenden:
        //
        //Mit ClassInitialize führen Sie Code aus, bevor Sie den ersten Test in der Klasse ausführen.
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Mit ClassCleanup führen Sie Code aus, nachdem alle Tests in einer Klasse ausgeführt wurden.
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Mit TestInitialize können Sie vor jedem einzelnen Test Code ausführen.
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Mit TestCleanup können Sie nach jedem einzelnen Test Code ausführen.
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Ein Test für "show"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DojoCalender.exe")]
        public void Testshow()
        {
            MemoryStream stream = new MemoryStream();

            StreamOutput_Accessor target = new StreamOutput_Accessor(stream);

            MonatData_Accessor data = new MonatData_Accessor(1, 2014);
            target.show(data);

            string result = Encoding.UTF8.GetString(stream.ToArray());

            Assert.AreEqual(JANUAR2014, result);

            stream = new MemoryStream();

            target = new StreamOutput_Accessor(stream);

            data = new MonatData_Accessor(9, 2014);
            target.show(data);

            result = Encoding.UTF8.GetString(stream.ToArray());

            Assert.AreEqual(SEPTEMBER2014, result);

            stream = new MemoryStream();

            target = new StreamOutput_Accessor(stream);

            data = new MonatData_Accessor(6, 2014);
            target.show(data);

            result = Encoding.UTF8.GetString(stream.ToArray());

            Assert.AreEqual(JUNE2014, result);

            stream = new MemoryStream();

            target = new StreamOutput_Accessor(stream);

            data = new MonatData_Accessor(3, 2014);
            target.show(data);

            result = Encoding.UTF8.GetString(stream.ToArray());

            Assert.AreEqual(MARCH2014, result);
        }

        private static string JANUAR2014 =
            "    Januar 2014\r\n" +
            "So Mo Di Mi Do Fr Sa\r\n" +
            "         01 02 03 04 \r\n" +
            "05 06 07 08 09 10 11 \r\n" +
            "12 13 14 15 16 17 18 \r\n" +
            "19 20 21 22 23 24 25 \r\n" +
            "26 27 28 29 30 31 \r\n";

        private static string SEPTEMBER2014 =
            "   September 2014\r\n" +
            "So Mo Di Mi Do Fr Sa\r\n" +
            "   01 02 03 04 05 06 \r\n" +
            "07 08 09 10 11 12 13 \r\n" +
            "14 15 16 17 18 19 20 \r\n" +
            "21 22 23 24 25 26 27 \r\n" +
            "28 29 30 \r\n";

        private static string JUNE2014 =
            "     Juni 2014\r\n" +
            "So Mo Di Mi Do Fr Sa\r\n" +
            "01 02 03 04 05 06 07 \r\n" +
            "08 09 10 11 12 13 14 \r\n" +
            "15 16 17 18 19 20 21 \r\n" +
            "22 23 24 25 26 27 28 \r\n" +
            "29 30 \r\n";

        private static string MARCH2014 =
            "     März 2014\r\n" +
            "So Mo Di Mi Do Fr Sa\r\n" +
            "                  01 \r\n" +
            "02 03 04 05 06 07 08 \r\n" +
            "09 10 11 12 13 14 15 \r\n" +
            "16 17 18 19 20 21 22 \r\n" +
            "23 24 25 26 27 28 29 \r\n" +
            "30 31 \r\n";
    }
}
