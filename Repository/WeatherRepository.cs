using Contract;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class WeatherRepository : RepositoryBase<Weather>, IWeatherRepository
    {
        public WeatherRepository(RepositoryContext repositoryContext)
       : base(repositoryContext)
        {

        }
    }
}
