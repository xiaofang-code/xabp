﻿using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace X.Abp.Forms.Blazor.WebAssembly;

[DependsOn(
    typeof(FormsBlazorModule),
    typeof(FormsHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class FormsBlazorWebAssemblyModule : AbpModule
{

}
