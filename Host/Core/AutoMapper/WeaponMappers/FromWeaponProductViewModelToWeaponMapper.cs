using AutoMapper;
using Core.Entities;
using Core.ViewModels;

namespace Core.AutoMapper.WeaponMappers
{
    public class FromWeaponProductViewModelToWeaponMapper : Profile
    {
        public FromWeaponProductViewModelToWeaponMapper()
        {
            CreateMap<WeaponViewModel, Weapon>()
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
              .ForMember(dest => dest.TypeENG, opt => opt.MapFrom(src => src.TypeENG))

            // PRODUCT PROPERTIES

              .ForPath(dest => dest.Product.NameUA, opt => opt.MapFrom(src => src.NameUA))
              .ForPath(dest => dest.Product.NameENG, opt => opt.MapFrom(src => src.NameENG))
              .ForPath(dest => dest.Product.ManufacturerUA, opt => opt.MapFrom(src => src.ManufacturerUA))
              .ForPath(dest => dest.Product.ManufacturerENG, opt => opt.MapFrom(src => src.ManufacturerENG))
              .ForPath(dest => dest.Product.DescriptionUA, opt => opt.MapFrom(src => src.DescriptionUA))
              .ForPath(dest => dest.Product.DescriptionENG, opt => opt.MapFrom(src => src.DescriptionENG))
              .ForPath(dest => dest.Product.Weight, opt => opt.MapFrom(src => src.Weight))
              .ForPath(dest => dest.Product.Photo, opt => opt.MapFrom(src => src.Photo))
              .ForPath(dest => dest.Product.Quantity, opt => opt.MapFrom(src => src.Quantity))
              .ForPath(dest => dest.Product.Price, opt => opt.MapFrom(src => src.Price))
              .ForPath(dest => dest.Product.SubCategoryId, opt => opt.MapFrom(src => src.SubCategoryId));
        }
    }
}
