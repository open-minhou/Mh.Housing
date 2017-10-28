using Mh.Housing.Dto;
using Mh.Housing.IService.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Mh.Housing.ManageSite.Areas.api.Controllers
{
    public class UserController : ApiController
    {
        readonly IUserService _service;
        public UserController(IUserService service) {
            _service = service;
        }

        public async Task<ResponseModel> Login(UserLoginRequest request) {
            try
            {
                return await _service.UserLogin(request);
            }
            catch (Exception ex)
            {
                return ResponseModel.Error(ex);
            }
        }
    }
}
