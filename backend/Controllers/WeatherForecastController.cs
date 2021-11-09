using backend.Data;
using backend.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IKullanıcıRepository kullanıcıRepository;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IKullanıcıRepository _kullanıcıRepository, ILogger<WeatherForecastController> logger)
        {
            kullanıcıRepository = _kullanıcıRepository;
            _logger = logger;


        }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"

        };



        [HttpGet]
        public String Get()
        {
            KullanıcıBilgi kullanıcı = new KullanıcıBilgi();
            kullanıcı.Mail = "admin@gmail.com";
            kullanıcı.İsim = "Atakan";
            kullanıcı.Soyisim = "Ertürk";
            kullanıcı.Parola = "1234.";
            return kullanıcıRepository.KullanıcıEkle(kullanıcı);


        }
    }
}
