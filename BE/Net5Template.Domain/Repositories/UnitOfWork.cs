using System;
using System.Collections.Generic;
using System.Text;
using Net5Template.Data;
using Net5Template.Data.Entities;
using Net5Template.Domain.Interfaces;

namespace Net5Template.Domain.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppPosContext _context;

        public UnitOfWork(AppPosContext context)
        {
            _context = context;
        }

        private bool _disposed = false;
        public void Commit()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private GenericRepository<GroupTask> _groupTaskRepository;
        public GenericRepository<GroupTask> GroupTaskRepository
        {
            get
            {

                if (this._groupTaskRepository == null)
                {
                    this._groupTaskRepository = new GenericRepository<GroupTask>(_context);
                }
                return _groupTaskRepository;
            }
        }


    }
}
