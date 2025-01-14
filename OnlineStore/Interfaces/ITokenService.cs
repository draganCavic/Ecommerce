﻿using OnlineStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(User user);
    }
}
