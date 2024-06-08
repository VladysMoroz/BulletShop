using AutoMapper;
using Core.Entities;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.AutoMapper.BulletMappers
{
    public class FromBulletViewModelToBulletMapper : Profile
    {
        public FromBulletViewModelToBulletMapper()
        {
            CreateMap<BulletViewModel, Bullet>()

                .ForMember(dest => dest.BulletWeight, opt => opt.MapFrom(src => src.BulletWeight))
                .ForMember(dest => dest.QuantityInPackage, opt => opt.MapFrom(src => src.QuantityInPackage))
                .ForMember(dest => dest.Caliber, opt => opt.MapFrom(src => src.Caliber))

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
