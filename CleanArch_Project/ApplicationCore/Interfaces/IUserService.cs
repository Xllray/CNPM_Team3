using ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    interface IUserService
    {

        int GetCustomerId(int userId);

        UserDto Login(String username, String password);
        void dangky(CustomerDto customer, UserDto user);

        bool tontaiUsername(UserDto user);
    }
}
