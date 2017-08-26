using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Demo_Xamarin_UI_Test.XamarinForms
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    //.ApkFile(@"C:\Projetos\Demo_TDC_XF\Demo_TDC_XF.APP\Demo_TDC_XF.APP.Android\bin\Release\Demo_TDC_XF.APP.Android.apk")
                    .InstalledApp("Demo_Xamarin_UI_Test.App.Android")
                    //.DeviceSerial("emulator-5554") //Utilizar sempre que tiver mais de um device conectado para informar qual quer utilizar.
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

