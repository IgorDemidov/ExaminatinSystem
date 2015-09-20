using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.DAL.Entities;

namespace ExaminationSystem.DAL.AbstractRepositories
{
    public abstract class CommonRepository<TEntity>: ICommonRepository<TEntity>
        where TEntity : class, IEntity
    {
        public void Add(TEntity entity)
        {
            using (var context = new ExamContext())
            {
                context.Set<TEntity>().Add(entity);
                //context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public bool Update(TEntity entity)
        {
            bool result;
            using (var context = new ExamContext())
            {
                result = context.Set<TEntity>().Find(entity.Id) != null;
                if (result)
                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            return result;
        }

        public bool Delete(int id)
        {
            TEntity target;
            bool result;
            using (var context = new ExamContext())
            {
                target = context.Set<TEntity>().Find(id);
                if (target != null)
                {
                    context.Entry(target).State = EntityState.Deleted;
                    context.SaveChanges();
                    result = true;
                }
                else
                    result = false;
            }
            return result;
        }

        public abstract TEntity Get(int id);

    }
}
