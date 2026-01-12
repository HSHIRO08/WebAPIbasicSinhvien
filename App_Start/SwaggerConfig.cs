using System.Web.Http;
using Quanlysinhvien;

// [assembly: WebActivatorEx.PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Quanlysinhvien
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // UNCOMMENT THE FOLLOWING LINES AFTER INSTALLING SWASHBUCKLE NUGET PACKAGE
            // Swashbuckle.Bootstrapper.Init(config);
            
            /*
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            config
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "Quanlysinhvien");
                        c.IncludeXmlComments(GetXmlCommentsPath());
                    })
                .EnableSwaggerUi(c =>
                    {
                    });
            */
        }

        private static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}\bin\Quanlysinhvien.xml", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}