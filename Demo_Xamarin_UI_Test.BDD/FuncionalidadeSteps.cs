using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace Demo_Xamarin_UI_Test.BDD
{
    [Binding]
    public class FuncionalidadeSteps
    {
        AndroidApp app;
        static readonly Func<AppQuery, AppQuery> valorUm = c => c.Marked("txtValor1");
        static readonly Func<AppQuery, AppQuery> valorDois = c => c.Marked("txtValor2");
        static readonly Func<AppQuery, AppQuery> btn = c => c.Marked("btnSomar");
        static readonly Func<AppQuery, AppQuery> resultado = c => c.Marked("lblResult");

        public FuncionalidadeSteps()
        {
            app = ConfigureApp
                .Android
                .ApkFile(@"C:\Users\omehe\Desktop\Calculadora.apk")
                //.DeviceSerial("emulator-5554")
                .StartApp();
        }
        //[BeforeFeature]
        //public static void BeforeEachTest()
        //{
            
        //}

        [Given(@"Que eu entro com o numero ""(.*)"" na calculadora")]
        public void DadoQueEuEntroComONumeroNaCalculadora(int valorUmEntrada)
        {
            app.EnterText(valorUm, valorUmEntrada.ToString());
        }
        
        [Given(@"Também entro com o numero ""(.*)"" na calculadora")]
        public void DadoTambemEntroComONumeroNaCalculadora(int valorDoisEntrada)
        {
            app.EnterText(valorDois, valorDoisEntrada.ToString());
        }
        
        [When(@"Eu dar um tap no botão Calcular")]
        public void QuandoEuDarUmTapNoBotaoCalcular()
        {
            app.Tap(btn);
        }
        
        [Then(@"O resultado deve ser ""(.*)""")]
        public void EntaoOResultadoDeveSer(int resultadoEsperado)
        {
            AppResult[] result = app.Query(resultado);

            Assert.AreEqual(resultadoEsperado.ToString(), result[0].Text);
        }
    }
}
