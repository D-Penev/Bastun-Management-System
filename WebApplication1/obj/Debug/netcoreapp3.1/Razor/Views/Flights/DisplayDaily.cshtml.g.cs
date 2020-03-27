#pragma checksum "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Flights\DisplayDaily.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81475f456d49be4c7530330c744a1b107595d7d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flights_DisplayDaily), @"mvc.1.0.view", @"/Views/Flights/DisplayDaily.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Flights\DisplayDaily.cshtml"
using BMS.Models.ViewModels.Flights;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81475f456d49be4c7530330c744a1b107595d7d8", @"/Views/Flights/DisplayDaily.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Flights_DisplayDaily : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlightViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Flights\DisplayDaily.cshtml"
  
    ViewData["Title"] = "Daily";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"    <div class=""col"">
        <h1 class=""text-center"">Daily aircraft movements:</h1>
        <br />
        <table class=""table table-bordered table-hover text-center"" id=""dailyMovements"" >
            <thead class=""thead-dark "">
                <tr>
                    <th scope=""col"">Flight Number</th>
                    <th scope=""col"">A/C Registration</th>
                    <th scope=""col"">A/C Type</th>
                    <th scope=""col"">Origin</th>
                    <th scope=""col"">Destination</th>
                    <th scope=""col"">STA</th>
                    <th scope=""col"">STD</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 23 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Flights\DisplayDaily.cshtml"
                  foreach (var flight in Model.Flights)
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <tr>\r\n                         <td>");
#nullable restore
#line 26 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Flights\DisplayDaily.cshtml"
                        Write(flight.FlightNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                         <td>");
#nullable restore
#line 27 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Flights\DisplayDaily.cshtml"
                        Write(flight.AircraftRegistration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                         <td>");
#nullable restore
#line 28 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Flights\DisplayDaily.cshtml"
                        Write(flight.ACType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                         <td>");
#nullable restore
#line 29 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Flights\DisplayDaily.cshtml"
                        Write(flight.Origin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                         <td>");
#nullable restore
#line 30 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Flights\DisplayDaily.cshtml"
                        Write(flight.Destination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                         <td>");
#nullable restore
#line 31 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Flights\DisplayDaily.cshtml"
                        Write(flight.STA);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                         <td>");
#nullable restore
#line 32 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Flights\DisplayDaily.cshtml"
                        Write(flight.STD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                     </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Mitko\source\repos\DMOME\BMS\WebApplication1\Views\Flights\DisplayDaily.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlightViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591