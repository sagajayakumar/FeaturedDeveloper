using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeaturedDeveloper.Data;
using FeaturedDeveloper.Interfaces;

namespace FeaturedDeveloper.Helper
{
    public class DevelopersUtility : IDeveloperUtility
    {
        private readonly DevelopersRepository _developersRepository;
        public String getDeveloper()
        {
            String developer = _developersRepository.GetDeveloper();
            return developer;
        }

    }
}
