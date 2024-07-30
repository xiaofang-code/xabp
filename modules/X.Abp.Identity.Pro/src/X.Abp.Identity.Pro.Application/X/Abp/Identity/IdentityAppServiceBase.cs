﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using Volo.Abp.Application.Services;
using Volo.Abp.Identity.Localization;

namespace X.Abp.Identity;

public abstract class IdentityAppServiceBase : ApplicationService
{
    protected IdentityAppServiceBase()
    {
        ObjectMapperContext = typeof(AbpIdentityProApplicationModule);
        LocalizationResource = typeof(IdentityResource);
    }
}
