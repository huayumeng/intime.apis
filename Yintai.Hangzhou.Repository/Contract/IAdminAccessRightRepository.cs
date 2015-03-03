﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yintai.Hangzhou.Data.Models;

namespace Yintai.Hangzhou.Repository.Contract
{
    public interface IAdminAccessRightRepository:IRepository<AdminAccessRightEntity, int>
    {
        void InsertIfNotPresent(IEnumerable<AdminAccessRightEntity> entity);
    }
}
