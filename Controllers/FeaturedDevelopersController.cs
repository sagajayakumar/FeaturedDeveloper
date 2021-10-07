using System;
using System.Collections.Generic;
using System.Linq;
using FeaturedDeveloper.Models;
using FeaturedDeveloper.Helper;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FeaturedDeveloper.Controllers
{
    public class FeaturedDevelopersController
    {

        private readonly DevelopersUtility _utility;

        public ILogger<FeaturedDevelopersController> _logger { get; }

        public FeaturedDevelopersController(DevelopersUtility utility, ILogger<FeaturedDevelopersController> logger)
        {
            _utility = utility;
            _logger = logger;
        }

        [HttpGet("api/FeaturedDevelopers")]
        public String FeaturedDevelopers()
        {
            string developers = _utility.getDeveloper();
            return developers;
        }

    }
}
