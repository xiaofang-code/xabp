﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using Volo.Abp.Content;

namespace X.Abp.Account.Dtos;

public class ProfilePictureInput
{
    public ProfilePictureType Type { get; set; }

    public IRemoteStreamContent ImageContent { get; set; }
}
