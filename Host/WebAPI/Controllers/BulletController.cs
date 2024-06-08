using ApplicationServices.Services;
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
    public class BulletController : ControllerBase
    {
        private readonly IBulletService _bulletService;
        private readonly IMapper _mapper;

        public BulletController(IBulletService bulletService, IMapper mapper)
        {
            _bulletService = bulletService;
            _mapper = mapper;
        }

        [HttpPost(Name = "AddBullet")]
        public async Task<IActionResult> CreateBulletAsync([FromBody] BulletViewModel productBullet)
        {
            var bullet = _mapper.Map<BulletViewModel, Bullet>(productBullet);

            var dbBullet = await _bulletService.CreateAsync(bullet);

            return Ok(dbBullet);
        }

        [HttpGet(Name = "GetAllBullets")]
        public async Task<IActionResult> GetAllBulletsAsync()
        {
            var bullets = await _bulletService.GetAllAsync();

            var bulletViewModels = _mapper.Map<List<Bullet>, List<BulletViewModel>>(bullets);
            return Ok(bulletViewModels);
        }

        [HttpPut("{id}", Name = "UpdateBullet")]
        public async Task<IActionResult> UpdateBulletAsync(int id, [FromBody] BulletViewModel productBullet)
        {

            var bullet = _mapper.Map<BulletViewModel, Bullet>(productBullet);


            var updatedBullet = await _bulletService.UpdateAsync(id, bullet);

            return Ok(updatedBullet);
        }

        [HttpDelete("id", Name = "DeleteBullet")]
        public async Task<IActionResult> DeleteBulletAsync(int id)
        {
            await _bulletService.DeleteAsync(id);

            return Ok("Bullet was deleted succesfully");
        }
    }
}
