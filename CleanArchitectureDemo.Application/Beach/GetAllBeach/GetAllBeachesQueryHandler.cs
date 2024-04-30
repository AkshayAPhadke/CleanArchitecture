using AutoMapper;
using MediatR;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureDemo.Application.Context;

namespace CleanArchitectureDemo.Application.Beach.GetAllBeach
{
    public class GetAllBeachesQueryHandler : IRequestHandler<GetAllBeachesRequest, List<GetAllBeachesResponse>>
    {
        private readonly IMyWorldDbContext _myWorldDbContext;
        private readonly IMapper _mapper;
        public GetAllBeachesQueryHandler(IMyWorldDbContext myWorldDbContext,
        IMapper mapper)
        {
            _myWorldDbContext = myWorldDbContext;
            _mapper = mapper;
        }
        public Task<List<GetAllBeachesResponse>> Handle(GetAllBeachesRequest request, CancellationToken cancellationToken)
        {
            return _myWorldDbContext.Beach.ProjectTo<GetAllBeachesResponse>(_mapper.ConfigurationProvider)
            .ToListAsync();
        }
    }
}
