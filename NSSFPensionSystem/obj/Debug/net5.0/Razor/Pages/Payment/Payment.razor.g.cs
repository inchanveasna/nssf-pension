#pragma checksum "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d4b59315d6ef5fb39bf5f84e2cc775e48f6bd13"
// <auto-generated/>
#pragma warning disable 1591
namespace NSSFPensionSystem.Pages.Payment
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/payments/new")]
    public partial class Payment : PaymentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<NSSFPensionSystem.Shared.Components.Forms.FormHeader>(0);
            __builder.AddAttribute(1, "Icon", "fa-solid fa-file-signature");
            __builder.AddAttribute(2, "Title", "?????????????????????????????????????????????????????????????????????");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "content mx-3 mb-5 pb-4");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container-fluid");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.AddMarkupContent(10, @"<div class=""col-md-2""><div class=""card card-info""><div class=""card-header""><div class=""card-title""><i class=""fa-solid fa-file-invoice""></i> ?????????????????????????????????????????????????????????</div></div>
                    <div class=""card-body p-0""><table class=""table""><tbody><tr><th>?????????</th>
                                    <td>00013/22</td></tr>
                                <tr><th>?????????????????????????????????</th>
                                    <td>01-06-2022</td></tr>
                                <tr><th>?????????????????????</th>
                                    <td></td></tr>
                                <tr><th>????????????</th>
                                    <td>$265.24</td></tr></tbody></table></div></div></div>
            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-10");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card card-outline card-info");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-header");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-row");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group col-md-3");
            __builder.OpenComponent<NSSFPensionSystem.Shared.Components.Label>(21);
            __builder.AddAttribute(22, "Text", "????????????????????????????????????????????????");
            __builder.AddAttribute(23, "for", "paymentcode");
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n                                ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "disabled");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "id", "paymentcode");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                                                         Payment.PayCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Payment.PayCode = __value, Payment.PayCode));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group col-md-3");
            __builder.AddMarkupContent(35, "<label for=\"paymentdate\">?????????????????????????????????</label>\r\n                                ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "text");
            __builder.AddAttribute(38, "disabled");
            __builder.AddAttribute(39, "class", "form-control");
            __builder.AddAttribute(40, "id", "paymentdate");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                                                         Payment.PayDate

#line default
#line hidden
#nullable disable
            , format: "dd-MM-yyyy"));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Payment.PayDate = __value, Payment.PayDate, format: "dd-MM-yyyy"));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "form-group col-md-2");
            __builder.AddMarkupContent(46, "<label for=\"paymentbimonth\" class=\"required\">?????????????????????</label>\r\n                                ");
            __builder.OpenElement(47, "select");
            __builder.AddAttribute(48, "id", "paymentbimonth");
            __builder.AddAttribute(49, "class", "form-control");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                                        Payment.ForBimonthly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Payment.ForBimonthly = __value, Payment.ForBimonthly));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(52, "option");
            __builder.AddAttribute(53, "value", "1");
            __builder.AddContent(54, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                    ");
            __builder.OpenElement(56, "option");
            __builder.AddAttribute(57, "value", "2");
            __builder.AddContent(58, "2");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                            ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "form-group col-md-2");
            __builder.AddMarkupContent(62, "<label for=\"paymentmonth\" class=\"required\">??????</label>\r\n                                ");
            __builder.OpenElement(63, "select");
            __builder.AddAttribute(64, "id", "paymentmonth");
            __builder.AddAttribute(65, "class", "form-control");
            __builder.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                                      Payment.ForMonth

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Payment.ForMonth = __value, Payment.ForMonth));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 61 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                     for (int i = 1; i <= 12; i++)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "value", 
#nullable restore
#line 63 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                        i

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(70, 
#nullable restore
#line 63 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                             nssfRef.nssfMethod.f_ConvertMonth(i)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 64 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                            ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "form-group col-md-2");
            __builder.AddMarkupContent(74, "<label for=\"paymentyear\" class=\"required\">???????????????</label>\r\n                                ");
            __builder.OpenElement(75, "select");
            __builder.AddAttribute(76, "id", "paymentyear");
            __builder.AddAttribute(77, "class", "form-control");
            __builder.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 69 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                                     Payment.ForYear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Payment.ForYear = __value, Payment.ForYear));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 70 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                     for (int i = DateTime.Now.Year - 1; i <= DateTime.Now.Year + 1; i++)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(80, "option");
            __builder.AddAttribute(81, "value", 
#nullable restore
#line 72 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                        i

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(82, 
#nullable restore
#line 72 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                            i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 73 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "card-body p-0");
            __builder.OpenElement(86, "table");
            __builder.AddAttribute(87, "class", "table table-bordered table-hover table-striped");
            __builder.OpenElement(88, "thead");
            __builder.OpenElement(89, "tr");
#nullable restore
#line 82 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                     foreach (string name in TableHeader)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(90, "th");
            __builder.AddAttribute(91, "class", "text-center");
            __builder.AddContent(92, 
#nullable restore
#line 84 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                 name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 85 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                            ");
            __builder.OpenElement(94, "tbody");
#nullable restore
#line 89 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                 if (PaymentReviews.Count == 0)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(95, "tr");
            __builder.OpenElement(96, "td");
            __builder.AddAttribute(97, "colspan", 
#nullable restore
#line 91 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                      TableHeader.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(98, "class", "text-center");
            __builder.AddMarkupContent(99, "?????????????????????????????????????????????????????????????????????!");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 92 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                 foreach (var item in PaymentReviews)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(100, "tr");
            __builder.OpenElement(101, "td");
            __builder.AddAttribute(102, "class", "text-center");
            __builder.AddContent(103, 
#nullable restore
#line 96 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                  PaymentReviews.IndexOf(item) + 1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                                        ");
            __builder.OpenElement(105, "td");
            __builder.AddAttribute(106, "class", "text-center");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "d-flex justify-content-between");
            __builder.AddContent(109, 
#nullable restore
#line 99 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                 item.ClaCode

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(110, "\r\n                                                ");
            __builder.OpenElement(111, "a");
            __builder.AddAttribute(112, "href", "javascript:void(0)");
            __builder.AddAttribute(113, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                                       () => OnNavigateToClaim(item.ClaGUID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(114, "<small><i class=\"fa-solid fa-eye\"></i></small>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                                        ");
            __builder.OpenElement(116, "td");
            __builder.AddAttribute(117, "class", "text-center");
            __builder.AddContent(118, 
#nullable restore
#line 105 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                 item.PsTypeNameKh

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                                        ");
            __builder.OpenElement(120, "td");
            __builder.AddAttribute(121, "class", "text-center");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "d-flex justify-content-between");
            __builder.AddContent(124, 
#nullable restore
#line 108 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                 item.AlwCode

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(125, "\r\n                                                ");
            __builder.AddMarkupContent(126, "<div class=\"dropdown\"><a href=\"#\" data-toggle=\"dropdown\" aria-expanded=\"true\"><small><i class=\"fa-solid fa-eye\"></i></small></a>\r\n                                                    <div class=\"dropdown-menu dropdown-menu-lg dropdown-menu-right\" style=\"left: inherit; right: 0px;\"><a href=\"#\" class=\"dropdown-item\"><h3 class=\"dropdown-item-title\">\r\n                                                                Brad Diesel\r\n                                                                <span class=\"float-right text-sm text-danger\"><i class=\"fas fa-star\"></i></span></h3>\r\n                                                            <p class=\"text-sm\">Call me whenever you can...</p>\r\n                                                            <p class=\"text-sm text-muted\"><i class=\"far fa-clock mr-1\"></i> 4 Hours Ago</p></a>\r\n                                                        <div class=\"dropdown-divider\"></div>\r\n                                                        <a href=\"#\" class=\"dropdown-item\"><h3 class=\"dropdown-item-title\">\r\n                                                                John Pierce\r\n                                                                <span class=\"float-right text-sm text-muted\"><i class=\"fas fa-star\"></i></span></h3>\r\n                                                            <p class=\"text-sm\">I got your message bro</p>\r\n                                                            <p class=\"text-sm text-muted\"><i class=\"far fa-clock mr-1\"></i> 4 Hours Ago</p></a></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                                        ");
            __builder.OpenElement(128, "td");
            __builder.AddAttribute(129, "class", "text-center");
            __builder.AddContent(130, 
#nullable restore
#line 139 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                  item.BenNote + "-" + item.BenId + "-" + item.BenChar

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                                        ");
            __builder.OpenElement(132, "td");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "d-flex justify-content-between");
            __builder.OpenElement(135, "span");
            __builder.AddAttribute(136, "class", "text-bold");
            __builder.AddContent(137, 
#nullable restore
#line 142 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                          item.FullnameKh

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                                                ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "dropdown");
            __builder.AddMarkupContent(141, "<a href=\"#\" data-toggle=\"dropdown\" aria-expanded=\"true\"><small><i class=\"fa-solid fa-eye\"></i></small></a>\r\n                                                    ");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "dropdown-menu dropdown-menu-lg dropdown-menu-right");
            __builder.AddAttribute(144, "style", "left: inherit; right: 0px;");
            __builder.OpenElement(145, "div");
            __builder.AddAttribute(146, "class", "dropdown-item");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "d-flex flex-row");
            __builder.AddMarkupContent(149, "<i class=\"fa-solid fa-user-tie text-muted pr-3\" style=\"font-size: 2.5rem;\"></i>\r\n                                                                ");
            __builder.OpenElement(150, "div");
            __builder.AddAttribute(151, "class", "media-body");
            __builder.OpenElement(152, "h3");
            __builder.AddAttribute(153, "class", "dropdown-item-title");
            __builder.AddContent(154, 
#nullable restore
#line 153 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                         item.FullnameKh

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(155, "\r\n                                                                        ");
            __builder.OpenElement(156, "span");
            __builder.AddAttribute(157, "class", "text-sm text-muted");
            __builder.AddContent(158, 
#nullable restore
#line 154 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                                                           item.SexId == "1" ? "???????????????" : "????????????"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                                                                    ");
            __builder.OpenElement(160, "p");
            __builder.AddAttribute(161, "class", "text-sm pb-1");
            __builder.AddContent(162, 
#nullable restore
#line 156 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                                             item.FullnameEn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n                                                                    ");
            __builder.OpenElement(164, "p");
            __builder.AddContent(165, 
#nullable restore
#line 157 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                         item.BenNote + "-" + item.BenId + "-" + item.BenChar

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n                                                                    ");
            __builder.OpenElement(167, "p");
            __builder.AddAttribute(168, "class", "text-sm");
            __builder.AddContent(169, 
#nullable restore
#line 158 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                                        item.Dob

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n                                        ");
            __builder.OpenElement(171, "td");
            __builder.AddAttribute(172, "class", "text-center");
            __builder.AddContent(173, 
#nullable restore
#line 181 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                              item.Details.Select(s=> s.BankAccount).FirstOrDefault()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n                                        ");
            __builder.OpenElement(175, "td");
            __builder.AddAttribute(176, "class", "text-center text-bold text-info");
            __builder.AddContent(177, 
#nullable restore
#line 201 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                                      item.Details.Sum(s=> s.PensionAmount).ToString("N0")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n                                        ");
            __builder.AddMarkupContent(179, @"<td class=""text-center""><div class=""dropdown dropup custom-dropdown-icon""><a href=""#"" role=""button"" id=""dropdownMenuLink-3"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""true""><i class=""fa-solid fa-ellipsis-vertical p-2"" style=""font-size: 1.4rem; color:var(--info)""></i></a>
                                                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdownMenuLink-3"" style=""z-index:999999; will-change: transform; position: absolute; transform: translate3d(-75px, -147px, 0px); top: 0px; left: 0px;"" x-placement=""top-end;""><a class=""dropdown-item"" href=""javascript:void(0);""><i class=""fa-solid fa-lock""></i> ????????????????????????????????????????????????????????????</a>
                                                    <a class=""dropdown-item"" href=""javascript:void(0);""><i class=""fa-regular fa-credit-card""></i> ?????????????????????????????????????????????</a></div></div></td>");
            __builder.CloseElement();
#nullable restore
#line 214 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 218 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                     if (PaymentReviews.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(180, "div");
            __builder.AddAttribute(181, "class", "card-footer text-right");
            __builder.AddMarkupContent(182, "<button id=\"multiple-reset\" class=\"btn btn-dark mr-4\"><i class=\"fas fa-circle-plus\"></i> ??????????????????????????????</button>\r\n                            ");
            __builder.OpenElement(183, "button");
            __builder.AddAttribute(184, "id", "multiple-reset");
            __builder.AddAttribute(185, "class", "btn btn-info");
            __builder.AddAttribute(186, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 222 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                                                                                       OnSave

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(187, "<i class=\"fa-regular fa-floppy-disk\"></i> ????????????????????????");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 224 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<NSSFPensionSystem.Shared.Components.Message>(189);
            __builder.AddComponentReferenceCapture(190, (__value) => {
#nullable restore
#line 234 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
               MessageBox = (NSSFPensionSystem.Shared.Components.Message)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(191, "\r\n");
            __builder.OpenComponent<NSSFPensionSystem.Shared.Components.Loading>(192);
            __builder.AddComponentReferenceCapture(193, (__value) => {
#nullable restore
#line 235 "E:\Development\GitLocal\pension-system\System\New\NSSFPensionSystem\Pages\Payment\Payment.razor"
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
