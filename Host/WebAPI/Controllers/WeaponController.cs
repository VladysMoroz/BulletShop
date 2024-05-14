using ApplicationServices.Services;
using AutoMapper;
using Core.Entities;
using Core.Interfaces.Services;
using Core.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;
        private readonly IMapper _mapper;

        public WeaponController(IWeaponService weaponService, IMapper mapper)
        {
            _weaponService = weaponService;
            _mapper = mapper;
        }

        [HttpPost(Name = "AddWeapon")]
        public async Task<IActionResult> CreateWeaponAsync([FromBody] WeaponProductViewModel productWeapon)
        {
            var weapons = _mapper.Map<WeaponProductViewModel, Weapon>(productWeapon);

            var dbWeapon = await _weaponService.CreateAsync(weapons);

            return Ok(dbWeapon);
        }

        [HttpGet(Name = "GetAllWeapons")]
        public async Task<IActionResult> GetAllWeaponsAsync()
        {
            var weapons = await _weaponService.GetAllAsync();

            var weaponViewModels = _mapper.Map<List<Weapon>, List<WeaponProductViewModel>>(weapons);
            return Ok(weaponViewModels);
        }


        [HttpPut("{id}", Name = "UpdateWeapon")]
        public async Task<IActionResult> UpdateWeaponAsync(int id, [FromBody] WeaponProductViewModel productWeapon)
        {

            var weapons = _mapper.Map<WeaponProductViewModel, Weapon>(productWeapon);
            

            var updatedWeapon = await _weaponService.UpdateAsync(id, weapons);

            return Ok(updatedWeapon);
        }

        [HttpDelete("id", Name = "DeleteWeapon")]
        [Authorize]
        public async Task<IActionResult> DeleteWeaponAsync(int id)
        {
            await _weaponService.DeleteAsync(id);

            return Ok("Weapon was deleted succesfully");
        }
    }
}
