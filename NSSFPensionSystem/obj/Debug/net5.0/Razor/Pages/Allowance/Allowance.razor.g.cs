#pragma checksum "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27cb12dadba003a7e8d5615e28e80a23991cb54c"
// <auto-generated/>
#pragma warning disable 1591
namespace NSSFPensionSystem.Pages.Allowance
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Shared.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Services.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Setting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\_Imports.razor"
using Blazor.AdminLte;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/allowance/new")]
    public partial class Allowance : AllowanceBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<NSSFPensionSystem.Shared.Components.Forms.FormHeader>(0);
            __builder.AddAttribute(1, "Icon", "fa-solid fa-file-signature");
            __builder.AddAttribute(2, "Title", "????????????????????????????????????????????????");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "content mx-3 mb-5 pb-4");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container-fluid");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-header");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "form-row justify-content-end");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "id", "btnrefresh");
            __builder.AddAttribute(16, "class", "btn btn-info");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                               OnRefresh

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "<i class=\"fa-solid fa-arrows-rotate\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card-body p-0");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table table-bordered table-striped table-hover");
            __builder.OpenElement(24, "thead");
            __builder.OpenElement(25, "tr");
#nullable restore
#line 19 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                 foreach (string name in TableHeader)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "th");
            __builder.AddAttribute(27, "class", "text-center");
            __builder.AddContent(28, 
#nullable restore
#line 21 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                             name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 22 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "tbody");
#nullable restore
#line 26 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                             if (AllowanceReviews.Count == 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "tr");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "colspan", 
#nullable restore
#line 28 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                  TableHeader.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "class", "text-center");
            __builder.AddMarkupContent(35, "?????????????????????????????????????????????????????????????????????!");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                 foreach (var Allowance in AllowanceReviews)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "tr");
            __builder.OpenElement(37, "td");
            __builder.AddAttribute(38, "class", "text-center");
            __builder.AddContent(39, 
#nullable restore
#line 35 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                  AllowanceReviews.IndexOf(Allowance) + 1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                                        ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "class", "text-center");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "class", "btn btn-sm btn-info");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                                          () => OnNavigateToClaim(Allowance.GUID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, 
#nullable restore
#line 38 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                 Allowance.ClaCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                        ");
            __builder.OpenElement(48, "td");
            __builder.AddAttribute(49, "class", "text-center");
            __builder.AddContent(50, 
#nullable restore
#line 41 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                 Allowance.PsTypeNameKh

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                                        ");
            __builder.OpenElement(52, "td");
            __builder.AddAttribute(53, "class", "text-center");
            __builder.AddContent(54, 
#nullable restore
#line 42 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                  Allowance.BenNote + "-"+ @Allowance.BenId + "-" + Allowance.BenChar

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                        ");
            __builder.OpenElement(56, "td");
            __builder.AddAttribute(57, "class", "text-center");
            __builder.AddContent(58, 
#nullable restore
#line 43 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                 Allowance.FullnameKh

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                                        ");
            __builder.OpenElement(60, "td");
            __builder.AddAttribute(61, "class", "text-center");
            __builder.AddContent(62, 
#nullable restore
#line 44 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                   Allowance.SexId=="1" ? "???????????????" : "????????????" 

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                        ");
            __builder.OpenElement(64, "td");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "d-flex justify-content-between");
            __builder.AddMarkupContent(67, "<span class=\"mb-1\">-??????????????????</span>\r\n                                                ");
            __builder.OpenElement(68, "div");
            __builder.OpenElement(69, "span");
            __builder.AddAttribute(70, "class", "text-bold");
            __builder.AddContent(71, 
#nullable restore
#line 49 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                              Allowance.NumConYear * 12 + Allowance.NumConMonth

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                                                    ");
            __builder.OpenElement(73, "span");
            __builder.AddAttribute(74, "class", "sub");
            __builder.AddContent(75, 
#nullable restore
#line 50 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                        "?????? (" + Allowance.NumConYear + "??????????????? " + Allowance.NumConMonth + "??????)"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                                            ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "d-flex justify-content-between");
            __builder.AddMarkupContent(79, "<span class=\"mb-1\">-??????</span>\r\n                                                ");
            __builder.OpenElement(80, "div");
            __builder.OpenElement(81, "span");
            __builder.AddAttribute(82, "class", "text-bold");
            __builder.AddContent(83, 
#nullable restore
#line 56 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                              (Allowance.PsRate * 100).ToString("N2")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                                                    ");
            __builder.AddMarkupContent(85, "<span class=\"sub\">%</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                                            ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "d-flex justify-content-between");
            __builder.AddMarkupContent(89, "<span class=\"mb-1\">-?????????</span>\r\n                                                ");
            __builder.OpenElement(90, "div");
            __builder.OpenElement(91, "span");
            __builder.AddAttribute(92, "class", "bold-text");
            __builder.AddAttribute(93, "style", "font-weight: bold;");
            __builder.AddContent(94, 
#nullable restore
#line 63 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                                                        Allowance.AvgAssumeWage.ToString("N0")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                                                    ");
            __builder.AddMarkupContent(96, "<span class=\"sub\">???</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                                        ");
            __builder.OpenElement(98, "td");
#nullable restore
#line 69 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                             foreach (var detail in Allowance.Details.Select(s => new { s.IntId, s.IntName }).Distinct())
                                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "mb-2");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "row");
            __builder.OpenElement(103, "span");
            __builder.AddAttribute(104, "class", "bold-text");
            __builder.AddContent(105, 
#nullable restore
#line 73 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                                 detail.IntName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                     foreach (var alw in Allowance.Details.Where(w => w.IntId == detail.IntId))
                                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "row");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "col-md-6 offset-md-1");
            __builder.OpenElement(110, "span");
            __builder.AddAttribute(111, "class", "sub");
            __builder.AddContent(112, 
#nullable restore
#line 79 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                                    "- " + alw.AlwTypeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 80 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                 if (alw.IntId == 1)
                                                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(113, "span");
            __builder.AddAttribute(114, "class", "sub");
            __builder.AddContent(115, 
#nullable restore
#line 82 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                                        "(" + alw.ExtraDay + "????????????)"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 83 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                                                            ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "col-md-5");
            __builder.OpenElement(119, "span");
            __builder.AddAttribute(120, "class", "bold-text");
            __builder.AddContent(121, 
#nullable restore
#line 86 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                                         alw.PensionAmount.ToString("N0")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n                                                                ");
            __builder.AddMarkupContent(123, "<span class=\"sub\">???</span>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 90 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 92 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                                        ");
            __builder.OpenElement(125, "td");
            __builder.AddAttribute(126, "class", "text-center");
            __builder.OpenElement(127, "button");
            __builder.AddAttribute(128, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(129, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                                            () => OnRemoveClick(Allowance.ClaId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(130, "<i class=\"fa-solid fa-trash-can\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 100 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                 }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                ");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "card-footer");
            __builder.OpenElement(134, "div");
            __builder.AddAttribute(135, "class", "text-right");
            __builder.OpenElement(136, "button");
            __builder.AddAttribute(137, "id", "multiple-reset");
            __builder.AddAttribute(138, "class", "btn btn-info");
            __builder.AddAttribute(139, "disabled", 
#nullable restore
#line 106 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                                     AllowanceReviews.Count==0

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(140, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 106 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                                                                                                                           OnSave

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(141, "<i class=\"fa-solid fa-pen-to-square\"></i>\r\n                            ???????????????\r\n                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n\r\n\r\n    ");
            __builder.OpenComponent<NSSFPensionSystem.Shared.Components.Message>(143);
            __builder.AddComponentReferenceCapture(144, (__value) => {
#nullable restore
#line 117 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                   MessageBox = (NSSFPensionSystem.Shared.Components.Message)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(145, "\r\n    ");
            __builder.OpenComponent<NSSFPensionSystem.Shared.Components.Loading>(146);
            __builder.AddComponentReferenceCapture(147, (__value) => {
#nullable restore
#line 118 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Allowance\Allowance.razor"
                   Loading = (NSSFPensionSystem.Shared.Components.Loading)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
