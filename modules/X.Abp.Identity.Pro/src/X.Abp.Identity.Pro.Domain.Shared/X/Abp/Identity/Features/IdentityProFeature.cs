﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

namespace X.Abp.Identity.Features;

public class IdentityProFeature
{
    public const string GroupName = "Identity";

    public const string TwoFactor = GroupName + ".TwoFactor";

    public const string MaxUserCount = GroupName + ".MaxUserCount";

    public const string EnableLdapLogin = "Account.EnableLdapLogin";

    public const string EnableOAuthLogin = GroupName + ".EnableOAuthLogin";
}
