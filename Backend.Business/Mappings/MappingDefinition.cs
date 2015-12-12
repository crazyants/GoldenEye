﻿using AutoMapper;
using GoldenEye.Backend.Business.Entities;
using GoldenEye.Backend.Security.Model;
using GoldenEye.Shared.Business.DTOs;
using GoldenEye.Shared.Core.DTOs;
using GoldenEye.Shared.Core.Mappings;

namespace GoldenEye.Backend.Business.Mappings
{
    public class MappingDefinition : Profile, IMappingDefinition
    {
        protected override void Configure()
        {
            Mapper.CreateMap<TaskEntity, TaskDTO>()
                .ForMember(el => el.Progress, opt => opt.Ignore())
                .IgnoreNonExistingProperties();
            Mapper.CreateMap<TaskDTO, TaskEntity>()
                .ForMember(el => el.Progress, opt => opt.Ignore())
                .IgnoreNonExistingProperties();
            Mapper.CreateMap<Customer, CustomerDTO>().IgnoreNonExistingProperties();
            Mapper.CreateMap<CustomerDTO, Customer>().IgnoreNonExistingProperties();
            Mapper.CreateMap<TaskTypeEntity, TaskTypeDTO>().IgnoreNonExistingProperties();
            Mapper.CreateMap<TaskTypeDTO, TaskTypeEntity>().IgnoreNonExistingProperties();
            Mapper.CreateMap<User, UserDTO>().IgnoreNonExistingProperties();
            Mapper.CreateMap<UserDTO, User>().IgnoreNonExistingProperties();
        }
    }
}