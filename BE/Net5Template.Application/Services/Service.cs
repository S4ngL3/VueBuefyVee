using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Net5Template.Application.Interfaces;
using Net5Template.Data.Entities;
using Net5Template.Domain.Interfaces;
using Net5Template.Domain.Models;

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

        public OperationModel WriteGroupTask(GroupTaskWriteModel model)
        {
            var entity = new GroupTask()
            {
                StrName = model.StrName,    //GroupName
                StrDescriptions = model.StrDescriptions,    //Description
                IntObjectFor = model.IntObjectFor,  //Object apply for
                IntGroupFor = model.IntGroupFor,    //Type
                IntGroupBy = model.IntGroupBy,  //Order
            };

            try
            {
                _unitOfWork.GroupTaskRepository.Insert(entity);

                _unitOfWork.Commit();

                return new OperationModel() { Result = 1, Message = "Thêm mới thành công" };
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                return new OperationModel() { Result = 0, Message = $"SQL error exception { ex.Message }" };
            }
            catch(Exception ex)
            {
                //Log
                return new OperationModel() { Result = 0, Message = ex.Message };
            }
        }
    }
}
