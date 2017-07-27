using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Demo_Xamarin_UI_Test.XamarinForms
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        static readonly Func<AppQuery, AppQuery> valorUm = c => c.Marked("txtvalorUm");
        static readonly Func<AppQuery, AppQuery> valorDois = c => c.Marked("txtvalorDois");
        static readonly Func<AppQuery, AppQuery> btn = c => c.Marked("btnSomar");
        static readonly Func<AppQuery, AppQuery> resultado = c => c.Marked("lblResult");

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.EnterText(valorUm, "10");
            app.EnterText(valorDois, "15");

            app.Tap(btn);
            AppResult[] result = app.Query(resultado);

            Assert.AreEqual("25", result[0].Text);
        }
    }
}

