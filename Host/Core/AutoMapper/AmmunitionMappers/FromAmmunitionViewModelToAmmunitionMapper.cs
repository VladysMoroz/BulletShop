using AutoMapper;
using Core.Entities;
using Core.ViewModels;

namespace Core.AutoMapper.AmmunitionMappers
{
    public class FromAmmunitionViewModelToAmmunitionMapper : Profile
    {
        public FromAmmunitionViewModelToAmmunitionMapper()
        {
            CreateMap<AmmunitionViewModel, Ammunition>()

                .ForMember(dest => dest.GenderUA, opt => opt.MapFrom(src => src.GenderUA))
                .ForMember(dest => dest.GenderENG, opt => opt.MapFrom(src => src.GenderENG))
                .ForMember(dest => dest.ProtectionLevelUA, opt => opt.MapFrom(src => src.ProtectionLevelUA))
                .ForMember(dest => dest.ProtectionLevelENG, opt => opt.MapFrom(src => src.ProtectionLevelENG))
                .ForMember(dest => dest.ColorUA, opt => opt.MapFrom(src => src.ColorUA))
                .ForMember(dest => dest.ColorENG, opt => opt.MapFrom(src => src.ColorENG))
                .ForMember(dest => dest.SeasonUA, opt => opt.MapFrom(src => src.SeasonUA))
                .ForMember(dest => dest.SeasonENG, opt => opt.MapFrom(src => src.SeasonENG))
                .ForMember(dest => dest.SizeUA, opt => opt.MapFrom(src => src.SizeUA))
                .ForMember(dest => dest.SizeENG, opt => opt.MapFrom(src => src.SizeENG))


              // Product Properties

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
