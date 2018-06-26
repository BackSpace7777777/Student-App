using System.Collections.Generic;
using StudentApp.Roles.Dto;
using StudentApp.Users.Dto;

namespace StudentApp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}