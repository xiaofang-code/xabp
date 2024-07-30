﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System;

using Volo.Abp.ObjectExtending.Modularity;

namespace X.Abp.ObjectExtending;

public class LanguageManagementModuleExtensionConfiguration : ModuleExtensionConfiguration
{
    public LanguageManagementModuleExtensionConfiguration ConfigureLanguage(Action<EntityExtensionConfiguration> configureAction)
    {
        return this.ConfigureEntity(LanguageManagementModuleExtensionConsts.EntityNames.Language, configureAction);
    }
}
