﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System.Threading.Tasks;

using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

using X.Abp.LanguageManagement.Dto;

namespace X.Abp.LanguageManagement;

public interface ILanguageTextAppService : IApplicationService
{
    Task<PagedResultDto<LanguageTextDto>> GetListAsync(GetLanguagesTextsInput input);

    Task<LanguageTextDto> GetAsync(string resourceName, string cultureName, string name, string baseCultureName);

    Task UpdateAsync(string resourceName, string cultureName, string name, string value);

    Task RestoreToDefaultAsync(string resourceName, string cultureName, string name);
}
