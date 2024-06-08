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
    public class FromOpticViewModelToOpticMapper : Profile
    {
        public FromOpticViewModelToOpticMapper()
        {
            CreateMap<OpticViewModel, Optic>()
              .ForMember(dest => dest.AdjustmentOfParallax_FocusingENG, opt => opt.MapFrom(src => src.AdjustmentOfParallax_FocusingENG))
              .ForMember(dest => dest.AdjustmentOfParallax_FocusingUA, opt => opt.MapFrom(src => src.AdjustmentOfParallax_FocusingUA))
              .ForMember(dest => dest.Multiplicity, opt => opt.MapFrom(src => src.Multiplicity))
              .ForMember(dest => dest.ObjectiveLensDiameter, opt => opt.MapFrom(src => src.ObjectiveLensDiameter))
              .ForMember(dest => dest.ReticleIllumination, opt => opt.MapFrom(src => src.ReticleIllumination))
              .ForMember(dest => dest.RingDiameterUA, opt => opt.MapFrom(src => src.RingDiameterUA))
              .ForMember(dest => dest.RingDiameterENG, opt => opt.MapFrom(src => src.RingDiameterENG))
              .ForMember(dest => dest.TypeOfReticle, opt => opt.MapFrom(src => src.TypeOfReticle))

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
