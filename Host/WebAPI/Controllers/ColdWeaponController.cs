using ApplicationServices.Services;
using AutoMapper;
using Core.Entities;
using Core.Interfaces.Services;
using Core.ViewModels;
using Core.ViewModels.Request;
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
    public class ColdWeaponController : ControllerBase
    {
        private readonly IColdWeaponService _coldWeaponService;
        private readonly IMapper _mapper;
        public ColdWeaponController(IColdWeaponService coldWeaponService, IMapper mapper)
        {
            _coldWeaponService = coldWeaponService;
            _mapper = mapper;
        }

        [HttpPost(Name = "AddColdWeapon")]
        public async Task<IActionResult> CreateWeaponAsync([FromBody] ColdWeaponViewModel productWeapon)
        {
            var coldWeapon = _mapper.Map<ColdWeaponViewModel, ColdWeapon>(productWeapon);

            var dbWeapon = await _coldWeaponService.CreateAsync(coldWeapon);

            return Ok(dbWeapon);
        }

        [HttpGet(Name = "GetAllColdWeapons")]
        public async Task<IActionResult> GetAllColdWeaponsAsync()
        {
            var weapons = await _coldWeaponService.GetAllAsync();

            var weaponViewModels = _mapper.Map<List<ColdWeapon>, List<ColdWeaponViewModel>>(weapons);
            return Ok(weaponViewModels);
        }

        [HttpPut("{id}", Name = "UpdateColdWeapon")]
        public async Task<IActionResult> UpdateWeaponAsync(int id, [FromBody] ColdWeaponViewModel productColdWeapon)
        {

            var coldWeapon = _mapper.Map<ColdWeaponViewModel, ColdWeapon>(productColdWeapon);


            var updatedColdWeapon = await _coldWeaponService.UpdateAsync(id, coldWeapon);

            return Ok(updatedColdWeapon);
        }

        [HttpDelete("id", Name = "DeleteColdWeapon")]
        public async Task<IActionResult> DeleteWeaponAsync(int id)
        {
            await _coldWeaponService.DeleteAsync(id);

            return Ok("ColdWeapon was deleted succesfully");
        }

        //[HttpGet(Name = "GetPaginationColdWeapons")]
        //public async Task<IActionResult> GetPaginationColdWeaponsAsync([FromBody] PaginatorColdWeapon paginator)
        //{

        //    var weapons = await _coldWeaponService.GetPaginationColdWeaponsAsync(paginator);

        //    var weaponViewModels = _mapper.Map<List<ColdWeapon>, List<ColdWeaponViewModel>>(weapons);
        //    return Ok(weaponViewModels);
        //}

        [HttpPost("filter", Name = "ColdWeaponFiltering")]
        public async Task<IActionResult> GetItemsByFilter([FromBody] ColdWeaponRequest request)
        {
            var coldWeapons = await _coldWeaponService.GetColdWeaponsByFilter(request);
            return Ok(coldWeapons);
        }
        

    }
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
