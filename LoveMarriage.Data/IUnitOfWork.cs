using LoveMarriage.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoveMarriage.Data
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// List all the repositories bellow 
        /// </summary>
        IXBloodGroupRepository XBloodGroup { get; }

        /// <summary>
        /// Complete indicates end of unit of work
        /// </summary>
        /// <returns></returns>
        int Complete();
    }
}
