using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DAL.Entities
{
    public class Answer: IEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsRight { get; set; }

        public Question Question { get; set; }
    }
}
