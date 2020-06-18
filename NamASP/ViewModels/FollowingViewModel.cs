using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NamASP.Models;

namespace NamASP.ViewModels
{
    public class FollowingViewModel
    {
        public IEnumerable<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}