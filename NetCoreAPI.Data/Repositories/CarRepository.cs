using NetCoreAPI.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPI.Data.Repositories
{
    class CarRepository : ICarRepository
    {
        private PostgreSQLConfiguracion _connectionString;

        public CarRepository(PostgreSQLConfiguracion connectionString)
        {
            _connectionString = connectionString;

        }

        protected NpgsqlConnection dbConnection()
        {
            return new NpgsqlConnection(_connectionString.ConnectionString);
        }


        public Task<Car> DeleteCar(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetCarDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Car> InsertCar(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<Car> UpdateCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
