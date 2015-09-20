using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DAL.Entities
{
    public class Answer: IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsRight { get; set; }
        public int QuestionId { get; set; }

        public Question Question { get; set; }
    }
}
