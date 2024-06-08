using AutoMapper;
using Core.Entities;
using Core.ViewModels;

namespace Core.AutoMapper.AmmunitionMappers
{
    public class FromAmmunitionToAmmunitionViewModelMapper : Profile
    {
        public FromAmmunitionToAmmunitionViewModelMapper()
        {
            CreateMap<Ammunition, AmmunitionViewModel>()

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
