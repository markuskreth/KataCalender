using DojoCalender;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{


    /// <summary>
    ///Dies ist eine Testklasse für "MonatDataTest" und soll
    ///alle MonatDataTest Komponententests enthalten.
    ///</summary>
    [TestClass()]
    public class MonatDataTest
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
        ///Ein Test für "MonatData-Konstruktor"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DojoCalender.exe")]
        public void TestMonatDataConstructor()
        {
            short monat = 1;
            short jahr = 2014;
            MonatData_Accessor target = new MonatData_Accessor(monat, jahr);

        }

        /// <summary>
        ///Ein Test für "Tage"
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DojoCalender.exe")]
        public void TestTage()
        {
            MonatData_Accessor target = new MonatData_Accessor(1, 2014);
            Assert.AreEqual(31, target.Tage.Count);
            target = new MonatData_Accessor(2, 2014);
            Assert.AreEqual(28, target.Tage.Count);

        }

    }
}
