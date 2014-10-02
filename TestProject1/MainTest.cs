using DojoCalender;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{


    /// <summary>
    ///Dies ist eine Testklasse für "MainTest" und soll
    ///alle MainTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class MainTest
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
        ///Ein Test für "Parse"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DojoCalender.exe")]
        public void TestParse()
        {
            string[] args = { "1", "2014" };
            Main_Accessor actual;
            actual = Main_Accessor.Parse(args);
            Assert.AreEqual(1, actual.Month);
            Assert.AreEqual(2014, actual.Year);

        }
        /// <summary>
        ///Ein Test für "Parse"  mit nur dem Jahr als Parameter
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DojoCalender.exe")]
        public void TestParseYearOnly()
        {
            string[] args = { "2014" };
            Main_Accessor actual;
            actual = Main_Accessor.Parse(args);
            Assert.AreEqual(0, actual.Month);
            Assert.AreEqual(2014, actual.Year);

        }
    }
}
