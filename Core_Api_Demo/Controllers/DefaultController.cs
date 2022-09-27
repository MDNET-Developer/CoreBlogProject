using Core_Api_Demo.DataAccsessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Api_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult Isciler()
        {
            using var c = new Context();
            var isciler = c.Iscilers.ToList();
                return Ok(isciler);
        }


        [HttpPost]
        public IActionResult YeniIsci(Isciler i)
        {
            using var c = new Context();
            c.Add(i);
            c.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetIsci(int id)
        {
            using var c = new Context();
            var isci = c.Iscilers.Find(id);
            if (isci != null)
            {
                return Ok(isci);
            }
            else
            {
              return  NotFound();
            }
            
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteIsci(int id)
        {
            using var c = new Context();
            var isci = c.Iscilers.Find(id);
            if (isci != null)
            {
                c.Remove(isci);
                c.SaveChanges();
                return Ok(isci);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpPut]
        public IActionResult UpdateIsci(Isciler isci)
        {
            using var c = new Context();
            var getisci = c.Find<Isciler>(isci.IsciID);
            if (isci != null)
            {
                getisci.IsciAd = isci.IsciAd;
                getisci.IsciSoyad = isci.IsciSoyad;
                c.Update(getisci);
                c.SaveChanges();
                return Ok(isci);
            }
            else
            {
                return NotFound();

            }
        }
}
}