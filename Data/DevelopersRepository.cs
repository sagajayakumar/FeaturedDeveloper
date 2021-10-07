using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeaturedDeveloper.Helper;
using Microsoft.Extensions.Logging;
using FeaturedDeveloper.Interfaces;

namespace FeaturedDeveloper.Data
{
    public class DevelopersRepository : IDeveloperRepository
    {
        private readonly DeveloperContext _DevelopersContext;
        private readonly ILogger<DevelopersUtility> _logger;

        public DevelopersRepository(DeveloperContext developerContext, ILogger<DevelopersUtility> logger)
        {
            _DevelopersContext= developerContext;
            _logger = logger;
        }
        public String GetDeveloper()
        {
            var q = _DevelopersContext.DeveloperFields.FirstOrDefault();
            return "q";
        }
    }
}
