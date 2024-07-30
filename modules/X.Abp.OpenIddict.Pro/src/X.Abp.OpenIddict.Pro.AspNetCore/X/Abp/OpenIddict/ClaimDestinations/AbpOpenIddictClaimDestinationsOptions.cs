﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using Volo.Abp.Collections;

namespace X.Abp.OpenIddict.ClaimDestinations;

public class AbpOpenIddictClaimDestinationsOptions
{
    public ITypeList<IAbpOpenIddictClaimDestinationsProvider> ClaimDestinationsProvider { get; }

    public AbpOpenIddictClaimDestinationsOptions()
    {
        ClaimDestinationsProvider = new TypeList<IAbpOpenIddictClaimDestinationsProvider>();
    }
}
