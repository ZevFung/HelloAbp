﻿using AutoMapper;
using Volo.Abp.Identity;

namespace Xhznl.HelloAbp
{
    public class HelloAbpApplicationAutoMapperProfile : Profile
    {
        public HelloAbpApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<OrganizationUnit, OrganizationUnitDto>()
                .MapExtraProperties();
            CreateMap<IdentityUserOrgCreateDto, IdentityUserCreateDto>();
        }
    }
}
