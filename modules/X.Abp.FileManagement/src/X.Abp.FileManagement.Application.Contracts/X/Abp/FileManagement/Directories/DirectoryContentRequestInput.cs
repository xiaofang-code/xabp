﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System;

using Volo.Abp.Application.Dtos;

namespace X.Abp.FileManagement.Directories;

public class DirectoryContentRequestInput : ISortedResultRequest
{
    public string Filter { get; set; }

    public string Sorting { get; set; }

    public Guid? Id { get; set; }
}
