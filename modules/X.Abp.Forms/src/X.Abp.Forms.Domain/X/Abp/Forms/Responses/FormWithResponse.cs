﻿// Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
// See https://github.com/ArcherTrister/xabp
// for more information concerning the license and the contributors participating to this project.

using X.Abp.Forms.Forms;

namespace X.Abp.Forms.Responses;

public class FormWithResponse
{
    public Form Form { get; set; }

    public FormResponse Response { get; set; }
}
