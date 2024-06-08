using AutoMapper;
using Core.Entities;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.AutoMapper.ColdWeaponMapper
{
    public class FromColdWeaponViewModelToColdWeaponMapper : Profile
    {
        public FromColdWeaponViewModelToColdWeaponMapper()
        {
            CreateMap<ColdWeaponViewModel, ColdWeapon>()
              .ForMember(dest => dest.HandleMaterialUA, opt => opt.MapFrom(src => src.HandleMaterialUA))
              .ForMember(dest => dest.HandleMaterialENG, opt => opt.MapFrom(src => src.HandleMaterialENG))
              .ForMember(dest => dest.Hardness, opt => opt.MapFrom(src => src.Hardness))
              .ForMember(dest => dest.BladeMaterialENG, opt => opt.MapFrom(src => src.BladeMaterialENG))
              .ForMember(dest => dest.BladeMaterialUA, opt => opt.MapFrom(src => src.BladeMaterialUA))
              .ForMember(dest => dest.LockUA, opt => opt.MapFrom(src => src.LockUA))
              .ForMember(dest => dest.LockENG, opt => opt.MapFrom(src => src.LockENG))

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
