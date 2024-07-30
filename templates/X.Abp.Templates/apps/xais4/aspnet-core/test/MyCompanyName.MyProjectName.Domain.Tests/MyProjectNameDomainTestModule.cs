// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using MyCompanyName.MyProjectName.EntityFrameworkCore;

using Volo.Abp.Modularity;

namespace MyCompanyName.MyProjectName;

[DependsOn(
    typeof(MyProjectNameEntityFrameworkCoreTestModule)
    )]
public class MyProjectNameDomainTestModule : AbpModule
{

}
