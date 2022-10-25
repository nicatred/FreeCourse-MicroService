using AutoMapper;
using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Services.Catalog.Model;
using System.ComponentModel;

namespace FreeCourse.Services.Catalog.Mapping
{
    public class GeneralMapper:Profile
    {
        public GeneralMapper()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCrateDto>().ReverseMap();
            CreateMap<Feature,FeatureDto>().ReverseMap();


            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Course,CourseCreateDto>().ReverseMap();
            CreateMap<Course,CourseUpdateDto>().ReverseMap();
        }
    }
}
