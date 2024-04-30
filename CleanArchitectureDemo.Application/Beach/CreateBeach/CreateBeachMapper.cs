using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Application.Beach.CreateBeach
{
    public class CreateBeachMapper : Profile
    {
        public CreateBeachMapper()
        {
            CreateMap<CreateBeachRequest, CleanArchitectureDemo.Domain.Entities.Beach>();
        }
    }
}
