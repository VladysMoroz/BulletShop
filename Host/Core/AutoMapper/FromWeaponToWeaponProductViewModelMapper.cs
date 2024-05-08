using AutoMapper;
using Core.Entities;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.AutoMapper
{
    public class FromWeaponToWeaponProductViewModelMapper : Profile
    {
        public FromWeaponToWeaponProductViewModelMapper()
        {
            CreateMap<Weapon, WeaponProductViewModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.NameUA, opt => opt.MapFrom(src => src.Product.NameUA))
            .ForMember(dest => dest.NameENG, opt => opt.MapFrom(src => src.Product.NameENG))
            .ForMember(dest => dest.ManufacturerUA, opt => opt.MapFrom(src => src.Product.ManufacturerUA))
            .ForMember(dest => dest.ManufacturerENG, opt => opt.MapFrom(src => src.Product.ManufacturerENG))
            .ForMember(dest => dest.DescriptionUA, opt => opt.MapFrom(src => src.Product.DescriptionUA))
            .ForMember(dest => dest.DescriptionENG, opt => opt.MapFrom(src => src.Product.DescriptionENG))
            .ForMember(dest => dest.Weight, opt => opt.MapFrom(src => src.Product.Weight))
            .ForMember(dest => dest.Photo, opt => opt.MapFrom(src => src.Product.Photo))
            .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Product.Quantity))
            .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Product.Price))
            .ForMember(dest => dest.SubCategoryId, opt => opt.MapFrom(src => src.Product.SubCategoryId))
            .ForMember(dest => dest.Caliber, opt => opt.MapFrom(src => src.Caliber))
            .ForMember(dest => dest.MagazineCapacity, opt => opt.MapFrom(src => src.MagazineCapacity))
            .ForMember(dest => dest.GeneralLength, opt => opt.MapFrom(src => src.GeneralLength))
            .ForMember(dest => dest.BarrelLength, opt => opt.MapFrom(src => src.BarrelLength))
            .ForMember(dest => dest.SightingDevicesUA, opt => opt.MapFrom(src => src.SightingDevicesUA))
            .ForMember(dest => dest.SightingDevicesENG, opt => opt.MapFrom(src => src.SightingDevicesENG))
            .ForMember(dest => dest.GunStockAndButtUA, opt => opt.MapFrom(src => src.GunStockAndButtUA))
            .ForMember(dest => dest.GunStockAndButtENG, opt => opt.MapFrom(src => src.GunStockAndButtENG))
            .ForMember(dest => dest.InitialVelocity, opt => opt.MapFrom(src => src.InitialVelocity))
            .ForMember(dest => dest.BarrelTwist, opt => opt.MapFrom(src => src.BarrelTwist))
            .ForMember(dest => dest.TypeUA, opt => opt.MapFrom(src => src.TypeUA))
            .ForMember(dest => dest.TypeENG, opt => opt.MapFrom(src => src.TypeENG));
        }
    }
}
