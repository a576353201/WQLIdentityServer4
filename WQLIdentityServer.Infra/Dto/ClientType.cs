﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WQLIdentityServer.Infra.Dto
{
    public enum ClientType
    {
        Empty = 0,
        WebImplicit = 1,
        WebHybrid = 2,
        Spa = 3,
        Native = 4,
        Machine = 5
    }
}
