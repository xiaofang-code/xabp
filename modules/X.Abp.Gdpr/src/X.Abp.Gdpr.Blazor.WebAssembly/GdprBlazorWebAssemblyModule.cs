﻿using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace X.Abp.Gdpr.Blazor.WebAssembly;

[DependsOn(
    typeof(GdprBlazorModule),
    typeof(GdprHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class GdprBlazorWebAssemblyModule : AbpModule
{

}
