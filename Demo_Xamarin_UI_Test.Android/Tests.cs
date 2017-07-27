using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace Demo_Xamarin_UI_Test.Android
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;
        static readonly Func<AppQuery, AppQuery> valorUm = c => c.Marked("txtValor1");
        static readonly Func<AppQuery, AppQuery> valorDois = c => c.Marked("txtValor2");
        static readonly Func<AppQuery, AppQuery> btn = c => c.Marked("btnSomar");
        static readonly Func<AppQuery, AppQuery> resultado = c => c.Marked("lblResult");

        [SetUp]
        public void BeforeEachTest()
        {
            app = ConfigureApp
                .Android
                .ApkFile(@"C:\Users\omehe\Desktop\Calculadora.apk")
                .DeviceSerial("emulator-5554")
                .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            app.EnterText(valorUm, "10");
            app.EnterText(valorDois, "10");

            app.Tap(btn);
            AppResult[] result = app.Query(resultado);

            Assert.AreEqual("20", result[0].Text);
        }
    }
}

