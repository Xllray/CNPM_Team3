using System.Collections.Generic;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;

namespace ApplicationCore.Mapping
{
    public static class UserExtensionMethods
    {
        public static UserDto ConvertToUserDto(this User User)
        {
            return new UserDto()
            {


                UserId =User.UserId,
                UserPermissionId=User.UserPermissionId,
                UserName=User.UserName,
                UserPassword=User.UserPassword,
                UserCustomerId =User.UserCustomerId


    };
        }

        public static IEnumerable<UserDto> ConvertToUserDtos(this IEnumerable<User> Users)
        {
            foreach (User User in Users)
            {
                yield return User.ConvertToUserDto();
            }
        }

        public static User ConvertToUser(this UserDto UserDto)
        {
            return new User()
            {
                UserId = UserDto.UserId,
                UserPermissionId = UserDto.UserPermissionId,
                UserName = UserDto.UserName,
                UserPassword = UserDto.UserPassword,
                UserCustomerId = UserDto.UserCustomerId

            };
        }

        public static void Map(this UserDto UserDto, User User)
        {

            User.UserId = UserDto.UserId;
            User.UserPermissionId = UserDto.UserPermissionId;
            User.UserName = UserDto.UserName;
            User.UserPassword = UserDto.UserPassword;
            User.UserCustomerId = UserDto.UserCustomerId;

        }
    }
}