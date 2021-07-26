using NetCoreAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPI.Data.Repositories
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetAllCars();
        Task<Car> GetCarDetails(int id);
        Task<Car> InsertCar(Car car);
        Task<Car> UpdateCar(Car car);
        Task<Car> DeleteCar(Car car);
    }
}
