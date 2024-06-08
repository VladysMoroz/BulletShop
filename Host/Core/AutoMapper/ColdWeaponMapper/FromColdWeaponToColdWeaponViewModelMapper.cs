using AutoMapper;
using Core.Entities;
using Core.ViewModels;

namespace Core.AutoMapper.ColdWeaponMapper
{
    public class FromColdWeaponToColdWeaponViewModelMapper : Profile
    {
        public FromColdWeaponToColdWeaponViewModelMapper()
        {
            CreateMap<ColdWeapon, ColdWeaponViewModel>()
              .ForMember(dest => dest.HandleMaterialUA, opt => opt.MapFrom(src => src.HandleMaterialUA))
              .ForMember(dest => dest.HandleMaterialENG, opt => opt.MapFrom(src => src.HandleMaterialENG))
              .ForMember(dest => dest.Hardness, opt => opt.MapFrom(src => src.Hardness))
              .ForMember(dest => dest.BladeMaterialENG, opt => opt.MapFrom(src => src.BladeMaterialENG))
              .ForMember(dest => dest.BladeMaterialUA, opt => opt.MapFrom(src => src.BladeMaterialUA))
              .ForMember(dest => dest.LockUA, opt => opt.MapFrom(src => src.LockUA))
              .ForMember(dest => dest.LockENG, opt => opt.MapFrom(src => src.LockENG))

              // PRODUCT PROPERTIES

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
              .ForMember(dest => dest.SubCategoryId, opt => opt.MapFrom(src => src.Product.SubCategoryId));

        }
    }
}
