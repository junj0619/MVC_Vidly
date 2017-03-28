using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>().ForMember(c=>c.Id,opt=>opt.Ignore());
            Mapper.CreateMap<CustomerDto, Customer>();
            //Id is the key property for the Movie class, and a key property should not be changed.
            //That’s why we get this exception.To resolve this, you need to tell AutoMapper to ignore
            //Id during mapping of a MovieDto to Movie.
            Mapper.CreateMap<Movie, MovieDto>().ForMember(m=>m.Id,opt=>opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>();

            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

        }
    }
}