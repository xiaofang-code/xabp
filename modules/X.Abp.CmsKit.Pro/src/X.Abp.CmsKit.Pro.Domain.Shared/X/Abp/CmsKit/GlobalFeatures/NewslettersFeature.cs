﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using Volo.Abp.GlobalFeatures;

namespace X.Abp.CmsKit.GlobalFeatures;

[GlobalFeatureName(Name)]
public class NewslettersFeature : GlobalFeature
{
    public const string Name = "CmsKitPro.Newsletter";

    internal NewslettersFeature(GlobalCmsKitProFeatures cmsKitPro)
      : base(cmsKitPro)
    {
    }

    public override void Enable()
    {
        var user = FeatureManager.Modules.CmsKit().User;
        if (!user.IsEnabled)
        {
            user.Enable();
        }

        base.Enable();
    }
}
