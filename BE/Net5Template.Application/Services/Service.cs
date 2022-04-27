using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Net5Template.Application.Interfaces;
using Net5Template.Domain.Interfaces;

namespace Net5Template.Application.Services
{
    public partial class Service: IService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;

        public Service(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }
    }
}
