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
using X.Abp.TextTemplateManagement.TextTemplates;

// ReSharper disable once CheckNamespace
namespace X.Abp.TextTemplateManagement.TextTemplates;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(ITemplateDefinitionAppService), typeof(TemplateDefinitionClientProxy))]
public partial class TemplateDefinitionClientProxy : ClientProxyBase<ITemplateDefinitionAppService>, ITemplateDefinitionAppService
{
    public virtual async Task<PagedResultDto<TemplateDefinitionDto>> GetListAsync(GetTemplateDefinitionListInput input)
    {
        return await RequestAsync<PagedResultDto<TemplateDefinitionDto>>(nameof(GetListAsync), new ClientProxyRequestTypeValue
        {
            { typeof(GetTemplateDefinitionListInput), input }
        });
    }

    public virtual async Task<TemplateDefinitionDto> GetAsync(string name)
    {
        return await RequestAsync<TemplateDefinitionDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), name }
        });
    }
}
