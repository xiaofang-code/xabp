﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using Volo.Abp.Settings;

namespace AbpVnext.Pro.Settings;

public class ProSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        // Define your own settings here. Example:
        // context.Add(new SettingDefinition(ProSettings.MySetting1));
    }
}
