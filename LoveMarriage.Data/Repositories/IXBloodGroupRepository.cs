using LoveMarriage.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoveMarriage.Data.Repositories
{
    public interface IXBloodGroupRepository :IRepository<XBloodGroup>
    {
        IEnumerable<XBloodGroup> GetRareBloodGroup();
        IEnumerable<XBloodGroup> GetUniversalDonorBloodGroup();
    }
}
