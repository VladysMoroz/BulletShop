using AutoMapper;
using Core.Entities;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.AutoMapper.OpticMappers
{
    public class FromOpticToOpticViewModelMapper : Profile
    {
        public FromOpticToOpticViewModelMapper()
        {
            CreateMap<Optic, OpticViewModel>()

                .ForMember(dest => dest.AdjustmentOfParallax_FocusingENG, opt => opt.MapFrom(src => src.AdjustmentOfParallax_FocusingENG))
                .ForMember(dest => dest.AdjustmentOfParallax_FocusingUA, opt => opt.MapFrom(src => src.AdjustmentOfParallax_FocusingUA))
                .ForMember(dest => dest.Multiplicity, opt => opt.MapFrom(src => src.Multiplicity))
                .ForMember(dest => dest.ObjectiveLensDiameter, opt => opt.MapFrom(src => src.ObjectiveLensDiameter))
                .ForMember(dest => dest.ReticleIllumination, opt => opt.MapFrom(src => src.ReticleIllumination))
                .ForMember(dest => dest.RingDiameterUA, opt => opt.MapFrom(src => src.RingDiameterUA))
                .ForMember(dest => dest.RingDiameterENG, opt => opt.MapFrom(src => src.RingDiameterENG))
                .ForMember(dest => dest.TypeOfReticle, opt => opt.MapFrom(src => src.TypeOfReticle))

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
