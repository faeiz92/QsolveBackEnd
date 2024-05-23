using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IRepositoryWrapper
    {
        IWeatherRepository Weather { get; }
        void Save();

        void SaveChanges();
    }
}
