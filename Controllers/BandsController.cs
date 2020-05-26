using BandAPI.Helpers;
using BandAPI.Models;
using BandAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.Controllers
{
    [ApiController]
    [Route("api/bands")]
    public class BandsController : ControllerBase
    {
        // Places repository in the controller
        private readonly IBandAlbumRepository _bandAlbumRepository;
        public BandsController(IBandAlbumRepository bandAlbumRepository)
        {
            _bandAlbumRepository = bandAlbumRepository ??
                throw new ArgumentNullException(nameof(bandAlbumRepository));
        }

        [HttpGet]
        public ActionResult<IEnumerable<BandDTO>> GetBands()
        {
            var bandsFromRepo = _bandAlbumRepository.GetBands();
            var bandsDTO = new List<BandDTO>();

            foreach(var band in bandsFromRepo) 
            {
                bandsDTO.Add(new BandDTO()
                {
                    Id = band.Id,
                    Name = band.Name,
                    MainGenre = band.MainGenre,
                    FoundedYearsAgo = $"{band.Founded.ToString("yyyy")} ({band.Founded.GetYearsAgo()} years ago)"
                });
            }

            return Ok(bandsDTO);
        }

        [HttpGet("{bandId}")]
        public IActionResult GetBand(Guid bandId)
        {
            var bandFromRepo = _bandAlbumRepository.GetBand(bandId);
            if (bandFromRepo == null)
                return NotFound();

            return Ok(bandFromRepo);
        }
    }
}
