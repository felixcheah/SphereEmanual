using System.Web.Optimization;

namespace SphereEmanual
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/Scripts/app.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/modalform").Include(
                      "~/Scripts/modalform.js")); 
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/sb-admin.css",
                      "~/Content/carousel.css"));

            // Dropzone component
            bundles.Add(new ScriptBundle("~/bundles/dropzonescripts").Include(
                        "~/Scripts/dropzone/dropzone.min.js"));

            bundles.Add(new StyleBundle("~/Content/dropzonescss").Include(
                        "~/Scripts/dropzone/css/basic.css",
                        "~/Scripts/dropzone/css/dropzone.css"));

            // Chosen component
            bundles.Add(new ScriptBundle("~/bundles/chosenscripts").Include(
                        "~/Scripts/chosen_v1.4.2/chosen.jquery.js"));

            bundles.Add(new StyleBundle("~/Content/chosencss").Include(
                        "~/Scripts/chosen_v1.4.2/chosen.css"));

            // Listgroup component
            bundles.Add(new ScriptBundle("~/bundles/listgroupscripts").Include(
                        "~/Scripts/listgroup.js"));

            // Bootstrap datepicker
            bundles.Add(new ScriptBundle("~/bundles/datepickerscripts").Include(
                        "~/Scripts/bootstrap-datepicker.js"));
            bundles.Add(new StyleBundle("~/Content/datepickercss").Include(
                        "~/Content/bootstrap-datepicker.css"));

            // Bootstrap fileinput
            bundles.Add(new ScriptBundle("~/bundles/fileinputscripts").Include(
                        "~/Scripts/fileinput.js"));
            bundles.Add(new StyleBundle("~/Content/fileinputcss").Include(
                        "~/Content/fileinput.css"));

            // SweetAlert
            bundles.Add(new ScriptBundle("~/bundles/sweetalertscripts").Include(
                        "~/Scripts/sweetalert.min.js"));
            bundles.Add(new StyleBundle("~/Content/sweetalertcss").Include(
                        "~/Content/sweetalert.css"));

            // timeout dialog
            bundles.Add(new ScriptBundle("~/bundles/timeoutdialogscripts").Include(
                        "~/Scripts/timeout-dialog.js"));
            bundles.Add(new StyleBundle("~/Content/timeoutdialogcss").Include(
                        "~/Content/timeout-dialog.css"));

            // Jquery UI component
            bundles.Add(new ScriptBundle("~/bundles/jqueryuiscripts").Include(
                        "~/Scripts/jquery-ui-1.11.4/jquery-ui.min.js"));

            bundles.Add(new StyleBundle("~/Content/jqueryuicss").Include(
                        "~/Scripts/jquery-ui-1.11.4/jquery-ui.min.css"));

            // Boostrap Table
            bundles.Add(new ScriptBundle("~/bundles/bootstraptablescripts").Include(
                        "~/Scripts/bootstrap-table.js"));

            bundles.Add(new StyleBundle("~/Content/bootstraptablecss").Include(
                        "~/Content/bootstrap-table.css"));

            // Moment.js
            bundles.Add(new ScriptBundle("~/bundles/momentscripts").Include(
                        "~/Scripts/moment.js"));

            //Font Awesome 
            bundles.Add(new StyleBundle("~/Content/fontawesomecss").Include(
                        "~/Content/font-awesome-4.4.0/font-awesome.min.css"));
        }
    }
}
