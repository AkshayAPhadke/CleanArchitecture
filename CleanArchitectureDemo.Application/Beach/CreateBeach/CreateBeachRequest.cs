using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Application.Beach.CreateBeach
{
    public class CreateBeachRequest : IRequest<int>
    {
        public string? BeachName { get; set; }

        public string? Place { get; set; }
        public string? ImageUrl { get; set; }
    }
}
