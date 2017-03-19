namespace FP.DotnetInTheBox.Sample.WebApp
{
    public class HomeModule : Nancy.NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Hallo Spartakiade 2017 - Sport frei");
        }
    }
}
