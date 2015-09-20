using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DAL.Entities
{
    public class Question: IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public int ThemeId { get; set; }

        
        public Theme Theme { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
