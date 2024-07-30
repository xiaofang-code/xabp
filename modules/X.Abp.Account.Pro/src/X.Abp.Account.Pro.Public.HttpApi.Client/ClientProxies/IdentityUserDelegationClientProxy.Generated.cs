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
using X.Abp.Account.Dtos;

// ReSharper disable once CheckNamespace
namespace X.Abp.Account;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IIdentityUserDelegationAppService), typeof(IdentityUserDelegationClientProxy))]
public partial class IdentityUserDelegationClientProxy : ClientProxyBase<IIdentityUserDelegationAppService>, IIdentityUserDelegationAppService
{
    public virtual async Task<ListResultDto<UserDelegationDto>> GetDelegatedUsersAsync()
    {
        return await RequestAsync<ListResultDto<UserDelegationDto>>(nameof(GetDelegatedUsersAsync));
    }

    public virtual async Task<ListResultDto<UserDelegationDto>> GetMyDelegatedUsersAsync()
    {
        return await RequestAsync<ListResultDto<UserDelegationDto>>(nameof(GetMyDelegatedUsersAsync));
    }

    public virtual async Task<ListResultDto<UserDelegationDto>> GetActiveDelegationsAsync()
    {
        return await RequestAsync<ListResultDto<UserDelegationDto>>(nameof(GetActiveDelegationsAsync));
    }

    public virtual async Task<ListResultDto<UserLookupDto>> GetUserLookupAsync(GetUserLookupInput input)
    {
        return await RequestAsync<ListResultDto<UserLookupDto>>(nameof(GetUserLookupAsync), new ClientProxyRequestTypeValue
        {
            { typeof(GetUserLookupInput), input }
        });
    }

    public virtual async Task DelegateNewUserAsync(DelegateNewUserInput input)
    {
        await RequestAsync(nameof(DelegateNewUserAsync), new ClientProxyRequestTypeValue
        {
            { typeof(DelegateNewUserInput), input }
        });
    }

    public virtual async Task DeleteDelegationAsync(Guid id)
    {
        await RequestAsync(nameof(DeleteDelegationAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }
}
