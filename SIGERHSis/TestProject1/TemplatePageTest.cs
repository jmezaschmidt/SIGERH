using SIGERHSis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for TemplatePageTest and is intended
    ///to contain all TemplatePageTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TemplatePageTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for TemplatePage Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Mau\\Documents\\GitHub\\SIGERH\\SIGERHSis\\SIGERHSis", "/")]
        [UrlToTest("http://localhost:1491/")]
        public void TemplatePageConstructorTest()
        {
            TemplatePage target = new TemplatePage();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Page_Load
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Mau\\Documents\\GitHub\\SIGERH\\SIGERHSis\\SIGERHSis", "/")]
        [UrlToTest("http://localhost:1491/")]
        [DeploymentItem("SIGERHSis.dll")]
        public void Page_LoadTest()
        {
            TemplatePage_Accessor target = new TemplatePage_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.Page_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for botonExpediente0_Click
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Mau\\Documents\\GitHub\\SIGERH\\SIGERHSis\\SIGERHSis", "/")]
        [UrlToTest("http://localhost:1491/")]
        [DeploymentItem("SIGERHSis.dll")]
        public void botonExpediente0_ClickTest()
        {
            TemplatePage_Accessor target = new TemplatePage_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.botonExpediente0_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for botonExpediente1_Click
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Mau\\Documents\\GitHub\\SIGERH\\SIGERHSis\\SIGERHSis", "/")]
        [UrlToTest("http://localhost:1491/")]
        [DeploymentItem("SIGERHSis.dll")]
        public void botonExpediente1_ClickTest()
        {
            TemplatePage_Accessor target = new TemplatePage_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.botonExpediente1_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for botonExpediente2_Click
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Mau\\Documents\\GitHub\\SIGERH\\SIGERHSis\\SIGERHSis", "/")]
        [UrlToTest("http://localhost:1491/")]
        [DeploymentItem("SIGERHSis.dll")]
        public void botonExpediente2_ClickTest()
        {
            TemplatePage_Accessor target = new TemplatePage_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.botonExpediente2_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for botonExpediente3_Click
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Mau\\Documents\\GitHub\\SIGERH\\SIGERHSis\\SIGERHSis", "/")]
        [UrlToTest("http://localhost:1491/")]
        [DeploymentItem("SIGERHSis.dll")]
        public void botonExpediente3_ClickTest()
        {
            TemplatePage_Accessor target = new TemplatePage_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.botonExpediente3_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for botonExpediente4_Click
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Mau\\Documents\\GitHub\\SIGERH\\SIGERHSis\\SIGERHSis", "/")]
        [UrlToTest("http://localhost:1491/")]
        [DeploymentItem("SIGERHSis.dll")]
        public void botonExpediente4_ClickTest()
        {
            TemplatePage_Accessor target = new TemplatePage_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.botonExpediente4_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for botonExpediente5_Click
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Mau\\Documents\\GitHub\\SIGERH\\SIGERHSis\\SIGERHSis", "/")]
        [UrlToTest("http://localhost:1491/")]
        [DeploymentItem("SIGERHSis.dll")]
        public void botonExpediente5_ClickTest()
        {
            TemplatePage_Accessor target = new TemplatePage_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.botonExpediente5_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for botonExpediente5_Click1
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Mau\\Documents\\GitHub\\SIGERH\\SIGERHSis\\SIGERHSis", "/")]
        [UrlToTest("http://localhost:1491/")]
        [DeploymentItem("SIGERHSis.dll")]
        public void botonExpediente5_Click1Test()
        {
            TemplatePage_Accessor target = new TemplatePage_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.botonExpediente5_Click1(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for botonExpediente6_Click
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Mau\\Documents\\GitHub\\SIGERH\\SIGERHSis\\SIGERHSis", "/")]
        [UrlToTest("http://localhost:1491/")]
        [DeploymentItem("SIGERHSis.dll")]
        public void botonExpediente6_ClickTest()
        {
            TemplatePage_Accessor target = new TemplatePage_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.botonExpediente6_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for botonExpediente6_Click1
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Mau\\Documents\\GitHub\\SIGERH\\SIGERHSis\\SIGERHSis", "/")]
        [UrlToTest("http://localhost:1491/")]
        [DeploymentItem("SIGERHSis.dll")]
        public void botonExpediente6_Click1Test()
        {
            TemplatePage_Accessor target = new TemplatePage_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.botonExpediente6_Click1(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for botonExpediente7_Click
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Mau\\Documents\\GitHub\\SIGERH\\SIGERHSis\\SIGERHSis", "/")]
        [UrlToTest("http://localhost:1491/")]
        [DeploymentItem("SIGERHSis.dll")]
        public void botonExpediente7_ClickTest()
        {
            TemplatePage_Accessor target = new TemplatePage_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.botonExpediente7_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for botonExpediente_Click
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Mau\\Documents\\GitHub\\SIGERH\\SIGERHSis\\SIGERHSis", "/")]
        [UrlToTest("http://localhost:1491/")]
        [DeploymentItem("SIGERHSis.dll")]
        public void botonExpediente_ClickTest()
        {
            TemplatePage_Accessor target = new TemplatePage_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.botonExpediente_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
