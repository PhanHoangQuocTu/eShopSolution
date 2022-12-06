using Client.Dtos.Common;
using System;
using System.Collections.Generic;

namespace Client.Dtos.UserDto
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
    }
}