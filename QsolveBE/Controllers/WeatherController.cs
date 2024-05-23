using Contract;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace QsolveBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        //private readonly ILogger _logger;

        public WeatherController(IRepositoryWrapper repository)
        {
            _repository = repository;
            // _logger = logger;
        }

        [HttpGet]
        [Route("GetWeather")]
        public async Task<IActionResult> Get()
        {
            var weather = _repository.Weather.GetAll();

            if (weather.Exception != null || weather.Result == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return Ok(weather.Result);

        }

        [HttpGet]
        [Route("GetWeatherById")]
        public async Task<IActionResult> GetWeatherById(Guid id)
        {


            var weather = _repository.Weather.GetById(id);
            if (weather.Result == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
            return Ok(weather.Result);

        }

        [HttpPost]
        [Route("AddWeather")]
        public async Task<IActionResult> Post(Weather weather)
        {
            try
            {
                _repository.Weather.Add(weather);
                _repository.Save();
                return Ok("Added Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex);
            }


        }

        [HttpPut]
        [Route("UpdateWeather")]
        public async Task<IActionResult> Put(Weather weather)
        {
            try
            {
                _repository.Weather.Update(weather);
                _repository.SaveChanges();
                return Ok("Updated Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status304NotModified, ex);
            }

        }

        [HttpDelete]
        [Route("DeleteWeather")]
        public async Task<IActionResult> Delete(Guid id)
        {
            
            if (id == Guid.Empty)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }

            try
            {
                var weatherToUpdate = await _repository.Weather.GetById(id);
                _repository.Weather.Remove(weatherToUpdate);
                _repository.SaveChanges();
                return Ok("Updated Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex);
            }

        }
    }
}
