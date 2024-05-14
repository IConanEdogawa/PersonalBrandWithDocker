using MediatR;
using Microsoft.AspNetCore.Identity;
using PersonalBrand.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBrand.Application.UseCases.IdentitieCases.Queries
{
    public class GetAllUsersQuery : IRequest<List<IdentityUserLogin>>
    {
        

    }
}
