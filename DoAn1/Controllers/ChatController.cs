﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoAn1.Controllers
{
    [Authorize(Roles = "Admin, Seller")]
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}