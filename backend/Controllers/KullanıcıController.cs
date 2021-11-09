using backend.Data;
using backend.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullanıcıController : Controller
    {
        private IKullanıcıRepository kullanıcıRepository;
        private readonly ILogger<KullanıcıController> _logger;

        public KullanıcıController(IKullanıcıRepository _kullanıcıRepository, ILogger<KullanıcıController> logger)
        {
            kullanıcıRepository = _kullanıcıRepository;
            _logger = logger;


        }
        // GET: KullanıcıController
        public IEnumerable<KullanıcıBilgi> Index()
        {
            return kullanıcıRepository.GetAll();
        }

        // GET: KullanıcıController/Details/5
        [HttpGet("{id}")]
     
        public String Details([FromBody]KullanıcıBilgi kullanıcı)
        {
            return kullanıcıRepository.KullanıcıDöndür(kullanıcı);
        }

        [HttpPost]
        public String Create([FromBody]KullanıcıBilgi kullanıcı)
        {
            return kullanıcıRepository.KullanıcıEkle(kullanıcı);
        }


    }
}
