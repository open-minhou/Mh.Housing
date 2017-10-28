using Mh.Housing.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mh.Housing.IService.Users
{
    public interface IUserService
    {
        Task<ResponseModel> UserLogin(UserLoginRequest request);
    }
}
