using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Application.Beach.GetAllBeach
{
    public class GetAllBeachesRequest : IRequest<List<GetAllBeachesResponse>>
    {
    }
}
