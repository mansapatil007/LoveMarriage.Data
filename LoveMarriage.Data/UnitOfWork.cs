using LoveMarriage.Data.Models;
using LoveMarriage.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoveMarriage.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LoveMarriageDBContext _context;

        public UnitOfWork(LoveMarriageDBContext context)
        {
            _context = context;
            //inject context to all the repositories bellow
            XBloodGroup = new XBloodGroupRepository(_context);
        }

        //use similar implementation for all the repositories
        public IXBloodGroupRepository XBloodGroup { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
