using System.Collections.Generic;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Service.Abstract;
using Service.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InternsController : ControllerBase
    {
        // GET
        [HttpGet]
        public List<Intern> Get()
        {
            IInternService internService = new InternManager(new EfInternDal());
            return internService.GetAll();
        }
    }
}