using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn1.Areas.Admin.Models
{
    public class ListIdentityUser
    {
        public List<ListUserWithRole> ListUser  { get; set; }
    }
}
