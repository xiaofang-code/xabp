// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Security.Claims;

using Volo.Abp.DependencyInjection;
using Volo.Abp.Security.Claims;

namespace MyCompanyName.MyProjectName.Security;

[Dependency(ReplaceServices = true)]
public class FakeCurrentPrincipalAccessor : ICurrentPrincipalAccessor, ISingletonDependency
{
    public ClaimsPrincipal Principal => GetPrincipal();
    private ClaimsPrincipal _principal;

    private ClaimsPrincipal GetPrincipal()
    {
        if (_principal == null)
        {
            FakeCurrentPrincipalAccessor fakeCurrentPrincipalAccessor = this;
            lock (fakeCurrentPrincipalAccessor)
            {
                if (_principal == null)
                {
                    _principal = new ClaimsPrincipal(
                        new ClaimsIdentity(
                            new List<Claim>
                            {
                                    new Claim(AbpClaimTypes.UserId, "2e701e62-0953-4dd3-910b-dc6cc93ccb0d"),
                                    new Claim(AbpClaimTypes.UserName, "admin"),
                                    new Claim(AbpClaimTypes.Email, "admin@abp.io")
                            }
                        )
                    );
                }
            }
        }

        return _principal;
    }

    public IDisposable Change(ClaimsPrincipal principal)
    {
        _principal = principal;
        return null;
    }
}
