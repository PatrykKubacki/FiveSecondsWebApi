using AutoMapper;
using FiveSecondsWebApi.Domain.Models;
using FiveSecondsWebApi.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiveSecondsWebApi.Infrastructure.Mappers
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Questions, QuestionsDTO>();

            }).CreateMapper();
    }
}
