#pragma checksum "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62ada502d8c2190c76a9947538cfa3336c5dc7e8"
// <auto-generated/>
#pragma warning disable 1591
namespace NSSFPensionSystem.Pages.Claim
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Services.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\_Imports.razor"
using NSSFPensionSystem.Setting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/claims")]
    public partial class ClaimList : ClaimListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid bottom-spacing");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "layout-top-spacing ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "widget-content-area widget-shadow");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row mb-4");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-3");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-group");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "id", "btn-add-new");
            __builder.AddAttribute(14, "class", "btn btn-info");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                                           OnAddNew

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-plus-circle""><circle cx=""12"" cy=""12"" r=""10""></circle><line x1=""12"" y1=""8"" x2=""12"" y2=""16""></line><line x1=""8"" y1=""12"" x2=""16"" y2=""12""></line></svg>
                            ??????????????????????????????
                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n                ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-md-9");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-row justify-content-end");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group col-md-2");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "class", "form-control masked-code");
            __builder.AddAttribute(27, "placeholder", "???????????????????????????");
            __builder.AddAttribute(28, "id", "claimcode");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                                                                                              SearchClaimCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchClaimCode = __value, SearchClaimCode));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n                        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group col-md-2");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "text");
            __builder.AddAttribute(36, "class", "form-control masked-benid");
            __builder.AddAttribute(37, "placeholder", "?????????????????????.");
            __builder.AddAttribute(38, "id", "benid");
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                                                                                          SearchBenId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchBenId = __value, SearchBenId));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n                        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group col-md-3");
            __builder.OpenElement(44, "select");
            __builder.AddAttribute(45, "id", "pensiontype");
            __builder.AddAttribute(46, "class", "form-control");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                                                 SearchPensionType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchPensionType = __value, SearchPensionType));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 30 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                 foreach (PensionTypeModel p in PensionTypes)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "option");
            __builder.AddAttribute(50, "value", 
#nullable restore
#line 32 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                    p.TypeId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(51, 
#nullable restore
#line 32 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                               p.TypeNameKh

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-group col-md-3");
            __builder.OpenElement(55, "select");
            __builder.AddAttribute(56, "id", "claimstatus");
            __builder.AddAttribute(57, "class", "form-control");
            __builder.AddAttribute(58, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                                                 SearchStatus

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchStatus = __value, SearchStatus));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 38 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                 foreach (ClaimStatusModel st in ClaimStatuses)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "option");
            __builder.AddAttribute(61, "value", 
#nullable restore
#line 40 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                    st.StaId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(62, 
#nullable restore
#line 40 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                               st.StaDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n                        ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-group");
            __builder.OpenElement(66, "button");
            __builder.AddAttribute(67, "class", "btn btn-info");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                                   OnSearchClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(69, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-search""><circle cx=""11"" cy=""11"" r=""8""></circle><line x1=""21"" y1=""21"" x2=""16.65"" y2=""16.65""></line></svg>
                                ?????????????????????
                            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n\r\n\r\n\r\n            ");
            __builder.OpenComponent<NSSFPensionSystem.Pages.Claim.ClaimListTable>(71);
            __builder.AddAttribute(72, "ClaimList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<NSSFPensionSystem.Models.ClaimModel>>(
#nullable restore
#line 57 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                        ClaimList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "TableHeader", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 57 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                                 TableHeader

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "ClaimStatuses", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<NSSFPensionSystem.Models.ClaimStatusModel>>(
#nullable restore
#line 57 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                                                              ClaimStatuses

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "PensionTypes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<NSSFPensionSystem.Models.PensionTypeModel>>(
#nullable restore
#line 57 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                                                                                            PensionTypes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "OnEdit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 57 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                                                                                                                  (val) => OnEdit(val)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(77, "OnApproval", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<(System.Int32, System.Int32)>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<(System.Int32, System.Int32)>(this, 
#nullable restore
#line 57 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                                                                                                                                                      (e) => OnApproval(e.Item1, e.Item2)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(78, "OnTrack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 57 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                                                                                                                                                                                                     (val)=> OnShowTrace(val)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.OpenComponent<NSSFPensionSystem.Shared.Components.Pagination>(80);
            __builder.AddAttribute(81, "Paginate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NSSFPensionSystem.Models.PaginationModel>(
#nullable restore
#line 58 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                  Paginate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "OnChangedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<NSSFPensionSystem.Models.PaginationModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<NSSFPensionSystem.Models.PaginationModel>(this, 
#nullable restore
#line 58 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                           OnPageChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\r\n\r\n\r\n            ");
            __builder.OpenComponent<NSSFPensionSystem.Shared.Components.Modal>(84);
            __builder.AddAttribute(85, "Size", "md");
            __builder.AddAttribute(86, "Title", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(87, "<h5 class=\"modal-title\" id=\"exampleModalLabel\">?????????????????????</h5>");
            }
            ));
            __builder.AddAttribute(88, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-group");
                __builder2.AddMarkupContent(91, "<label>???????????????????????????????????????</label>\r\n                        ");
                __builder2.OpenElement(92, "textarea");
                __builder2.AddAttribute(93, "class", "form-control");
                __builder2.AddAttribute(94, "rows", "4");
                __builder2.AddAttribute(95, "placeholder", "?????????????????????????????????????????????????????????");
                __builder2.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                                                                         ClaimTrace.Note

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ClaimTrace.Note = __value, ClaimTrace.Note));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(98, "Footer", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(99, "button");
                __builder2.AddAttribute(100, "class", "btn btn-dark");
                __builder2.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                           () => ApprovalNoteModal.Close()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(102, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-x""><line x1=""18"" y1=""6"" x2=""6"" y2=""18""></line><line x1=""6"" y1=""6"" x2=""18"" y2=""18""></line></svg>
                        ??????????????????
                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                    ");
                __builder2.OpenElement(104, "button");
                __builder2.AddAttribute(105, "type", "button");
                __builder2.AddAttribute(106, "class", "btn btn-danger");
                __builder2.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                                           OnApprovalRejected

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(108, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-check""><polyline points=""20 6 9 17 4 12""></polyline></svg>
                        ??????????????????
                    ");
                __builder2.CloseElement();
            }
            ));
            __builder.AddComponentReferenceCapture(109, (__value) => {
#nullable restore
#line 61 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                         ApprovalNoteModal = (NSSFPensionSystem.Shared.Components.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(110, "\r\n\r\n            ");
            __builder.OpenComponent<NSSFPensionSystem.Shared.Components.Modal>(111);
            __builder.AddAttribute(112, "Size", "md");
            __builder.AddAttribute(113, "Title", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(114, "<h5 class=\"modal-title\" id=\"exampleModalLabel\">?????????????????????????????????????????????????????????</h5>");
            }
            ));
            __builder.AddAttribute(115, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<NSSFPensionSystem.Pages.Claim.ClaimTrace>(116);
                __builder2.AddAttribute(117, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<NSSFPensionSystem.Models.ClaimTraceModel>>(
#nullable restore
#line 88 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                       Traces

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(118, "Footer", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(119, "button");
                __builder2.AddAttribute(120, "class", "btn btn-dark");
                __builder2.AddAttribute(121, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                           () => TraceModal.Close()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(122, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-x""><line x1=""18"" y1=""6"" x2=""6"" y2=""18""></line><line x1=""6"" y1=""6"" x2=""18"" y2=""18""></line></svg>
                        ?????????????????????
                    ");
                __builder2.CloseElement();
            }
            ));
            __builder.AddComponentReferenceCapture(123, (__value) => {
#nullable restore
#line 83 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                         TraceModal = (NSSFPensionSystem.Shared.Components.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(124, "\r\n\r\n\r\n            ");
            __builder.OpenComponent<NSSFPensionSystem.Shared.Components.MessageBox>(125);
            __builder.AddAttribute(126, "OnConfirmation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<(System.Boolean, NSSFPensionSystem.Setting.ConfirmFor)>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<(System.Boolean, NSSFPensionSystem.Setting.ConfirmFor)>(this, 
#nullable restore
#line 99 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                                                            (e) => OnMessageBoxConfirmation(e.Item1, e.Item2)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(127, (__value) => {
#nullable restore
#line 99 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
                              MessageBox = (NSSFPensionSystem.Shared.Components.MessageBox)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n\r\n");
            __builder.OpenComponent<NSSFPensionSystem.Shared.Components.Loading>(129);
            __builder.AddComponentReferenceCapture(130, (__value) => {
#nullable restore
#line 104 "C:\Users\INCHANVEASNA\source\repos\NSSFPensionSystem\NSSFPensionSystem\Pages\Claim\ClaimList.razor"
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
