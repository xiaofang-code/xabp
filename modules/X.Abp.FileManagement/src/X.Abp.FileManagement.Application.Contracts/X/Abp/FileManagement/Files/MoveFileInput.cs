﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using System;

using Volo.Abp.Domain.Entities;

namespace X.Abp.FileManagement.Files;

public class MoveFileInput : IHasConcurrencyStamp
{
    public Guid Id { get; set; }

    public Guid? NewDirectoryId { get; set; }

    public string ConcurrencyStamp { get; set; }
}
