﻿using AgroMarket.Service.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMarket.Service.src.Dto.User;

public class UserUpdateDto: UserCreateDto
{
    public long Id { get; set; }
    
}

