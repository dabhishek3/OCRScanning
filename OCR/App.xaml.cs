using OCR.Export.Excel;
using OCR.Export.Json;
using OCR.Export.Text;
using OCR.ScanPreview;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace OCR
{
    public partial class App: PrismApplication
    {
        public App() : this(null) { }

        public static string Title = "testdetector";

        public static double ScreenWidth =>
            DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density;
        public static double ScreenHeight =>
            DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density;

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }


        //protected override void RegisterType(IContainerRegistry containerRegistry)
        //{
        //    containerRegistry.RegisterForNavigation<NavigationPage>();
        //    containerRegistry.RegisterForNavigation<MainPage>();
        //    containerRegistry.RegisterForNavigation<ScanPreviewPage>();

        //    containerRegistry.RegisterSingleton<CurrentImageService>();
        //    containerRegistry.RegisterSingleton<TextExportService>();
        //    containerRegistry.RegisterSingleton<JsonExportService>();
        //    containerRegistry.RegisterSingleton<ExcelExportService>();
        //}

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync($"/{nameof(NavigationPage)}/{nameof(MainPage)}");
        }

        protected override void OnResume()
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<ScanPreviewPage>();

            containerRegistry.RegisterSingleton<CurrentImageService>();
            containerRegistry.RegisterSingleton<TextExportService>();
            containerRegistry.RegisterSingleton<JsonExportService>();
            containerRegistry.RegisterSingleton<ExcelExportService>();
        }
    }
}
