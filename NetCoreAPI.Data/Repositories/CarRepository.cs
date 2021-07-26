using Dapper;
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

        public async Task<IEnumerable<Car>> GetAllCars()
        {
            var db = dbConnection();
            var sql = @" SELECT id,make,model,color,year,doors
                            FROM public.""Cars"" ";
            return await db.QueryAsync<Car>(sql, new { });
        }

        public async Task<Car> GetCarDetails(int id)
        {
            var db = dbConnection();
            var sql = @" SELECT id,make,model,color,year,doors
                            FROM public.""Cars"" 
                where id = @Id";
            return await db.QueryFirstOrDefaultAsync<Car>(sql, new {Id = id});
        }

        public async Task<bool> InsertCar(Car car)
        {
            var db = dbConnection();
            var sql = @" 
                        INSERT INTO public.""Cars""(make,model,color,year,doors)
                        VALUES(@Make,@Model,@Color,@Year, @Doors)";
           var result =  await db.ExecuteAsync(sql, new { car.Make, car.Model, car.Color, car.Year, car.Door });
            return result > 0;
        }

        public Task<Car> UpdateCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
