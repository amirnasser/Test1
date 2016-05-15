﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static ReactTest.Controllers.AccountController Account = new ReactTest.Controllers.T4MVC_AccountController();
    public static ReactTest.Controllers.HomeController Home = new ReactTest.Controllers.T4MVC_HomeController();
    public static ReactTest.Controllers.ManageController Manage = new ReactTest.Controllers.T4MVC_ManageController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string bootstrap_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.css") ? Url("bootstrap.min.css") : Url("bootstrap.css");
        public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Fonts {
            private const string URLPATH = "~/Content/Fonts";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string glyphicons_halflings_regular_eot = Url("glyphicons-halflings-regular.eot");
            public static readonly string glyphicons_halflings_regular_svg = Url("glyphicons-halflings-regular.svg");
            public static readonly string glyphicons_halflings_regular_ttf = Url("glyphicons-halflings-regular.ttf");
            public static readonly string glyphicons_halflings_regular_woff = Url("glyphicons-halflings-regular.woff");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Images {
            private const string URLPATH = "~/Content/Images";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Scripts {
            private const string URLPATH = "~/Content/Scripts";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
            public static readonly string ai_0_15_0_build58334_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ai.0.15.0-build58334.min.js") ? Url("ai.0.15.0-build58334.min.js") : Url("ai.0.15.0-build58334.js");
            public static readonly string ai_0_15_0_build58334_min_js = Url("ai.0.15.0-build58334.min.js");
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class app {
                private const string URLPATH = "~/Content/Scripts/app";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string Demo1_jsx = Url("Demo1.jsx");
                public static readonly string Demo1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Demo1.min.js") ? Url("Demo1.min.js") : Url("Demo1.js");
                public static readonly string Demo1_min_js = Url("Demo1.min.js");
            }
        
            public static readonly string bootstrap_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/bootstrap.min.js") ? Url("bootstrap.min.js") : Url("bootstrap.js");
            public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
            public static readonly string jquery_1_10_2_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.10.2.intellisense.min.js") ? Url("jquery-1.10.2.intellisense.min.js") : Url("jquery-1.10.2.intellisense.js");
            public static readonly string jquery_1_10_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-1.10.2.min.js") ? Url("jquery-1.10.2.min.js") : Url("jquery-1.10.2.js");
            public static readonly string jquery_1_10_2_min_js = Url("jquery-1.10.2.min.js");
            public static readonly string jquery_1_10_2_min_map = Url("jquery-1.10.2.min.map");
            public static readonly string jquery_validate_vsdoc_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate-vsdoc.min.js") ? Url("jquery.validate-vsdoc.min.js") : Url("jquery.validate-vsdoc.js");
            public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
            public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
            public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
            public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
            public static readonly string modernizr_2_6_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/modernizr-2.6.2.min.js") ? Url("modernizr-2.6.2.min.js") : Url("modernizr-2.6.2.js");
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class react {
                private const string URLPATH = "~/Content/Scripts/react";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string react_dom_server_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/react-dom-server.min.js") ? Url("react-dom-server.min.js") : Url("react-dom-server.js");
                public static readonly string react_dom_server_min_js = Url("react-dom-server.min.js");
                public static readonly string react_dom_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/react-dom.min.js") ? Url("react-dom.min.js") : Url("react-dom.js");
                public static readonly string react_dom_min_js = Url("react-dom.min.js");
                public static readonly string react_with_addons_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/react-with-addons.min.js") ? Url("react-with-addons.min.js") : Url("react-with-addons.js");
                public static readonly string react_with_addons_min_js = Url("react-with-addons.min.js");
                public static readonly string react_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/react.min.js") ? Url("react.min.js") : Url("react.js");
                public static readonly string react_min_js = Url("react.min.js");
            }
        
            public static readonly string respond_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/respond.min.js") ? Url("respond.min.js") : Url("respond.js");
            public static readonly string respond_min_js = Url("respond.min.js");
        }
    
        public static readonly string Site_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Site.min.css") ? Url("Site.min.css") : Url("Site.css");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Stylesheets {
            private const string URLPATH = "~/Content/Stylesheets";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        }
    
    }

    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        public static partial class Content 
        {
            public static partial class Fonts 
            {
                public static class Assets
                {
                }
            }
            public static partial class Images 
            {
                public static class Assets
                {
                }
            }
            public static partial class Scripts 
            {
                public static partial class app 
                {
                    public static class Assets
                    {
                    }
                }
                public static partial class react 
                {
                    public static class Assets
                    {
                        public const string react_dom_server_js = "~/Content/Scripts/react/react-dom-server.js"; 
                        public const string react_dom_server_min_js = "~/Content/Scripts/react/react-dom-server.min.js"; 
                        public const string react_dom_js = "~/Content/Scripts/react/react-dom.js"; 
                        public const string react_dom_min_js = "~/Content/Scripts/react/react-dom.min.js"; 
                        public const string react_with_addons_js = "~/Content/Scripts/react/react-with-addons.js"; 
                        public const string react_with_addons_min_js = "~/Content/Scripts/react/react-with-addons.min.js"; 
                        public const string react_js = "~/Content/Scripts/react/react.js"; 
                        public const string react_min_js = "~/Content/Scripts/react/react.min.js"; 
                    }
                }
                public static class Assets
                {
                    public const string _references_js = "~/Content/Scripts/_references.js"; 
                    public const string ai_0_15_0_build58334_js = "~/Content/Scripts/ai.0.15.0-build58334.js"; 
                    public const string ai_0_15_0_build58334_min_js = "~/Content/Scripts/ai.0.15.0-build58334.min.js"; 
                    public const string bootstrap_js = "~/Content/Scripts/bootstrap.js"; 
                    public const string bootstrap_min_js = "~/Content/Scripts/bootstrap.min.js"; 
                    public const string jquery_1_10_2_intellisense_js = "~/Content/Scripts/jquery-1.10.2.intellisense.js"; 
                    public const string jquery_1_10_2_js = "~/Content/Scripts/jquery-1.10.2.js"; 
                    public const string jquery_1_10_2_min_js = "~/Content/Scripts/jquery-1.10.2.min.js"; 
                    public const string jquery_validate_js = "~/Content/Scripts/jquery.validate.js"; 
                    public const string jquery_validate_min_js = "~/Content/Scripts/jquery.validate.min.js"; 
                    public const string jquery_validate_unobtrusive_js = "~/Content/Scripts/jquery.validate.unobtrusive.js"; 
                    public const string jquery_validate_unobtrusive_min_js = "~/Content/Scripts/jquery.validate.unobtrusive.min.js"; 
                    public const string modernizr_2_6_2_js = "~/Content/Scripts/modernizr-2.6.2.js"; 
                    public const string respond_js = "~/Content/Scripts/respond.js"; 
                    public const string respond_min_js = "~/Content/Scripts/respond.min.js"; 
                }
            }
            public static partial class Stylesheets 
            {
                public static class Assets
                {
                }
            }
            public static class Assets
            {
                public const string bootstrap_css = "~/Content/bootstrap.css";
                public const string bootstrap_min_css = "~/Content/bootstrap.min.css";
                public const string Site_css = "~/Content/Site.css";
            }
        }
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114


