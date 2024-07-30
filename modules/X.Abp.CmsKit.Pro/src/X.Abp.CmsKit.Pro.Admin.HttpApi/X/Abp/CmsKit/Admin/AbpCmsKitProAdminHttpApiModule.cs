﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using Microsoft.Extensions.DependencyInjection;

using Volo.Abp.Modularity;
using Volo.CmsKit.Admin;

namespace X.Abp.CmsKit.Admin;

[DependsOn(
    typeof(AbpCmsKitProAdminApplicationContractsModule),
    typeof(CmsKitAdminHttpApiModule))]
public class AbpCmsKitProAdminHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(builder => builder.AddApplicationPartIfNotExists(typeof(AbpCmsKitProAdminHttpApiModule).Assembly));
    }
}
