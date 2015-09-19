using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.DAL.Entities;

namespace ExaminationSystem.DAL.AbstractRepositories
{
    public abstract class CommonRepositoryAbstract<TEntity>: ICommonRepository<TEntity>
        where TEntity : class, IEntity
    {
        public void Add(TEntity entity)
        {
            using (var context = new ExamContext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public bool Update(TEntity entity)
        {
            bool result;
            using (var context = new ExamContext())
            {
                result = context.Themes.Find(entity.Id) != null;
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
            Theme target;
            bool result;
            using (var context = new ExamContext())
            {
                target = context.Themes.Find(id);
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



        
    }
}
