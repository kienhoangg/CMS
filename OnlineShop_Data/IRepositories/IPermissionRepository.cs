﻿using OnlineShop_Data.Entities;
using OnlineShop_Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop_Data.IRepositories
{
    public interface IPermissionRepository : IRepository<Permission,int>
    {
    }
}
