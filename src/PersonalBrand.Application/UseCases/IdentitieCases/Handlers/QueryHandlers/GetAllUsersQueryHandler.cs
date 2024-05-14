using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalBrand.Application.UseCases.IdentitieCases.Queries;
using PersonalBrand.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBrand.Application.UseCases.IdentitieCases.Handlers.QueryHandlers
{
    internal class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<IdentityUserLogin>>
    {
        private readonly IdentityDbContext _context;

        public GetAllUsersQueryHandler(IdentityDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.UserLogins.ToListAsync();

            return result;
        }
    }
}
