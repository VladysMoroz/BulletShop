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
    public class FromBulletToBulletViewModelMapper : Profile
    {
        public FromBulletToBulletViewModelMapper()
        {
            CreateMap<Bullet, BulletViewModel>()

                .ForMember(dest => dest.BulletWeight, opt => opt.MapFrom(src => src.BulletWeight))
                .ForMember(dest => dest.QuantityInPackage, opt => opt.MapFrom(src => src.QuantityInPackage))
                .ForMember(dest => dest.Caliber, opt => opt.MapFrom(src => src.Caliber))

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
