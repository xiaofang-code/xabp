﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System.Collections.Generic;

using X.Abp.Account.ExternalProviders;

namespace X.Abp.Account;

public class AccountExternalProviderSettingsDto
{
    public List<ExternalProviderSettings> Settings { get; set; }
}
