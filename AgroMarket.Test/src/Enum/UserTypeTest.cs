﻿using AgroMarket.Data.Models;
using AgroMarket.Shared.Enum;
using Xunit;

namespace AgroMarket.Test.Enum;

public class UserTypeTest
{
    [Fact]
    public void Test_GetsAllUsers()
    {
        var x = BaseEnum.GetAll<UserType>();
    }
}