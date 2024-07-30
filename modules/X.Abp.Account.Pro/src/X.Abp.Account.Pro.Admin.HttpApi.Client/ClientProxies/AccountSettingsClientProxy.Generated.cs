// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using X.Abp.Account;

// ReSharper disable once CheckNamespace
namespace X.Abp.Account;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IAccountSettingsAppService), typeof(AccountSettingsClientProxy))]
public partial class AccountSettingsClientProxy : ClientProxyBase<IAccountSettingsAppService>, IAccountSettingsAppService
{
    public virtual async Task<AccountSettingsDto> GetAsync()
    {
        return await RequestAsync<AccountSettingsDto>(nameof(GetAsync));
    }

    public virtual async Task UpdateAsync(AccountSettingsDto input)
    {
        await RequestAsync(nameof(UpdateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(AccountSettingsDto), input }
        });
    }

    public virtual async Task<AccountTwoFactorSettingsDto> GetTwoFactorAsync()
    {
        return await RequestAsync<AccountTwoFactorSettingsDto>(nameof(GetTwoFactorAsync));
    }

    public virtual async Task UpdateTwoFactorAsync(AccountTwoFactorSettingsDto input)
    {
        await RequestAsync(nameof(UpdateTwoFactorAsync), new ClientProxyRequestTypeValue
        {
            { typeof(AccountTwoFactorSettingsDto), input }
        });
    }

    public virtual async Task<AccountCaptchaSettingsDto> GetRecaptchaAsync()
    {
        return await RequestAsync<AccountCaptchaSettingsDto>(nameof(GetRecaptchaAsync));
    }

    public virtual async Task UpdateRecaptchaAsync(AccountCaptchaSettingsDto input)
    {
        await RequestAsync(nameof(UpdateRecaptchaAsync), new ClientProxyRequestTypeValue
        {
            { typeof(AccountCaptchaSettingsDto), input }
        });
    }

    public virtual async Task<AccountExternalProviderSettingsDto> GetExternalProviderAsync()
    {
        return await RequestAsync<AccountExternalProviderSettingsDto>(nameof(GetExternalProviderAsync));
    }

    public virtual async Task UpdateExternalProviderAsync(List<UpdateExternalProviderDto> input)
    {
        await RequestAsync(nameof(UpdateExternalProviderAsync), new ClientProxyRequestTypeValue
        {
            { typeof(List<UpdateExternalProviderDto>), input }
        });
    }
}
