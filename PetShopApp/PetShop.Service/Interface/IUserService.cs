﻿using PetShop.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Service.Interface
{
    public interface IUserService : IGenericCRUDService<PetShopApplicationUserDTO, string>
    {
    }
}
