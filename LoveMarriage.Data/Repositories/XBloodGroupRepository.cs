using LoveMarriage.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoveMarriage.Data.Repositories
{
    public class XBloodGroupRepository : Repository<XBloodGroup>, IXBloodGroupRepository
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="context"></param>
        public XBloodGroupRepository(LoveMarriageDBContext context)
            :base(context)
        {
        }

        public IEnumerable<XBloodGroup> GetRareBloodGroup()
        {
            yield return loveMarriageContext.XBloodGroup.FirstOrDefault(x => x.BloodGroup.Contains("O-"));
        }

        public IEnumerable<XBloodGroup> GetUniversalDonorBloodGroup()
        {
            yield return loveMarriageContext.XBloodGroup.FirstOrDefault(x => x.BloodGroup.Contains("O"));
        }
        public LoveMarriageDBContext loveMarriageContext
        {
            //_context is passed(inherited) from generic repository
            //here getting set to native property
            get { return _context as LoveMarriageDBContext; }
        }
    }
}
