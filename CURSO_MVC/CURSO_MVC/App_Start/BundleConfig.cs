using System.Web;
using System.Web.Optimization;

namespace CURSO_MVC
{
    public class BundleConfig
    {
        /* AQUI TENEMOS TODO LO REFERENTE A LAS HOJAS DE ESTILO CSS IMPLEMENTADO EN NUESTRO PROYECTO */
        /* COMO ELEMENTOS QUE VIENEN SIENDO JAVASCRIPT LO PODEMOS VER EN SU TERMINACION */
        /* COMO ELEMENTOS JQUERY */

        #region TODO LO REFERENTE A HOJAS DE ESTILO CSS Y ELEMENTOS JS Y QUERY

        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        } 
        #endregion


    }
}
