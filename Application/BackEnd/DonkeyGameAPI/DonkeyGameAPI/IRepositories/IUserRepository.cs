﻿using DonkeyGameAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonkeyGameAPI.IRepositories
{
    public interface IUserRepository : IRepository<User>
    {
        List<User> GetAllList();
    }
}
