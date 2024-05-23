using Contract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository 
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _context;
        private IWeatherRepository _weatherRepository;

        public RepositoryWrapper(RepositoryContext context)
        {
            _context = context;
        }

        public IWeatherRepository Weather
        {

            get
            {
                if (_weatherRepository == null)
                    _weatherRepository = new WeatherRepository(_context);

                return _weatherRepository;
            }

            /*set
            {
                _userRepository = value;
            }*/


        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
