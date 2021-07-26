using Microsoft.AspNetCore.Mvc;
using NetCoreAPI.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPI.Pages
{
    [Route("api/[controler]")]
    [ApiController]
    public class CarController : Controller
    {

        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCars()
        {
            return Ok(await _carRepository.GetAllCars());
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarDetails(int id)
        {
            return Ok(await _carRepository.GetCarDetails(id));
        }

    }
}
