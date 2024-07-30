// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Content;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using X.Abp.Gdpr;

// ReSharper disable once CheckNamespace
namespace X.Abp.Gdpr;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IGdprRequestAppService), typeof(GdprRequestClientProxy))]
public partial class GdprRequestClientProxy : ClientProxyBase<IGdprRequestAppService>, IGdprRequestAppService
{
    public virtual async Task PrepareUserDataAsync()
    {
        await RequestAsync(nameof(PrepareUserDataAsync));
    }

    public virtual async Task<DownloadTokenResultDto> GetDownloadTokenAsync(Guid requestId)
    {
        return await RequestAsync<DownloadTokenResultDto>(nameof(GetDownloadTokenAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), requestId }
        });
    }

    public virtual async Task<IRemoteStreamContent> GetUserDataAsync(Guid requestId, string token)
    {
        return await RequestAsync<IRemoteStreamContent>(nameof(GetUserDataAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), requestId },
            { typeof(string), token }
        });
    }

    public virtual async Task<bool> IsNewRequestAllowedAsync()
    {
        return await RequestAsync<bool>(nameof(IsNewRequestAllowedAsync));
    }

    public virtual async Task<PagedResultDto<GdprRequestDto>> GetListByUserIdAsync(Guid userId)
    {
        return await RequestAsync<PagedResultDto<GdprRequestDto>>(nameof(GetListByUserIdAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), userId }
        });
    }

    public virtual async Task DeleteUserDataAsync()
    {
        await RequestAsync(nameof(DeleteUserDataAsync));
    }
}
