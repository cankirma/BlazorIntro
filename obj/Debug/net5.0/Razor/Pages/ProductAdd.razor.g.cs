#pragma checksum "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\Pages\ProductAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c219fe880312ac089adc03d16dc100908982ab47"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorIntro.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\_Imports.razor"
using BlazorIntro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\_Imports.razor"
using BlazorIntro.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\Pages\ProductAdd.razor"
using BlazorIntro.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductAdd")]
    public partial class ProductAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ProductAdd</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\Pages\ProductAdd.razor"
                  productAddModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\Pages\ProductAdd.razor"
                                                   HandleSave

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "table table-striped");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<h4>ProductName</h4>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "productName");
                __builder2.AddAttribute(14, "Class", "form-control");
                __builder2.AddAttribute(15, "Placeholder", "ProductName");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\Pages\ProductAdd.razor"
                                                                                                     productAddModel.ProductName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => productAddModel.ProductName = __value, productAddModel.ProductName))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => productAddModel.ProductName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __Blazor.BlazorIntro.Pages.ProductAdd.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#nullable restore
#line 13 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\Pages\ProductAdd.razor"
                                    productAddModel.ProductName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "<h4>Product Description</h4>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "id", "description");
                __builder2.AddAttribute(28, "Class", "form-control");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\Pages\ProductAdd.razor"
                                                                           productAddModel.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => productAddModel.Description = __value, productAddModel.Description))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => productAddModel.Description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n        ");
                __builder2.AddMarkupContent(33, "<h4>Category</h4>\r\n        ");
                __Blazor.BlazorIntro.Pages.ProductAdd.TypeInference.CreateInputSelect_1(__builder2, 34, 35, "categoryId", 36, "form-control", 37, 
#nullable restore
#line 22 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\Pages\ProductAdd.razor"
                                                                       productAddModel.CategoryId

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => productAddModel.CategoryId = __value, productAddModel.CategoryId)), 39, () => productAddModel.CategoryId, 40, (__builder3) => {
                    __builder3.AddMarkupContent(41, "<option>Choose</option>\r\n            ");
                    __builder3.AddMarkupContent(42, "<option value=\"1\">Beverages</option>\r\n            ");
                    __builder3.AddMarkupContent(43, "<option value=\"2\">Food</option>");
                }
                );
                __builder2.AddMarkupContent(44, "\r\n        <br>\r\n        ");
                __builder2.AddMarkupContent(45, "<button Class=\"btn btn-success\" type=\"submit\">save</button>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\can_k\Desktop\ToDoAppBlazorIntro\ToDoAppBlazorIntro\Pages\ProductAdd.razor"
       
    ProductAddModel productAddModel = new ProductAddModel();

    private void HandleSave()
    {
        Console.WriteLine("saved");
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorIntro.Pages.ProductAdd
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591