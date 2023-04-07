using AuthServer.Core.Dtos;
using AuthServer.Core.Models;
using AuthServer.Core.Services;
using Microsoft.AspNetCore.Identity;
using SharedLibrary.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer.Service.Services
{
    public class UserService :IUserService
    {
        private readonly UserManager<UserApp> _userManagaer;
        public UserService(UserManager<UserApp> userManagaer)
        {
            _userManagaer = userManagaer;
        }

        //Yeni kullanıcı oluşturma
        public async Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = new UserApp {Email = createUserDto.Email,UserName = createUserDto.UserName};
            var result = await _userManagaer.CreateAsync(user, createUserDto.Password);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x=>x.Description).ToList();

                return Response<UserAppDto>.Fail("not found", 404,true);
            }
            return Response<UserAppDto>.Success(ObjectMapper.Mapper.Map<UserAppDto>(user),200);
        }
        public async Task<Response<UserAppDto>> GetUserByNameAsync(string userName)
        {
            var user = await _userManagaer.FindByNameAsync(userName);
            if(user == null)
            {
                return Response<UserAppDto>.Fail("userName not found", 404, true);
            }
            return Response<UserAppDto>.Success(ObjectMapper.Mapper.Map<UserAppDto>(user), 200);
        }
    }
}
