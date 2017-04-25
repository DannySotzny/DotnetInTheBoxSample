namespace FP.DotnetInTheBox.Sample.WebApp
{
    public class HomeModule : Nancy.NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Hallo DNUG Leipzig");
        }
    }
}
