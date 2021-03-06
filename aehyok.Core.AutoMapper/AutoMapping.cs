﻿using aehyok.Core.Data.Entity.GuideLine;
using aehyok.Core.Data.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace aehyok.Core.AutoMapper
{

    /// <summary>
    /// 映射指定字段 https://www.cnblogs.com/jicheng/p/8004520.html
    /// </summary>
    public class AutoMapping: Profile
    {
        public AutoMapping()
        {
            CreateMap<User, UserDTO>();
            CreateMap<MD_GuideLine, GuideLineModel>()
                .ForMember(dest => dest.Id, item => item.MapFrom(source => source.Id))
                .ForMember(dest => dest.Title, item => item.MapFrom(source => source.GuideLineName))
                .ForMember(dest => dest.Field, item => item.MapFrom(source => source.Id))
                .ForMember(dest => dest.Id, item => item.MapFrom(source => source.Id))
                .ForMember(dest => dest.Id, item => item.MapFrom(source => source.Id));
        }
    }

    /// <summary>
    /// 测试用例
    /// </summary>
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        // Constructor to initialize User
        public User()
        {
            Name = "Nicky";
            Email = "myemail@gmail.com";
            Phone = "+81234588";
        }
    }

    public class UserDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
