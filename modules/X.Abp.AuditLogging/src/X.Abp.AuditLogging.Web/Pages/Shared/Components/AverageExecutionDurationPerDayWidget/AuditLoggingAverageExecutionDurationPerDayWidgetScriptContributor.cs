﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Packages.ChartJs;
using Volo.Abp.Modularity;

namespace X.Abp.AuditLogging.Web.Pages.Shared.Components.AverageExecutionDurationPerDayWidget
{
    [DependsOn(typeof(ChartjsScriptContributor))]
    public class AuditLoggingAverageExecutionDurationPerDayWidgetScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/client-proxies/auditLogging-proxy.js");
            context.Files.Add("/Pages/Shared/Components/AverageExecutionDurationPerDayWidget/Default.js");
        }
    }
}
