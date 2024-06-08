using AutoMapper;
using Core.Entities;
using Core.Interfaces.Services;
using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpticController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOpticService _opticService;
        public OpticController(IMapper mapper, IOpticService opticService)
        {
            _mapper = mapper;
            _opticService = opticService;
        }

        [HttpPost(Name = "AddOptic")]
        public async Task<IActionResult> CreateOpticAsync([FromBody] OpticViewModel productOptic)
        {
            var optic = _mapper.Map<OpticViewModel, Optic>(productOptic);

            var dbWeapon = await _opticService.CreateAsync(optic);

            return Ok(dbWeapon);
        }

        [HttpGet(Name = "GetAllOptics")]
        public async Task<IActionResult> GetAllOpticsAsync()
        {
            var optics = await _opticService.GetAllAsync();

            var opticViewModels = _mapper.Map<List<Optic>, List<OpticViewModel>>(optics);
            return Ok(opticViewModels);
        }

        [HttpPut("{id}", Name = "UpdateOptic")]
        public async Task<IActionResult> UpdateOpticAsync(int id, [FromBody] OpticViewModel productOptic)
        {

            var optic = _mapper.Map<OpticViewModel, Optic>(productOptic);


            var updatedOptic = await _opticService.UpdateAsync(id, optic);

            return Ok(updatedOptic);
        }

        [HttpDelete("id", Name = "DeleteOptic")]
        public async Task<IActionResult> DeleteOpticAsync(int id)
        {
            await _opticService.DeleteAsync(id);

            return Ok("Optic was deleted succesfully");
        }
    }
}
