using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.DAL.AbstractRepositories;
using ExaminationSystem.DAL.Entities;

namespace ExaminationSystem.DAL.ConcreteRepositories
{
    public class AnswerRepository : CommonRepository<Answer>, IAnswerRepository
    {
        public override Answer Get(int id)
        {
            throw new NotImplementedException();
        }

    }
}
