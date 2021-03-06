﻿using AutoMapper;
using IdentityServer4.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WQLIdentity.Application.Dtos.IdentityResources
{
    public class IdentityResourceMapping:Profile
    {
        public IdentityResourceMapping()
        {



            CreateMap<CreateIdentityResourceDto, IdentityResource>().ForMember(x => x.UserClaims, opt => opt.MapFrom(src => src.UserClaims.Select(x => new IdentityClaim { Type = x })));


            CreateMap<IdentityResource, IdentityResourceDto>(MemberList.Destination)
                .ForMember(x => x.UserClaims, opt => opt.MapFrom(src => src.UserClaims.Select(x => x.Type)));



            CreateMap<IdentityResourcePropertyDto, IdentityResourceProperty>();
        }
    }
}
