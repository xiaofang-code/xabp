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
using X.Abp.IdentityServer.Client;
using X.Abp.IdentityServer.Client.Dtos;

// ReSharper disable once CheckNamespace
namespace X.Abp.IdentityServer;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IClientAppService), typeof(ClientsClientProxy))]
public partial class ClientsClientProxy : ClientProxyBase<IClientAppService>, IClientAppService
{
    public virtual async Task<PagedResultDto<ClientWithDetailsDto>> GetListAsync(GetClientListInput input)
    {
        return await RequestAsync<PagedResultDto<ClientWithDetailsDto>>(nameof(GetListAsync), new ClientProxyRequestTypeValue
        {
            { typeof(GetClientListInput), input }
        });
    }

    public virtual async Task<ClientWithDetailsDto> GetAsync(Guid id)
    {
        return await RequestAsync<ClientWithDetailsDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<ClientWithDetailsDto> CreateAsync(CreateClientDto input)
    {
        return await RequestAsync<ClientWithDetailsDto>(nameof(CreateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(CreateClientDto), input }
        });
    }

    public virtual async Task<ClientWithDetailsDto> UpdateAsync(Guid id, UpdateClientDto input)
    {
        return await RequestAsync<ClientWithDetailsDto>(nameof(UpdateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id },
            { typeof(UpdateClientDto), input }
        });
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        await RequestAsync(nameof(DeleteAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }
}
