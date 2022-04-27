using System;
using System.Collections.Generic;
using System.Text;
using Net5Template.Data.Entities;
using Net5Template.Domain.Repositories;

namespace Net5Template.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void Dispose();

        GenericRepository<GroupTask> GroupTaskRepository { get; }
    }
}
