using Net5Template.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Net5Template.Application.Interfaces
{
    public interface IService
    {
        OperationModel WriteGroupTask(GroupTaskWriteModel model);
    }
}
