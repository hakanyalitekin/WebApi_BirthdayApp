using System.Web.Http;

namespace BirthdayApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}", //{action} -> sonradan eklendi. ikitane post kullanmak istediğimiz için. (katılanlar ve katılmayanlar)
                defaults: new { id = RouteParameter.Optional }
            );
            config.Formatters.Remove(config.Formatters.XmlFormatter); //XML formatını JSON'a çeviriyor.
        }
    }
}
