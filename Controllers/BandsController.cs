using AutoMapper;
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
        private readonly IMapper _mapper;
        public BandsController(IBandAlbumRepository bandAlbumRepository, IMapper mapper)
        {
            _bandAlbumRepository = bandAlbumRepository ??
                throw new ArgumentNullException(nameof(bandAlbumRepository));
            _mapper = mapper ?? 
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        [HttpHead]
        public ActionResult<IEnumerable<BandDTO>> GetBands([FromQuery]string mainGenre)
        {
            //throw new Exception("testing exceptions");
            var bandsFromRepo = _bandAlbumRepository.GetBands(mainGenre);
            //var bandsDTO = new List<BandDTO>();

            //foreach(var band in bandsFromRepo) 
            //{
            //    bandsDTO.Add(new BandDTO()
            //    {
            //        Id = band.Id,
            //        Name = band.Name,
            //        MainGenre = band.MainGenre,
            //        FoundedYearsAgo = $"{band.Founded.ToString("yyyy")} ({band.Founded.GetYearsAgo()} years ago)"
            //    });
            //}
            //return Ok(BandDTO);

            return Ok(_mapper.Map<IEnumerable<BandDTO>>(bandsFromRepo));
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
