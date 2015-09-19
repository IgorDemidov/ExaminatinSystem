using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.DAL.Entities;

namespace ExaminationSystem.DAL.AbstractRepositories
{
    public interface ICommonRepository<TEntity> 
        where TEntity : class, IEntity
    {
        void Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(int id);
    }
}
